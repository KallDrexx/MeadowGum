using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Meadow.Units;

namespace MeadowGum.ScratchPad.Common;

public interface IPeripherals
{
    Temperature Temperature { get; }
    Vector3 Acceleration { get; }
    Vector3 AngularVelocity { get; }
    RelativeHumidity Humidity { get; }
    Pressure Pressure { get; }
    Illuminance Illuminance { get; }

    Task WaitForNextUpdateAsync(CancellationToken cancellationToken);
}