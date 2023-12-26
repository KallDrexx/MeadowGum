using System.Threading;
using System.Threading.Tasks;
using MeadowGum.Shared.Components;

namespace MeadowGum.Shared;

public class MeadowScreenManager
{
    private CancellationTokenSource? _cancellationTokenSource;
    private Task? _currentTask;

    /// <summary>
    ///     Starts execution of the provided screen. If a screen is already running, it is cancelled. Cancellation
    ///     of an existing screen assumes that the screen has been written to handle cancellation gracefully (or at all).
    /// </summary>
    public Task StartScreen(MeadowGumScreen screen)
    {
        _cancellationTokenSource?.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        var token = _cancellationTokenSource.Token;
        _currentTask = Task.Run(async () =>
        {
            var task = screen.RunAsync(token);
            while (task != null)
            {
                var nextScreen = await task;
                
                // Clear the screen to make sure the previous screen isn't visible
                MeadowGumComponent.DefaultRenderer?.Show();
                
                task = nextScreen?.RunAsync(token);
            }
        }, _cancellationTokenSource.Token);

        return _currentTask;
    }
}