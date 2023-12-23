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
}