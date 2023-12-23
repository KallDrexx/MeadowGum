using System.Threading.Tasks;
using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Graphics;
using MeadowGum.Renderer.MicroGraphics;
using MeadowGum.ScratchPad.Common.Screens;
using MeadowGum.Shared.Components;

namespace MeadowGum.ScratchPad.ProjectLab3;

public class MeadowApp : App<F7CoreComputeV2>
{
    private IGraphicsDisplay _display = default!;
    private IProjectLabHardware _projectLab = default!;

    public override Task Initialize()
    {
        _projectLab = ProjectLab.Create();
        _display = _projectLab.Display!;

        return Task.CompletedTask;
    }

    public override Task Run()
    {
        var renderer = new MicroGraphicsRenderer(_display, MeadowOS.FileSystem.UserFileSystemRoot);
        MeadowGumComponent.DefaultRenderer = renderer;

        var screen = new Screen1Runtime();
        while (true)
        {
            screen.Render();
            renderer.Show();
        }
    }
}