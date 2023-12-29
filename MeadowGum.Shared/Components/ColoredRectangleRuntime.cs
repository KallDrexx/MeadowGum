using System;
using RenderingLibrary;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components;

public class ColoredRectangleRuntime : MeadowGumComponent
{
    public ColoredRectangleRuntime()
    {
        SetContainedObject(new InvisibleRenderable{Visible = true});
        Width = 50;
        Height = 50;
    }

    public int Red { get; set; } = 255;
    public int Green { get; set; } = 255;
    public int Blue { get; set; } = 255;

    public override void Render(ISystemManagers managers)
    {
        if (DefaultRenderer == null)
        {
            const string message = "No default renderer set yet";
            throw new InvalidOperationException(message);
        }

        var area = new Rectangle(
            (int)this.GetAbsoluteLeft(),
            (int)this.GetAbsoluteTop(),
            (int)GetAbsoluteWidth(),
            (int)GetAbsoluteHeight());

        var color = new RgbColor((byte) Red, (byte) Green, (byte) Blue);

        DefaultRenderer.RenderRectangle(area, color);
    }
}