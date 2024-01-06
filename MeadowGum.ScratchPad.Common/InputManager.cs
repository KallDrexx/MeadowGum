using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Meadow.Foundation.Sensors.Buttons;
using Meadow.Peripherals.Sensors.Buttons;

namespace MeadowGum.ScratchPad.Common;

public class InputManager
{
    public enum ButtonState
    {
        Clicked,
        Held,
        NoLongerHeld
    }

    private static readonly Lazy<InputManager> _instance = new(new InputManager());

    private readonly ConcurrentQueue<ButtonEvent> _buttonEvents = new();
    private readonly Dictionary<IButton, string> _buttons = new();

    private InputManager()
    {
    }

    public static InputManager Instance => _instance.Value;

    public void RegisterButton(IButton button, string name)
    {
        _buttons.Add(button, name);

        button.Clicked += ButtonOnClicked;
        button.LongClicked += ButtonOnLongClicked;
    }

    public ButtonEvent? NextButtonEvent()
    {
        if (_buttonEvents.TryDequeue(out var buttonEvent)) return buttonEvent;

        return null;
    }

    public async Task<ButtonEvent?> WaitForNextButtonAsync(CancellationToken cancellationToken, TimeSpan? timeout = null)
    {
        var stopWatch = Stopwatch.StartNew();
        while (!cancellationToken.IsCancellationRequested)
        {
            if (_buttonEvents.TryDequeue(out var buttonEvent)) return buttonEvent;
            if (timeout != null && stopWatch.Elapsed >= timeout.Value)
            {
                return null;
            }

            await Task.Delay(100, cancellationToken);
        }

        return null;
    }

    private void ButtonOnClicked(object sender, EventArgs e)
    {
        if (_buttons.TryGetValue((PushButton)sender, out var name))
        {
            _buttonEvents.Enqueue(new ButtonEvent(name, ButtonState.Clicked));
        }
    }

    private void ButtonOnLongClicked(object sender, EventArgs e)
    {
        if (_buttons.TryGetValue((PushButton)sender, out var name))
        {
            _buttonEvents.Enqueue(new ButtonEvent(name, ButtonState.Clicked));
        }
    }

    public record ButtonEvent(string Name, ButtonState State);
}