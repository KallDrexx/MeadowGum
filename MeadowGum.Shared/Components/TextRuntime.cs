using System;
using RenderingLibrary;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components;

public class TextRuntime : MeadowGumComponent
{
    private readonly InvisibleTextRenderable _renderable;
    
    public TextRuntime()
    {
        _renderable = new InvisibleTextRenderable {Visible = true};
        SetContainedObject(_renderable);
        Width = 100;
        Height = 50;
    }
    
    public string Text
    {
        get => _renderable.RawText;
        set => _renderable.RawText = value;
    }

    public MeadowFont MeadowFont { get; set; } = MeadowFont.Font8X12;
    public HorizontalAlignment HorizontalAlignment { get; set; }
    public VerticalAlignment VerticalAlignment { get; set; }

    public byte Red { get; set; } = 255;
    public byte Green { get; set; } = 255;
    public byte Blue { get; set; } = 255;
    public bool Wrap { get; set; }
   
    // Unsupported properties
    public int Alpha { get; set; }
    public float FontScale { get; set; }
    public float LineHeightMultiplier { get; set; }
    public TextOverflowHorizontalMode TextOverflowHorizontalMode { get; set; }

    public override void Render(ISystemManagers managers)
    {
        if (DefaultRenderer == null) throw new InvalidOperationException("No default renderer set");

        var area = new Rectangle(
            (int)this.GetAbsoluteLeft(),
            (int)this.GetAbsoluteTop(),
            (int)GetAbsoluteWidth(),
            (int)GetAbsoluteHeight());

        var color = new RgbColor(Red, Green, Blue);
        var textAlignment = new TextAlignment(HorizontalAlignment, VerticalAlignment);

        DefaultRenderer.RenderText(area, textAlignment, color, MeadowFont, Wrap, Text);
    }

    private class InvisibleTextRenderable : InvisibleRenderable, IText
    {
        public MeadowFont Font { get; set; } = MeadowFont.Font8X12;
        public float DescenderHeight => 0;
        public float FontScale => 1;
        public float WrappedTextWidth => Font.WidthPerCharacter() * RawText.Length;
        public float WrappedTextHeight => Font.HeightPerCharacter(); // TODO: Add wrapping support
        public string RawText { get; set; }
        public TextOverflowVerticalMode TextOverflowVerticalMode { get; set; }
        
        public void SetNeedsRefreshToTrue()
        {
        }

        public void UpdatePreRenderDimensions()
        {
        }
    }
}