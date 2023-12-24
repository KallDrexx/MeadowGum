using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MeadowGum.Shared.Components;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared;

public abstract class MeadowGumScreen
{
    protected List<IRenderableIpso> Children { get; } = new();

    /// <summary>
    ///     Runs the current screen.  Returns the next screen to run, or null if the application should exit.
    /// </summary>
    /// <param name="cancellationToken">
    ///     The cancellation token which signals that the screen should abort early
    /// </param>
    public abstract Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken);

    protected void Render()
    {
        foreach (var child in Children) DoRender(child);

        MeadowGumComponent.DefaultRenderer!.Show();
    }

    private static void DoRender(IRenderableIpso ipso)
    {
        if (!ipso.Visible) return;

        ipso.Render(null);
        foreach (var child in ipso.Children) DoRender(child);
    }
}