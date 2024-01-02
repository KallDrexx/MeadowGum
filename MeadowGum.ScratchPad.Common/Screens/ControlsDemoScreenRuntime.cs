using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gum.Wireframe;
using MeadowGum.ScratchPad.Common.Components;
using MeadowGum.Shared;


namespace MeadowGum.ScratchPad.Common.Screens
{
    partial class ControlsDemoScreenRuntime : MeadowGumScreen
    {
        private readonly List<GraphicalUiElement> _selectableElements = new();
        private int _selectedIndex;
        private bool _continueRunning = true;

        partial void CustomInitialize()
        {
            MainMenuButton.OnSelected = () => _continueRunning = false;
            BoostToggle.OnToggleChanged = isOn =>
            {
                if (isOn)
                {
                    BatteryProgressBar.Percent += 40;
                }
                else
                {
                    BatteryProgressBar.Percent -= 40;
                }

                if (BatteryProgressBar.Percent > 50)
                {
                    BatteryProgressBar.SetColor(VerticalProgressBarRuntime.Color.Green);
                }
                else
                {
                    BatteryProgressBar.SetColor(VerticalProgressBarRuntime.Color.Red);
                }
            };

            _selectableElements.Add(HomeButton);
            _selectableElements.Add(MainMenuButton);
            _selectableElements.Add(SliderInstance);
            _selectableElements.Add(BoostToggle);

            HoverInstance.AttachTo(HomeButton);
            BatteryProgressBar.Percent = 20;
            BatteryProgressBar.SetColor(VerticalProgressBarRuntime.Color.Red);
            HomeProgressBar.Percent = 0;
        }

        public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
        {
            while (_continueRunning)
            {
                Render();
                var buttonEvent = await InputManager.Instance.WaitForNextButtonAsync(cancellationToken);
                if (buttonEvent?.State == InputManager.ButtonState.Clicked)
                {
                    switch (buttonEvent.Name)
                    {
                        case ButtonNames.Left:
                            ActivateSelectedItem(false);
                            break;

                        case ButtonNames.Right:
                            ActivateSelectedItem(true);
                            break;

                        case ButtonNames.Up:
                            SelectNextElement(false);
                            break;

                        case ButtonNames.Down:
                            SelectNextElement(true);
                            break;
                    }
                }
            }

            return new MainMenuRuntime();
        }

        private void SelectNextElement(bool increase)
        {
            if (increase)
            {
                _selectedIndex++;
                if (_selectedIndex >= _selectableElements.Count)
                {
                    _selectedIndex = 0;
                }
            }
            else
            {
                _selectedIndex--;
                if (_selectedIndex < 0)
                {
                    _selectedIndex = _selectableElements.Count - 1;
                }
            }

            HoverInstance.AttachTo(_selectableElements[_selectedIndex]);
        }

        private void ActivateSelectedItem(bool isPositiveActivation)
        {
            switch (_selectableElements[_selectedIndex])
            {
                case SpriteButtonRuntime button:
                {
                    if (isPositiveActivation)
                    {
                        button.Select();
                    }
                    else
                    {
                        button.Deselect();
                    }

                    break;
                }

                case ToggleButtonRuntime toggle:
                    toggle.SetToggle();
                    break;
            }
        }
    }
}