using Gum.Wireframe;
using Meadow.Foundation;
using Meadow.Foundation.Graphics;
using MeadowGum.Shared;

namespace MeadowGum.Renderer.MicroGraphics;

public class MicroGraphicsRenderer : IComponentRenderer
{
    private readonly Meadow.Foundation.Graphics.MicroGraphics _buffer;

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

    public void Show()
    {
        _buffer.Show();
        _buffer.Clear(Color.Black);
    }
}