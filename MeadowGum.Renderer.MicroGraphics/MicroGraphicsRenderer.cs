using Gum.Wireframe;
using Meadow.Foundation;
using Meadow.Foundation.Graphics;
using MeadowGum.Shared;
using HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment;
using VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment;

namespace MeadowGum.Renderer.MicroGraphics;

public class MicroGraphicsRenderer : IComponentRenderer
{
    private readonly Meadow.Foundation.Graphics.MicroGraphics _buffer;
    private readonly Font8x12 _font8X12 = new Font8x12();

    public MicroGraphicsRenderer(IGraphicsDisplay display)
    {
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
        string text)
    {
        switch (font)
        {
            case MeadowFont.Font8X12:
                _buffer.CurrentFont = _font8X12;
                break;
            
            case MeadowFont.Unspecified:
            default:
                throw new NotSupportedException(font.ToString());
        }

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

    public void Show()
    {
        _buffer.Show();
        _buffer.Clear(Color.Black);
    }
}