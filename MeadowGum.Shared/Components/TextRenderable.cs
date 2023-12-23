using System;
using System.Collections.ObjectModel;
using Gum;
using RenderingLibrary;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components;

public class TextRenderable : IRenderableIpso, IText
{
    public string Text { get; set; } = "Hello";
    public MeadowFont Font { get; set; } = MeadowFont.Font8X12;
    public HorizontalAlignment HorizontalAlignment { get; set; } = HorizontalAlignment.Left;
    public VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.Top;
    public byte Red { get; set; } = 255;
    public byte Green { get; set; } = 255;
    public byte Blue { get; set; } = 255;
    public BlendState BlendState { get; } = BlendState.Opaque;
    public bool Wrap { get; } = false;
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public float Rotation { get; set; }
    public bool FlipHorizontal { get; set; }
    public float Width { get; set; } = 100;
    public float Height { get; set; } = 50;
    public string Name { get; set; }
    public object Tag { get; set; }
    public bool Visible { get; set; } = true;
    public IRenderableIpso? Parent { get; set; }
    public ObservableCollection<IRenderableIpso> Children { get; } = new();
    public ColorOperation ColorOperation { get; }
    public bool ClipsChildren { get; }
    IVisible IVisible.Parent { get; } = null!;

    public bool AbsoluteVisible
    {
        get
        {
            if (((IVisible)this).Parent == null)
                return Visible;
            return Visible && ((IVisible)this).Parent.AbsoluteVisible;
        }
    }

    public void Render(ISystemManagers managers)
    {
        if (MeadowGumComponent.DefaultRenderer == null) throw new InvalidOperationException("No default renderer set");

        var area = new Rectangle(
            (int)this.GetAbsoluteLeft(),
            (int)this.GetAbsoluteTop(),
            (int)Width,
            (int)Height);

        var color = new RgbColor(Red, Green, Blue);
        var textAlignment = new TextAlignment(HorizontalAlignment, VerticalAlignment);

        MeadowGumComponent.DefaultRenderer.RenderText(area, textAlignment, color, Font, Text);
    }

    public void PreRender()
    {
    }

    public void SetParentDirect(IRenderableIpso newParent)
    {
        Parent = newParent;
    }

    public float DescenderHeight => 0;
    public float FontScale => 1;
    public float WrappedTextWidth => Font.WidthPerCharacter() * Text.Length;
    public float WrappedTextHeight => Font.HeightPerCharacter();
    public string RawText => Text;
    public TextOverflowVerticalMode TextOverflowVerticalMode { get; set; }

    public void SetNeedsRefreshToTrue()
    {
    }

    public void UpdatePreRenderDimensions()
    {
    }
}