using Gum.Wireframe;

namespace MeadowGum.Core.Components;

public abstract class MeadowGumComponent : GraphicalUiElement
{
    public static IComponentRenderer? DefaultRenderer { get; set; }
}