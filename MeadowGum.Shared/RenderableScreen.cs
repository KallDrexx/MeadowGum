using System.Collections.Generic;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared;

public abstract class RenderableScreen
{
    protected List<IRenderableIpso> Children { get; } = new();

    public void Render()
    {
        foreach (var child in Children) DoRender(child);
    }

    private void DoRender(IRenderableIpso ipso)
    {
        if (!ipso.Visible)
        {
            return;
        }
        
        ipso.Render(null);
        foreach (var child in ipso.Children)
        {
            DoRender(child);
        }
    }
}