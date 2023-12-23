using System;
using System.Collections.ObjectModel;
using Gum;
using RenderingLibrary;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components;

public class ColoredRectangleRenderable : IRenderableIpso
{
    public byte Red { get; set; } = 255;
    public byte Green { get; set; } = 255;
    public byte Blue { get; set; } = 255;

    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public float Rotation { get; set; }
    public bool FlipHorizontal { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public string Name { get; set; }
    public object Tag { get; set; }
    public bool Visible { get; set; }
    public ObservableCollection<IRenderableIpso> Children { get; } = new();
    public ColorOperation ColorOperation => ColorOperation.ColorTextureAlpha;
    public BlendState BlendState => BlendState.Opaque;
    public bool Wrap => false;
    IVisible IVisible.Parent => null!;
    public bool ClipsChildren => false;
    public bool AbsoluteVisible => true;
    public IRenderableIpso? Parent { get; set; }

    public void Render(ISystemManagers managers)
    {
        if (MeadowGumComponent.DefaultRenderer == null)
        {
            const string message = "No default renderer set yet";
            throw new InvalidOperationException(message);
        }

        var area = new Rectangle(
            (int)this.GetAbsoluteLeft(),
            (int)this.GetAbsoluteTop(),
            (int)Width,
            (int)Height);

        var color = new RgbColor(Red, Green, Blue);

        MeadowGumComponent.DefaultRenderer.RenderRectangle(area, color);
    }

    public void PreRender()
    {
    }

    public void SetParentDirect(IRenderableIpso newParent)
    {
        Parent = newParent;
    }
}