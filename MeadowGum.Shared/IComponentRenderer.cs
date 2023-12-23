using RenderingLibrary.Graphics;

namespace MeadowGum.Shared;

public readonly record struct Point(int X, int Y);
public readonly record struct Rectangle(int X, int Y, int Width, int Height);
public readonly record struct RgbColor(byte Red, byte Green, byte Blue);

public readonly record struct TextAlignment(
    HorizontalAlignment HorizontalAlignment,
    VerticalAlignment VerticalAlignment);

public interface IComponentRenderer
{
    void RenderRectangle(Rectangle area, RgbColor color);

    void RenderText(Rectangle area,
        TextAlignment textAlignment,
        RgbColor color,
        MeadowFont font,
        string text);
    
    void RenderSprite(string textureName, Rectangle textureArea, Point screenPosition, RgbColor? transparentColor);

    void Show();
}