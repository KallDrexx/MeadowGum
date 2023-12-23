namespace MeadowGum.Shared.Components;

public class SpriteRuntime : MeadowGumComponent
{
    private SpriteRenderable _renderable;

    public string? SourceFile
    {
        get => _renderable.SourceFile;
        set => _renderable.SourceFile = value;
    }
    
    public SpriteRuntime()
    {
        _renderable = new SpriteRenderable();
        SetContainedObject(_renderable);
    }
}