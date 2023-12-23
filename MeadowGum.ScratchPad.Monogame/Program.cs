using MeadowGum.Renderer.MicroGraphics;
using MeadowGum.ScratchPad.Common.Screens;
using MeadowGum.Shared.Components;
using MeadowMgTestEnvironment;

var environment = new TestEnvironment(320, 240)
{
    Display =
    {
        SleepAfterShow = TimeSpan.FromMilliseconds(16)
    }
};

var renderer = new MicroGraphicsRenderer(environment.Display, Environment.CurrentDirectory);
MeadowGumComponent.DefaultRenderer = renderer;


var screen = new Screen1Runtime();

while (true)
{
    screen.Render();
    renderer.Show();
}