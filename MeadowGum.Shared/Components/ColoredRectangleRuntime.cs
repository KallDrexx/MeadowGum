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

    public int Red
    {
        get => _renderable.Red;
        set => _renderable.Red = (byte)value;
    }

    public int Green
    {
        get => _renderable.Green;
        set => _renderable.Green = (byte)value;
    }

    public int Blue
    {
        get => _renderable.Blue;
        set => _renderable.Blue = (byte)value;
    }
}