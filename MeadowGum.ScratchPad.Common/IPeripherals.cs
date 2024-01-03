using System.Threading.Tasks;
using Meadow.Units;

namespace MeadowGum.ScratchPad.Common;

public interface IPeripherals
{
    Temperature Temperature { get; }
    Acceleration3D Acceleration3D { get; }
    AngularVelocity3D AngularVelocity3D { get; }
    RelativeHumidity Humidity { get; }
    Pressure Pressure { get; }
    Illuminance Illuminance { get; }

    Task WaitForNextUpdateAsync();
}