using System;
using System.Collections.ObjectModel;
using Gum;
using RenderingLibrary;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components;

public class SpriteRenderable : IRenderableIpso, IAspectRatio, ITextureCoordinate
{
    public string? SourceFile { get; set; }
    public RgbColor? TransparentColor { get; set; } = new RgbColor(255, 0, 255);
    public float AspectRatio { get; }

    public BlendState BlendState { get; } = BlendState.Opaque;
    public bool Wrap { get; set; } = false;
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public float Rotation { get; set; }
    public bool FlipHorizontal { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public string Name { get; set; }
    public object? Tag { get; set; }
    public bool Visible { get; set; } = true;
    public bool AbsoluteVisible { get; } = true;
    public IRenderableIpso Parent { get; set; }
    public ObservableCollection<IRenderableIpso> Children { get; } = new();
    public ColorOperation ColorOperation { get; } = ColorOperation.ColorTextureAlpha;
    public bool ClipsChildren { get; } = false;
    IVisible IVisible.Parent { get; }

    public void Render(ISystemManagers managers)
    {
        if (MeadowGumComponent.DefaultRenderer == null)
        {
            const string message = "No default renderer set yet";
            throw new InvalidOperationException(message);
        }

        if (SourceRectangle == null || string.IsNullOrWhiteSpace(SourceFile))
            // nothing to render
            return;

        var textureArea = new Rectangle(SourceRectangle.Value.X,
            SourceRectangle.Value.Y,
            SourceRectangle.Value.Width,
            SourceRectangle.Value.Height);

        var renderLocation = new Point((int)X, (int)Y);

        MeadowGumComponent.DefaultRenderer.RenderSprite(SourceFile, textureArea, renderLocation, TransparentColor);
    }

    public void PreRender()
    {
    }

    public void SetParentDirect(IRenderableIpso newParent)
    {
    }

    public System.Drawing.Rectangle? SourceRectangle { get; set; }
    public float? TextureWidth { get; }
    public float? TextureHeight { get; }
}