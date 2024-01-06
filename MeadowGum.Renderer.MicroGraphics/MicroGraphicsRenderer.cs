using Gum.Wireframe;
using Meadow.Foundation;
using Meadow.Foundation.Graphics;
using Meadow.Foundation.Graphics.Buffers;
using MeadowGum.Shared;
using HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment;
using Point = MeadowGum.Shared.Point;
using VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment;

namespace MeadowGum.Renderer.MicroGraphics;

public class MicroGraphicsRenderer : IComponentRenderer
{
    private readonly Meadow.Foundation.Graphics.MicroGraphics _buffer;
    private readonly string _contentRoot;
    private readonly Font8x12 _font8X12 = new();
    private readonly Font12x16 _font12X16 = new();
    private readonly Dictionary<string, IPixelBuffer> _textureBuffers = new();

    public MicroGraphicsRenderer(IGraphicsDisplay display, string contentRoot)
    {
        _contentRoot = contentRoot;
        GraphicalUiElement.CanvasWidth = display.Width;
        GraphicalUiElement.CanvasHeight = display.Height;
        _buffer = new Meadow.Foundation.Graphics.MicroGraphics(display);
    }

    public void RenderRectangle(Rectangle area, RgbColor color)
    {
        _buffer.DrawRectangle(area.X, area.Y, area.Width, area.Height, color.ToColor(), true);
    }

    public void RenderText(
        Rectangle area,
        TextAlignment textAlignment,
        RgbColor color,
        MeadowFont font,
        bool wrap,
        string text)
    {
        switch (font)
        {
            case MeadowFont.Font8X12:
                _buffer.CurrentFont = _font8X12;
                break;
            
            case MeadowFont.Font12X16:
                _buffer.CurrentFont = _font12X16;
                break;

            case MeadowFont.Unspecified:
            default:
                throw new NotSupportedException(font.ToString());
        }

        if (!wrap)
        {
            RenderUnwrappedText(area, textAlignment, color, text);
        }
        else
        {
            RenderWrappedText(area, textAlignment, color, font, text);
        }
    }

    public void RenderSprite(string textureName,
        Rectangle textureArea,
        Point screenPosition,
        RgbColor? transparentColor)
    {
        var textureBuffer = GetTextureBuffer(textureName);
        DrawPartialBuffer(textureBuffer, textureArea, screenPosition, transparentColor);
    }

    public void Show()
    {
        _buffer.Show();
        _buffer.Clear(Color.Black);
    }

    private IPixelBuffer GetTextureBuffer(string textureName)
    {
        if (_textureBuffers.TryGetValue(textureName, out var texture)) return texture;

        texture = LoadBitmapFile(textureName);
        _textureBuffers.Add(textureName, texture);
        return texture;
    }

    private IPixelBuffer LoadBitmapFile(string name)
    {
        var filePath = Path.Combine(_contentRoot, name);

        try
        {
            var img = Image.LoadFromFile(filePath);

            // Always make sure that the texture is formatted in the same color mode as the display
            var imgBuffer = CreateBuffer(img.Width, img.Height);
            imgBuffer.WriteBuffer(0, 0, img.DisplayBuffer);
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

    private IPixelBuffer CreateBuffer(int width, int height)
    {
        switch (_buffer.ColorMode)
        {
            case ColorMode.Format16bppRgb565: return new BufferRgb565(width, height);
            default:
                throw new NotSupportedException($"Color mode {_buffer.ColorMode} is not supported");
        }
    }

    private void DrawPartialBuffer(IPixelBuffer source,
        Rectangle sourceArea,
        Point destinationPosition,
        RgbColor? transparentColor)
    {
        for (var x = 0; x < sourceArea.Width; x++)
        for (var y = 0; y < sourceArea.Height; y++)
        {
            var pixel = source.GetPixel(x + sourceArea.X, y + sourceArea.Y);
            if (transparentColor != null &&
                transparentColor.Value.Red == pixel.R &&
                transparentColor.Value.Green == pixel.G &&
                transparentColor.Value.Blue == pixel.B)
                continue;

            _buffer.DrawPixel(x + destinationPosition.X, y + destinationPosition.Y, pixel);
        }
    }
    
    private void RenderUnwrappedText(
        Rectangle area,
        TextAlignment textAlignment,
        RgbColor color,
        string text)
    {
        switch (textAlignment.HorizontalAlignment)
        {
            case HorizontalAlignment.Right:
                // MicroGraphics will render right aligned text starting from the X position and going left, but
                // the X position will be the left position of the text area. So we need to adjust the X position
                // to be the right side of the text area, instead of the left.
                area = area with { X = area.X + area.Width };
                break;

            case HorizontalAlignment.Center:
                // Adjust the X position to be the center of the text area
                area = area with { X = area.X + area.Width / 2 };
                break;
        }

        switch (textAlignment.VerticalAlignment)
        {
            case VerticalAlignment.Bottom:
                // Adjust the Y position to be the bottom of the text area
                area = area with { Y = area.Y + area.Height };
                break;

            case VerticalAlignment.Center:
                // Adjust the Y position to be the center of the text area
                area = area with { Y = area.Y + area.Height / 2 };
                break;
        }

        _buffer.DrawText(area.X,
            area.Y,
            text,
            color.ToColor(),
            ScaleFactor.X1,
            textAlignment.HorizontalAlignment.ToHorizontalAlignment(),
            textAlignment.VerticalAlignment.ToVerticalAlignment());
    }

    private void RenderWrappedText(Rectangle area, TextAlignment textAlignment, RgbColor color, MeadowFont font, string text)
    {
        var lines = SplitText(text, font, area.Width);
        var lineHeight = font.HeightPerCharacter();

        switch (textAlignment.VerticalAlignment)
        {
            case VerticalAlignment.Top:
                // Starting at the top of the given area, so nothing to do
                break;

            case VerticalAlignment.Center:
            {
                var centerY = area.Y + (area.Height / 2);
                var totalHeight = lines.Count * lineHeight;
                area = area with {Y = centerY - (totalHeight / 2), Height = lineHeight};
                break;
            }

            case VerticalAlignment.Bottom:
            {
                var bottomY = area.Y + area.Height;
                var totalHeight = lines.Count * lineHeight;
                area = area with {Y = bottomY - totalHeight, Height = lineHeight};
                break;
            }
        }
        
        foreach (var line in lines)
        {
            RenderUnwrappedText(area, textAlignment, color, line);
            area = area with {Y = area.Y + lineHeight};
        }
    }

    private static List<string> SplitText(string text, MeadowFont font, int areaWidth)
    {
        var lines = new List<string>();
        var widthPerCharacter = font.WidthPerCharacter();
        var lastSpaceIndex = 0;
        var currentLineStartIndex = 0;
        for (var x = 0; x < text.Length; x++)
        {
            switch (text[x])
            {
                case ' ':
                    lastSpaceIndex = x;
                    break;
                
                case '\n':
                    lines.Add(text.Substring(currentLineStartIndex, x - currentLineStartIndex));
                    currentLineStartIndex = x + 1;
                    lastSpaceIndex = x + 1;
                    continue;
            }
            
            var lineWidth = (x - currentLineStartIndex) * widthPerCharacter;
            if (lineWidth > areaWidth)
            {
                if (lastSpaceIndex == 0 || lastSpaceIndex <= currentLineStartIndex)
                {
                    // no spaces in the line, so we need to split the word
                    lines.Add(text.Substring(currentLineStartIndex, x - currentLineStartIndex));
                    currentLineStartIndex = x;
                }
                else
                {
                    // there was a space in the line, so we can split on that
                    lines.Add(text.Substring(currentLineStartIndex, lastSpaceIndex - currentLineStartIndex));
                    currentLineStartIndex = lastSpaceIndex + 1;
                }
            }
        }
        
        lines.Add(text[currentLineStartIndex..]);
        return lines;
    }
}