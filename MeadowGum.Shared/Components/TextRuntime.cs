using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components;

public class TextRuntime : MeadowGumComponent
{
    private readonly TextRenderable _renderable;

    public TextRuntime()
    {
        _renderable = new TextRenderable();
        SetContainedObject(_renderable);
        Width = 100;
        Height = 50;
    }

    public string Text
    {
        get => _renderable.Text;
        set => _renderable.Text = value;
    }

    public MeadowFont Font
    {
        get => _renderable.Font;
        set => _renderable.Font = value;
    }

    public HorizontalAlignment HorizontalAlignment
    {
        get => _renderable.HorizontalAlignment;
        set => _renderable.HorizontalAlignment = value;
    }

    public VerticalAlignment VerticalAlignment
    {
        get => _renderable.VerticalAlignment;
        set => _renderable.VerticalAlignment = value;
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

    public bool Wrap
    {
        get => _renderable.Wrap;
        set => _renderable.Wrap = value;
    }
}