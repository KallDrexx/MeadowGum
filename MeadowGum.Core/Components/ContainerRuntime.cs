using RenderingLibrary.Graphics;

namespace MeadowGum.Core.Components;

public class ContainerRuntime : MeadowGumComponent
{
    public ContainerRuntime()
    {
        SetContainedObject(new InvisibleRenderable { Visible = true });
        Visible = true;
        Width = 150;
        Height = 150;
    }
    
    public string? ContainedType { get; set; }
}