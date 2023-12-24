using System.Threading.Tasks;
using MeadowGum.ScratchPad.Common.Screens;
using MeadowGum.Shared;

namespace MeadowGum.ScratchPad.Common;

public static class AppRunner
{
    public static async Task RunAsync()
    {
        var screenManager = new MeadowScreenManager();
        var splashScreen = new SplashScreenRuntime
        {
            TitleText = "Welcome to MeadowGum",
            DescriptionText = ""
        };

        await screenManager.StartScreen(splashScreen);
    }
}