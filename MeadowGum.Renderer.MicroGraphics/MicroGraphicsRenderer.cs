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
            
            default:
                throw new NotSupportedException(font.ToString());
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