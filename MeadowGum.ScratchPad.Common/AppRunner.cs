using System.Threading.Tasks;
using MeadowGum.ScratchPad.Common.Screens;
using MeadowGum.Core;

namespace MeadowGum.ScratchPad.Common;

public static class AppRunner
{
    public static async Task RunAsync()
    {
        var screenManager = new MeadowScreenManager();
        var splashScreen = new SplashScreenRuntime
        {
            TitleText = "Welcome to MeadowGum",
            DescriptionText = "This is a demonstration of the MeadowGum UI framework.",
            NextScreen = () => new MainMenuRuntime(),
        };

        await screenManager.StartScreen(splashScreen);
    }
}