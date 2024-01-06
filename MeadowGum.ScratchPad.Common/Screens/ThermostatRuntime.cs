using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gum.Wireframe;
using MeadowGum.ScratchPad.Common.Components;
using MeadowGum.Shared;

namespace MeadowGum.ScratchPad.Common.Screens;

partial class ThermostatRuntime : MeadowGumScreen
{
    private readonly List<GraphicalUiElement> _selectableElements = new();
    private int _selectedElementIndex;
    private bool _moveToMainMenu;

    partial void CustomInitialize()
    {
        PeripheralManager.Peripherals.StartUpdating();

        TargetTempProgressBar.SetColor(VerticalProgressBarRuntime.Color.Red);
        EcoProgressBar.SetColor(VerticalProgressBarRuntime.Color.Green);
        EnergyProgressBar.SetColor(VerticalProgressBarRuntime.Color.Yellow);
        StatusValue.MeadowFont = MeadowFont.Font12X16;
        StatusDisplay.UpdateLayout();
        ActivityState = Activity.Idle;

        _selectableElements.Add(TargetTempSlider);
        _selectableElements.Add(EcoModeToggle);
        _selectableElements.Add(FahrenheitToggle);
        _selectableElements.Add(ResetButton);
        _selectableElements.Add(ExitButton);
        HoverInstance.AttachTo(_selectableElements[_selectedElementIndex]);

        TargetTempSlider.Maximum = 90;
        TargetTempSlider.Minimum = 60;
        TargetTempSlider.Increment = 5;
        TargetTempSlider.Value = 85;

        ExitButton.OnSelected = () => _moveToMainMenu = true;
        ResetButton.OnSelected = OnResetSelected;
    }

    public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
    {
        while (!_moveToMainMenu)
        {
            UpdateUiState();
            Render();
            
            var buttonEvent = await InputManager.Instance.WaitForNextButtonAsync(cancellationToken, TimeSpan.FromSeconds(1));
            if (buttonEvent != null)
            {
                HandleButtonEvent(buttonEvent);
            }
        }

        PeripheralManager.Peripherals.StopUpdating();
        return new MainMenuRuntime();
    }

    private void HandleButtonEvent(InputManager.ButtonEvent buttonEvent)
    {
        if (buttonEvent.State != InputManager.ButtonState.Clicked) return;

        switch (buttonEvent.Name)
        {
            case ButtonNames.Up:
                HandleChangeButtonPressed(-1);
                break;

            case ButtonNames.Down:
                HandleChangeButtonPressed(1);
                break;

            case ButtonNames.Right:
                HandleActivationPressed();
                break;

            case ButtonNames.Left:
                HandleDeactivationPressed();
                break;
        }
    }

    private void HandleChangeButtonPressed(int moveBy)
    {
        _selectedElementIndex += moveBy;
        if (_selectedElementIndex < 0) _selectedElementIndex = _selectableElements.Count - 1;
        if (_selectedElementIndex >= _selectableElements.Count) _selectedElementIndex = 0;

        HoverInstance.AttachTo(_selectableElements[_selectedElementIndex]);
    }

    private void HandleActivationPressed()
    {
        switch (_selectableElements[_selectedElementIndex])
        {
            case ToggleButtonRuntime toggle:
                toggle.SwapToggleState();
                break;

            case SliderRuntime slider:
                slider.IncrementValue();
                break;

            case SpriteButtonRuntime button:
                button.Select();
                break;
        }
    }

    private void HandleDeactivationPressed()
    {
        switch (_selectableElements[_selectedElementIndex])
        {
            case ToggleButtonRuntime toggle:
                toggle.SwapToggleState();
                break;

            case SliderRuntime slider:
                slider.DecrementValue();
                break;

            case SpriteButtonRuntime button:
                button.Deselect();
                break;
        }
    }

    private void UpdateUiState()
    {
        SuspendLayout(true);
        var temperature = PeripheralManager.Peripherals.Temperature;
        if (FahrenheitToggle.IsOn)
        {
            ActualTempDisplayValue.Text = $"{temperature.Fahrenheit:0}F";
            TargetValue.Text = $"{TargetTempSlider.Value:0}F";
            FahrenheitToggle.LabelText = "FAHRENHEIT";
        }
        else
        {
            var valueInCelsius = (TargetTempSlider.Value - 32) * 5 / 9;
            ActualTempDisplayValue.Text = $"{temperature.Celsius:0}C";
            TargetValue.Text = $"{valueInCelsius:0}C";
            FahrenheitToggle.LabelText = "CELSIUS";
        }
        
        var distance = Math.Abs(temperature.Fahrenheit - TargetTempSlider.Value);

        if (TargetTempSlider.Value < (int)temperature.Fahrenheit && distance > 2)
        {
            ActivityState = Activity.Cooling;
        }
        else if (TargetTempSlider.Value > (int)temperature.Fahrenheit && distance > 2)
        {
            ActivityState = Activity.Heating;
        }
        else
        {
            ActivityState = Activity.Idle;
        }

        var temperatureDifference = Math.Abs(temperature.Fahrenheit - TargetTempSlider.Value);

        var targetMinMaxDifference = (TargetTempSlider.Maximum - TargetTempSlider.Minimum);
        var distanceFromMiddle =
            Math.Abs(TargetTempSlider.Value - (TargetTempSlider.Maximum - targetMinMaxDifference / 2.0));

        var ecoAdjustment = EcoModeToggle.IsOn ? 1 : 0.80;
        var distanceFromMiddlePercent =
            (targetMinMaxDifference - distanceFromMiddle) / targetMinMaxDifference * 100 * ecoAdjustment;
            
        TargetTempProgressBar.Percent = (int)Math.Min(Math.Max(temperature.Fahrenheit / 100 * 100, 0), 100);
        EcoProgressBar.Percent = (int)distanceFromMiddlePercent;
        EnergyProgressBar.Percent = (int)Math.Min(temperatureDifference / 60 * 100, 100);
        
        ResumeLayout(true);
        UpdateLayout();
        // this.Children.ForEach(x => (x as GraphicalUiElement)?.UpdateLayout());

        // Reattach the hover in case of size change
        HoverInstance.AttachTo(_selectableElements[_selectedElementIndex]);
    }

    private void OnResetSelected()
    {
        SuspendLayout(true);
        TargetTempSlider.Value = 85;
        if (EcoModeToggle.IsOn)
        {
            EcoModeToggle.SwapToggleState();
        }

        if (FahrenheitToggle.IsOn)
        {
            FahrenheitToggle.SwapToggleState();
        }
        
        ResetButton.Deselect();
        ResumeLayout(true);
        UpdateLayout();
    }
}