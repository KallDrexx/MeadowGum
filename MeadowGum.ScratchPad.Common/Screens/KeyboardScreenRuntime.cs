using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MeadowGum.ScratchPad.Common.Components;
using MeadowGum.Shared;

namespace MeadowGum.ScratchPad.Common.Screens;

partial class KeyboardScreenRuntime : MeadowGumScreen
{
    private List<KeyCapRuntime> _selectableElements = new();
    private int _selectedElementIndex;
    
    partial void CustomInitialize()
    {
        _selectableElements = KeyCapArea.Children.OfType<KeyCapRuntime>().ToList();
        _selectableElements[_selectedElementIndex].SelectionState = KeyCapRuntime.Selection.Selected;
    }

    public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
    {
        while (true)
        {
            Render();
            var buttonEvent = await InputManager.Instance.WaitForNextButtonAsync(cancellationToken);
            if (buttonEvent != null)
            {
                var nextScreen = HandleButtonEvent(buttonEvent);
                if (nextScreen != null)
                {
                    return nextScreen;
                }
            }
        }
    }

    private MeadowGumScreen? HandleButtonEvent(InputManager.ButtonEvent buttonEvent)
    {
        switch (buttonEvent.Name)
        {
            case ButtonNames.Right:
            {
                _selectableElements[_selectedElementIndex].SelectionState = KeyCapRuntime.Selection.UnSelected;
                _selectedElementIndex++;
                if (_selectedElementIndex >= _selectableElements.Count)
                {
                    _selectedElementIndex = 0;
                }
                _selectableElements[_selectedElementIndex].SelectionState = KeyCapRuntime.Selection.Selected;
                break;
            }

            case ButtonNames.Left:
            {
                _selectableElements[_selectedElementIndex].SelectionState = KeyCapRuntime.Selection.UnSelected;
                _selectedElementIndex--;
                if (_selectedElementIndex < 0)
                {
                    _selectedElementIndex = _selectableElements.Count - 1;
                }
                _selectableElements[_selectedElementIndex].SelectionState = KeyCapRuntime.Selection.Selected;
                break;
            }

            case ButtonNames.Up:
            {
                var key = _selectableElements[_selectedElementIndex].KeyText;
                var typedKeyLength = TypedTextDisplay.Text.Length - 1;
                if (key == "Del")
                {
                    if (typedKeyLength > 0)
                    {
                        TypedTextDisplay.Text = TypedTextDisplay.Text.Substring(0, typedKeyLength - 1) + "_";
                    }
                }
                else if (key == "Quit")
                {
                    return new MainMenuRuntime();
                }

                else
                {
                    TypedTextDisplay.Text = $"{TypedTextDisplay.Text.Substring(0, typedKeyLength)}{key}_";
                }

                break;
            }
        }

        return null;
    }
}