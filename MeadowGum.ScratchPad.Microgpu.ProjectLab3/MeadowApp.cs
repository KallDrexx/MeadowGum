using System;
using System.Threading.Tasks;
using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Graphics;
using Meadow.Hardware;
using Meadow.Units;
using MeadowGum.Core.Components;
using MeadowGum.Renderer.Microgpu;
using MeadowGum.ScratchPad.Common;
using Microgpu.Common;
using Microgpu.Common.Comms;

namespace MeadowGum.ScratchPad.Microgpu.ProjectLab3;

public class MeadowApp : App<F7CoreComputeV2>
{
    private IGraphicsDisplay _display = default!;
    private IProjectLabHardware _projectLab = default!;
    private Gpu _gpu = default!;

    public override async Task Initialize()
    {
        _projectLab = ProjectLab.Create();
        _display = _projectLab.Display!;
       
        var reset = Device.CreateDigitalOutputPort(Device.Pins.D02, true);
        var handshake = Device.CreateDigitalInputPort(Device.Pins.D03, ResistorMode.Disabled);
        var chipSelect = Device.CreateDigitalOutputPort(Device.Pins.D14, true);

        var config = new SpiClockConfiguration(
            new Frequency(10, Frequency.UnitType.Megahertz),
            SpiClockConfiguration.Mode.Mode0);

        var spiBus = Device.CreateSpiBus(Device.Pins.SPI5_SCK, Device.Pins.SPI5_COPI, Device.Pins.SPI5_CIPO,
            config);
       
        Console.WriteLine("Initializing GPU");
        var gpuCommunication = new MeadowSpiGpuCommunication(spiBus, handshake, reset, chipSelect);
        _gpu = await Gpu.CreateAsync(gpuCommunication);
        await _gpu.InitializeAsync(1);
    }

    public override async Task Run()
    {
        PeripheralManager.Peripherals = new ProjectLabPeripherals(_projectLab, TimeSpan.FromMilliseconds(200));

        InputManager.Instance.RegisterButton(_projectLab.LeftButton!, ButtonNames.Up);
        InputManager.Instance.RegisterButton(_projectLab.UpButton!, ButtonNames.Right);
        InputManager.Instance.RegisterButton(_projectLab.RightButton!, ButtonNames.Down);
        InputManager.Instance.RegisterButton(_projectLab.DownButton!, ButtonNames.Left);

        var renderer = new MicrogpuRenderer(_gpu, MeadowOS.FileSystem.UserFileSystemRoot);
        MeadowGumComponent.DefaultRenderer = renderer;

        Console.WriteLine("Running meadow gum sample");
        await AppRunner.RunAsync();
    }
}