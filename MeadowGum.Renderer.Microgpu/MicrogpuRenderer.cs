using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Gum.Wireframe;
using Meadow.Foundation.Graphics.Buffers;
using MeadowGum.Core;
using Microgpu.Common;
using Microgpu.Common.Operations;

namespace MeadowGum.Renderer.Microgpu;

public class MicrogpuRenderer : IComponentRenderer
{
    private readonly Gpu _gpu;
    private readonly BatchOperation _batchOperation = new();
    private readonly Dictionary<string, byte> _textureIdMap = new();
    private readonly string _contentRoot;
    private byte _nextTextureId = 1;
    
    public MicrogpuRenderer(Gpu gpu, string contentRoot)
    {
        if (!gpu.IsInitialized)
        {
            throw new InvalidOperationException("The GPU must be initialized before it can be used.");
        }
        
        _gpu = gpu;
        _contentRoot = contentRoot;

        GraphicalUiElement.CanvasWidth = gpu.DisplayResolution.X;
        GraphicalUiElement.CanvasHeight = gpu.DisplayResolution.Y;
    }
    
    public void RenderRectangle(Rectangle area, RgbColor color)
    {
        var operation = new DrawRectangleOperation<ColorRgb565>
        {
            Color = color.ToColorRgb565(),
            Width = (ushort)area.Width,
            Height = (ushort)area.Height,
            StartX = (ushort)area.X,
            StartY = (ushort)area.Y,
            TextureId = 0,
        };
        
        AddOperation(operation);
    }

    public void RenderText(Rectangle area, TextAlignment textAlignment, RgbColor color, MeadowFont font, bool wrap, string text)
    {
        var gpuFont = font.ToGpuFontId();
        var operation = new DrawCharsOperation<ColorRgb565>
        {
            Color = color.ToColorRgb565(),
            Font = gpuFont,
            StartX = (ushort)area.X,
            StartY = (ushort)area.Y,
            Text = text,
            TextureId = 0,
        };
        
        AddOperation(operation);
    }

    public void RenderSprite(string textureName, Rectangle textureArea, Point screenPosition, RgbColor? transparentColor)
    {
        if (!_textureIdMap.TryGetValue(textureName, out var textureId))
        {
            Console.WriteLine($"Sending new texture to GPU: {textureName}");
            var textureBuffer = LoadBitmapFile(textureName);

            textureId = _nextTextureId;
            _nextTextureId++;
            
            SendTextureToGpuAsync(textureBuffer, textureId, transparentColor?.ToColorRgb565()).GetAwaiter().GetResult();
            _textureIdMap[textureName] = textureId;
        }

        var operation = new DrawTextureOperation
        {
            SourceTextureId = textureId,
            SourceWidth = (ushort) textureArea.Width,
            SourceHeight = (ushort) textureArea.Height,
            SourceStartX = (ushort) textureArea.X,
            SourceStartY = (ushort) textureArea.Y,
            TargetStartX = (short) screenPosition.X,
            TargetStartY = (short) screenPosition.Y,
            TargetTextureId = 0,
            IgnoreTransparency = transparentColor == null,
        };
        
        AddOperation(operation);
    }

    public void Show()
    {
        if (_batchOperation.HasAnyOperations())
        {
            _gpu.SendFireAndForgetAsync(_batchOperation).GetAwaiter().GetResult();
        }
        
        _gpu.SendFireAndForgetAsync(new PresentFramebufferOperation()).GetAwaiter().GetResult();
    }
    
    private void AddOperation(IFireAndForgetOperation operation)
    {
        var wasAddedToBatch = _batchOperation.AddOperation(operation);
        if (!wasAddedToBatch)
        {
            _gpu.SendFireAndForgetAsync(_batchOperation).GetAwaiter().GetResult();
            _batchOperation.AddOperation(operation);
        }
    }

    private IPixelBuffer LoadBitmapFile(string name)
    {
        var filePath = Path.Combine(_contentRoot, name);

        try
        {
            var img = Meadow.Foundation.Graphics.Image.LoadFromFile(filePath);

            // Always make sure that the texture is formatted in the same color mode as the display
            var imgBuffer = new BufferRgb565(img.Width, img.Height);
            imgBuffer.WriteBuffer(0, 0, img.DisplayBuffer!);
            Console.WriteLine($"{name} loaded to buffer of type {imgBuffer.GetType()}");
            return imgBuffer;
        }
        catch (Exception exception)
        {
            throw new Exception($"Failed to load {filePath}: The file should be a 24bit bmp, in the root " +
                                "directory with BuildAction = Content, and Copy if Newer!",
                exception);
        }
    }

    private async Task SendTextureToGpuAsync(IPixelBuffer image, byte textureId, ColorRgb565? transparentColor)
    {
        await _gpu.SendFireAndForgetAsync(new DefineTextureOperation<ColorRgb565>
        {
            Width = (ushort)image.Width,
            Height = (ushort)image.Height,
            TextureId = textureId,
            TransparentColor = transparentColor ?? ColorRgb565.FromRgb888(255, 0, 255),
        });
        
        var bytesLeft = image.Buffer.Length;
        while (bytesLeft > 0)
        {
            var bytesToSend = Math.Min(bytesLeft, 512);
            var startIndex = image.Buffer.Length - bytesLeft;

            await _gpu.SendFireAndForgetAsync(new AppendTexturePixelsOperation
            {
                TextureId = textureId,
                PixelBytes = image.Buffer.AsMemory(startIndex, bytesToSend)
            });

            bytesLeft -= bytesToSend;
        }
    }
}