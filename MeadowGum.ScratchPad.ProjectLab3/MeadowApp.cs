using System;
using System.Threading.Tasks;
using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Graphics;
using MeadowGum.Renderer.MicroGraphics;
using MeadowGum.ScratchPad.Common;
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

    public override async Task Run()
    {
        var renderer = new MicroGraphicsRenderer(_display, MeadowOS.FileSystem.UserFileSystemRoot);
        MeadowGumComponent.DefaultRenderer = renderer;
        PeripheralManager.Peripherals = new ProjectLabPeripherals(_projectLab, TimeSpan.FromMilliseconds(200));

        InputManager.Instance.RegisterButton(_projectLab.UpButton, ButtonNames.Up);
        InputManager.Instance.RegisterButton(_projectLab.RightButton, ButtonNames.Right);
        InputManager.Instance.RegisterButton(_projectLab.DownButton, ButtonNames.Down);
        InputManager.Instance.RegisterButton(_projectLab.LeftButton, ButtonNames.Left);

        await AppRunner.RunAsync();
    }
}