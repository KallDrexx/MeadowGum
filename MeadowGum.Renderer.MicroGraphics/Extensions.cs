using System;
using Meadow;
using Meadow.Foundation;
using Meadow.Foundation.Graphics;
using MeadowGum.Core;

namespace MeadowGum.Renderer.MicroGraphics;

public static class Extensions
{
    public static Color ToColor(this RgbColor color)
    {
        return new Color(color.Red, color.Green, color.Blue);
    }

    public static HorizontalAlignment ToHorizontalAlignment(
        this RenderingLibrary.Graphics.HorizontalAlignment horizontalAlignment)
    {
        return horizontalAlignment switch
        {
            RenderingLibrary.Graphics.HorizontalAlignment.Left => HorizontalAlignment.Left,
            RenderingLibrary.Graphics.HorizontalAlignment.Center => HorizontalAlignment.Center,
            RenderingLibrary.Graphics.HorizontalAlignment.Right => HorizontalAlignment.Right,
            _ => throw new NotSupportedException(horizontalAlignment.ToString())
        };
    }

    public static VerticalAlignment ToVerticalAlignment(
        this RenderingLibrary.Graphics.VerticalAlignment verticalAlignment)
    {
        return verticalAlignment switch
        {
            RenderingLibrary.Graphics.VerticalAlignment.Top => VerticalAlignment.Top,
            RenderingLibrary.Graphics.VerticalAlignment.Center => VerticalAlignment.Center,
            RenderingLibrary.Graphics.VerticalAlignment.Bottom => VerticalAlignment.Bottom,
            _ => throw new NotSupportedException(verticalAlignment.ToString())
        };
    }
}