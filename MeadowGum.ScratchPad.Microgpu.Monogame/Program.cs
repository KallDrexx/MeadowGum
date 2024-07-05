using System;
using System.IO;
using Meadow.Foundation.Sensors.Buttons;
using MeadowGum.ScratchPad.Common;
using MeadowGum.Core.Components;
using MeadowGum.Renderer.Microgpu;
using MeadowGum.ScratchPad.Microgpu.Monogame;
using MeadowMgTestEnvironment;
using Microgpu.Common;
using Microgpu.Common.Comms;
using Microsoft.Xna.Framework.Input;

var environment = new TestEnvironment(320, 240)
{
    Display =
    {
        SleepAfterShow = TimeSpan.FromMilliseconds(16)
    }
};

var upButton = new PushButton(environment.CreatePortForKey(Keys.Up));
var downButton = new PushButton(environment.CreatePortForKey(Keys.Down));
var rightButton = new PushButton(environment.CreatePortForKey(Keys.Right));
var leftButton = new PushButton(environment.CreatePortForKey(Keys.Left));
InputManager.Instance.RegisterButton(upButton, ButtonNames.Up);
InputManager.Instance.RegisterButton(downButton, ButtonNames.Down);
InputManager.Instance.RegisterButton(rightButton, ButtonNames.Right);
InputManager.Instance.RegisterButton(leftButton, ButtonNames.Left);

Console.WriteLine("Connecting to TCP microgpu server on localhost:9123 ...");
var gpu = await Gpu.CreateAsync(new TcpGpuCommunication("localhost", 9123));
await gpu.InitializeAsync(1);

var renderer = new MicrogpuRenderer(gpu,  Path.Combine(Environment.CurrentDirectory, "GumLayouts"));
MeadowGumComponent.DefaultRenderer = renderer;
PeripheralManager.Peripherals = new MgPeripherals();

await AppRunner.RunAsync();
