using Gum.Wireframe;
using MeadowGum.ScratchPad.Common.Screens;
using MeadowGum.Shared.Components;
using MeadowMgTestEnvironment;
using RenderingLibrary.Graphics;

var environment = new TestEnvironment(320, 240)
{
    Display =
    {
        SleepAfterShow = TimeSpan.FromMilliseconds(16),
    }
};

var renderer = new MeadowGum.Renderer.MicroGraphics.MicroGraphicsRenderer(environment.Display);
MeadowGumComponent.DefaultRenderer = renderer;


var screen = new Screen1Runtime();

while (true)
{
    screen.Render();
    renderer.Show();
}