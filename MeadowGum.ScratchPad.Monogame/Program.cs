using MeadowGum.Renderer.MicroGraphics;
using MeadowGum.ScratchPad.Common.Screens;
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

var renderer = new MicroGraphicsRenderer(environment.Display, Environment.CurrentDirectory);
MeadowGumComponent.DefaultRenderer = renderer;

var screen = new Screen1Runtime();

screen.Render();
renderer.Show();

await Task.Delay(1000);
screen.SplashScreenInstance.DescriptionText = "3";
screen.Render();
renderer.Show();

await Task.Delay(1000);
screen.SplashScreenInstance.DescriptionText = "2";
screen.Render();
renderer.Show();

await Task.Delay(1000);
screen.SplashScreenInstance.DescriptionText = "1";
screen.Render();
renderer.Show();

await Task.Delay(1000);
screen.SplashScreenInstance.DescriptionText = "Go";
screen.Render();
renderer.Show();

await Task.Delay(1000);
screen.SplashScreenInstance.Visible = false;
screen.Render();
renderer.Show();

while (true)
{
    screen.Render();
    renderer.Show();
}