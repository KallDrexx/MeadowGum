using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MeadowGum.ScratchPad.Common.Components;
using MeadowGum.Shared;

namespace MeadowGum.ScratchPad.Common.Screens
{
    partial class MainMenuRuntime : MeadowGumScreen
    {
        private List<SpriteButtonRuntime> _buttons = null!;
        private int _selectedIndex = 0;
        
        partial void CustomInitialize()
        {
            _buttons = ButtonContainer.Children.OfType<SpriteButtonRuntime>().ToList();

            if (_buttons.Any())
            {
                _buttons[0].Select();
            }
        }

        public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
        {
            Render();

            while (!cancellationToken.IsCancellationRequested)
            {
                var keyboardEvent = await InputManager.Instance.WaitForNextButtonAsync(cancellationToken);
                if (keyboardEvent?.Name == ButtonNames.Up && keyboardEvent.State == InputManager.ButtonState.Clicked)
                {
                    if (_selectedIndex > 0)
                    {
                        _selectedIndex--;
                        _buttons[_selectedIndex].Select();
                        _buttons[_selectedIndex + 1].Deselect();
                    }
                    
                    Render();
                }
                
                else if (keyboardEvent?.Name == ButtonNames.Down &&
                         keyboardEvent.State == InputManager.ButtonState.Clicked)
                {
                    if (_selectedIndex < _buttons.Count - 1)
                    {
                        _selectedIndex++;
                        _buttons[_selectedIndex].Select();
                        _buttons[_selectedIndex - 1].Deselect();
                    }
                    
                    Render();
                }
                
                else if (keyboardEvent?.Name == ButtonNames.Right &&
                         keyboardEvent.State == InputManager.ButtonState.Clicked)
                {
                    if (_buttons[_selectedIndex] == TestScreen1Button)
                    {
                        return new SplashScreenRuntime
                        {
                            TitleText = "Test Screen 1",
                            DescriptionText = "Basic layout test screen. Press Left to go back to the main menu",
                            NextScreen = () => new Screen1Runtime(),
                        };
                    }
                }
            }

            return null;
        }
    }
}