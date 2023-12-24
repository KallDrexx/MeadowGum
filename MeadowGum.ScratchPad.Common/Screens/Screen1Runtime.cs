using System.Threading;
using System.Threading.Tasks;
using MeadowGum.Shared;

namespace MeadowGum.ScratchPad.Common.Screens;

public partial class Screen1Runtime : MeadowGumScreen
{
    public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
    {
        Render();

        while (true) await Task.Delay(1000, cancellationToken);
    }
}