using System.Threading;
using System.Threading.Tasks;
using MeadowGum.Core;

namespace MeadowGum.ScratchPad.Common.Screens;

partial class NameEntryRuntime : MeadowGumScreen
{
    partial void CustomInitialize()
    {
        
    }

    public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
    {
        Render();

        while (true)
        {
            await Task.Delay(1000, cancellationToken);
        }
    }
}