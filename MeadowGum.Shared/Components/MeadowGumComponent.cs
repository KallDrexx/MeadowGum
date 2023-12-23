using Gum.Wireframe;

namespace MeadowGum.Shared.Components;

public abstract class MeadowGumComponent : GraphicalUiElement
{
    public static IComponentRenderer? DefaultRenderer { get; set; }
}