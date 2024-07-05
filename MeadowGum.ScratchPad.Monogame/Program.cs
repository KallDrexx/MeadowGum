using System;
using System.IO;
using Meadow.Foundation.Sensors.Buttons;
using MeadowGum.Renderer.MicroGraphics;
using MeadowGum.ScratchPad.Common;
using MeadowGum.ScratchPad.Monogame;
using MeadowGum.Core.Components;
using MeadowMgTestEnvironment;
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

var renderer = new MicroGraphicsRenderer(environment.Display, Path.Combine(Environment.CurrentDirectory, "GumLayouts"));
MeadowGumComponent.DefaultRenderer = renderer;
PeripheralManager.Peripherals = new MgPeripherals();

await AppRunner.RunAsync();