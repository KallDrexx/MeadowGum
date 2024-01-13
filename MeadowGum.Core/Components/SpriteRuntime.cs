using System;
using Gum.DataTypes;
using RenderingLibrary;
using RenderingLibrary.Graphics;

namespace MeadowGum.Core.Components;

public class SpriteRuntime : MeadowGumComponent
{
    public SpriteRuntime()
    {
        SetContainedObject(new InvisibleRenderable{Visible = true});
        Height = 100;
        Width = 100;
        WidthUnits = DimensionUnitType.PercentageOfSourceFile;
        HeightUnits = DimensionUnitType.PercentageOfSourceFile;
    }

    public string? SourceFile { get; set; }

    // Unsupported
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
    public int Alpha { get; set; }
    public bool Animate { get; set; }
    public bool FlipVertical { get; set; }

    public override void Render(ISystemManagers managers)
    {
        if (DefaultRenderer == null)
        {
            const string message = "No default renderer set yet";
            throw new InvalidOperationException(message);
        }

        if (string.IsNullOrWhiteSpace(SourceFile))
            // nothing to render
            return;

        var textureArea = new Rectangle(TextureLeft,
            TextureTop,
            TextureWidth,
            TextureHeight);

        var renderLocation = new Point((int)this.GetAbsoluteLeft(), (int)this.GetAbsoluteTop());

        DefaultRenderer.RenderSprite(SourceFile, textureArea, renderLocation, new RgbColor(255, 0, 255));
    }
}