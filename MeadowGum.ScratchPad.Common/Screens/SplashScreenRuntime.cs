using System;
using System.Threading;
using System.Threading.Tasks;
using MeadowGum.Core;

namespace MeadowGum.ScratchPad.Common.Screens;

partial class SplashScreenRuntime : MeadowGumScreen
{
    public Func<MeadowGumScreen?> NextScreen { get; set; }
    
    partial void CustomInitialize()
    {
        Description.Wrap = true;
    }

    public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
    {
        Render();

        while (true)
        {
            var buttonEvent = await InputManager.Instance.WaitForNextButtonAsync(cancellationToken);
            if (buttonEvent?.Name == ButtonNames.Up)
            {
                if (buttonEvent.State == InputManager.ButtonState.Clicked ||
                    buttonEvent.State == InputManager.ButtonState.NoLongerHeld)
                {
                    return NextScreen();
                }
            }
        }
    }
}