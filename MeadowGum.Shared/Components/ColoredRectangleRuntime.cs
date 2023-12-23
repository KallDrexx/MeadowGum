namespace MeadowGum.Shared.Components;

public class ColoredRectangleRuntime : MeadowGumComponent
{
    private readonly ColoredRectangleRenderable _renderable = new();

    public ColoredRectangleRuntime()
    {
        _renderable = new ColoredRectangleRenderable();
        SetContainedObject(_renderable);
        Width = 50;
        Height = 50;
    }

    public byte Red
    {
        get => _renderable.Red;
        set => _renderable.Red = value;
    }

    public byte Green
    {
        get => _renderable.Green;
        set => _renderable.Green = value;
    }

    public byte Blue
    {
        get => _renderable.Blue;
        set => _renderable.Blue = value;
    }
}