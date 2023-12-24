using Meadow.Foundation.Sensors.Buttons;
using MeadowGum.Renderer.MicroGraphics;
using MeadowGum.ScratchPad.Common;
using MeadowGum.Shared.Components;
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
InputManager.Instance.RegisterButton(upButton, ButtonNames.Up);

var renderer = new MicroGraphicsRenderer(environment.Display, Environment.CurrentDirectory);
MeadowGumComponent.DefaultRenderer = renderer;

await AppRunner.RunAsync();