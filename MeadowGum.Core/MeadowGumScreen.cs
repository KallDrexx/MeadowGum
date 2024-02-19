using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Gum.Wireframe;
using MeadowGum.Core.Components;
using RenderingLibrary.Graphics;

namespace MeadowGum.Core;

public abstract class MeadowGumScreen : GraphicalUiElement
{
    /// <summary>
    ///     Runs the current screen.  Returns the next screen to run, or null if the application should exit.
    /// </summary>
    /// <param name="cancellationToken">
    ///     The cancellation token which signals that the screen should abort early
    /// </param>
    public abstract Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken);

    protected void Render()
    {
        foreach (var child in WhatThisContains) DoRender(child);

        MeadowGumComponent.DefaultRenderer!.Show();
    }

    private static void DoRender(IRenderableIpso ipso)
    {
        if (!ipso.Visible) return;

        ipso.Render(null!);
        foreach (var child in ipso.Children) DoRender(child);
    }
}