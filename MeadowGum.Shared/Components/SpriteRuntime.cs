namespace MeadowGum.Shared.Components;

public class SpriteRuntime : MeadowGumComponent
{
    private readonly SpriteRenderable _renderable;

    public SpriteRuntime()
    {
        _renderable = new SpriteRenderable();
        SetContainedObject(_renderable);
    }

    public string? SourceFile
    {
        get => _renderable.SourceFile;
        set => _renderable.SourceFile = value;
    }

    // Unsupported
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
    public int Alpha { get; set; }
    public bool Animate { get; set; }
    public bool FlipVertical { get; set; }
}