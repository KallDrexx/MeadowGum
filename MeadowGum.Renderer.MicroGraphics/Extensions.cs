using Meadow.Foundation;
using MeadowGum.Shared;
using RenderingLibrary.Graphics;

namespace MeadowGum.Renderer.MicroGraphics;

public static class Extensions
{
    public static Color ToColor(this RgbColor color) => new Color(color.Red, color.Green, color.Blue);

    public static Meadow.Foundation.Graphics.HorizontalAlignment ToHorizontalAlignment(
        this HorizontalAlignment horizontalAlignment)
    {
        return horizontalAlignment switch
        {
            HorizontalAlignment.Left => Meadow.Foundation.Graphics.HorizontalAlignment.Left,
            HorizontalAlignment.Center => Meadow.Foundation.Graphics.HorizontalAlignment.Center,
            HorizontalAlignment.Right => Meadow.Foundation.Graphics.HorizontalAlignment.Right,
            _ => throw new NotSupportedException(horizontalAlignment.ToString())
        };
    }
    
    public static Meadow.Foundation.Graphics.VerticalAlignment ToVerticalAlignment(
        this VerticalAlignment verticalAlignment)
    {
        return verticalAlignment switch
        {
            VerticalAlignment.Top => Meadow.Foundation.Graphics.VerticalAlignment.Top,
            VerticalAlignment.Center => Meadow.Foundation.Graphics.VerticalAlignment.Center,
            VerticalAlignment.Bottom => Meadow.Foundation.Graphics.VerticalAlignment.Bottom,
            _ => throw new NotSupportedException(verticalAlignment.ToString())
        };
    }
}