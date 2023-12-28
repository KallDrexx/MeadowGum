using System.Threading;
using System.Threading.Tasks;
using MeadowGum.Shared;


namespace MeadowGum.ScratchPad.Common.Screens
{
    partial class ControlsDemoScreenRuntime : MeadowGumScreen
    {
        partial void CustomInitialize()
        {
        }

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
}