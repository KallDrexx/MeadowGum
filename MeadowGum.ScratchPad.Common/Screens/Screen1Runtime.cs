using System.Threading;
using System.Threading.Tasks;
using MeadowGum.Shared;

namespace MeadowGum.ScratchPad.Common.Screens;

public partial class Screen1Runtime : MeadowGumScreen
{
    public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
    {
        Render();
        
        while (true)
        {
            var buttonEvent = await InputManager.Instance.WaitForNextButtonAsync(cancellationToken);
            if (buttonEvent?.Name == ButtonNames.Left)
            {
                if (buttonEvent.State == InputManager.ButtonState.Clicked ||
                    buttonEvent.State == InputManager.ButtonState.NoLongerHeld)
                {
                    return new MainMenuRuntime();
                }
            }
        }
    }
}