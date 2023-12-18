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
    
    public void RenderRectangle(int x, int y, int width, int height, byte red, byte green, byte blue)
    {
        _buffer.DrawRectangle(x, y, width, height, new Color(red, green, blue), true);
    }

    public void RenderText(int x, 
        int y, 
        MeadowFont font, 
        HorizontalAlignment horizontalAlignment, 
        VerticalAlignment verticalAlignment, 
        string text, 
        byte red, 
        byte green, 
        byte blue)
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

        switch (horizontalAlignment)
        {
            case HorizontalAlignment.Left:
                break;
            
            case HorizontalAlignment.Right:
                // MG starts rendering from X to the left, so we have to adjust it so X is the right edge
                x += font.WidthPerCharacter() * text.Length;
                break;
            
            case HorizontalAlignment.Center:
                // MG starts rendering with X being the center, so we have to adjust it so X is the left edge
                x += font.WidthPerCharacter() * text.Length / 2;
                break;
        }

        switch (verticalAlignment)
        {
            case VerticalAlignment.Top:
                break;
            
            case VerticalAlignment.Bottom:
                // MG starts rendering from Y to the top, so we have to adjust it so Y is the bottom edge
                y += font.HeightPerCharacter();
                break;
            
            case VerticalAlignment.Center:
                // MG starts rendering with Y being the center, so we have to adjust it so Y is the top edge
                y += font.HeightPerCharacter() / 2;
                break;
        }
        
        var color = new Color(red, green, blue);
        _buffer.DrawText(x, 
            y, 
            text, 
            color, 
            ScaleFactor.X1, 
            ConvertHorizontalAlignment(horizontalAlignment), 
            ConvertVerticalAlignment(verticalAlignment));
    }

    public void Show()
    {
        _buffer.Show();
        _buffer.Clear(Color.Black);
    }
    
    private Meadow.Foundation.Graphics.HorizontalAlignment ConvertHorizontalAlignment(HorizontalAlignment horizontalAlignment)
    {
        return horizontalAlignment switch
        {
            HorizontalAlignment.Center => Meadow.Foundation.Graphics.HorizontalAlignment.Center,
            HorizontalAlignment.Left => Meadow.Foundation.Graphics.HorizontalAlignment.Left,
            HorizontalAlignment.Right => Meadow.Foundation.Graphics.HorizontalAlignment.Right,
            _ => throw new NotSupportedException(horizontalAlignment.ToString())
        };
    }
    
    private Meadow.Foundation.Graphics.VerticalAlignment ConvertVerticalAlignment(VerticalAlignment verticalAlignment)
    {
        return verticalAlignment switch
        {
            VerticalAlignment.Bottom => Meadow.Foundation.Graphics.VerticalAlignment.Bottom,
            VerticalAlignment.Center => Meadow.Foundation.Graphics.VerticalAlignment.Center,
            VerticalAlignment.Top => Meadow.Foundation.Graphics.VerticalAlignment.Top,
            VerticalAlignment.TextBaseline => Meadow.Foundation.Graphics.VerticalAlignment.Top,
            _ => throw new NotSupportedException(verticalAlignment.ToString())
        };
    }
}