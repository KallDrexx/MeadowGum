using System.Numerics;
using Meadow.Units;
using MeadowGum.ScratchPad.Common;

namespace MeadowGum.ScratchPad.Monogame;

public class MgPeripherals : IPeripherals
{
    private readonly Random _random = new();
    
    public MgPeripherals()
    {
        RandomizeData();
    }

    public Temperature Temperature { get; private set; }
    public Vector3 Acceleration { get; private set; }
    public Vector3 AngularVelocity { get; private set; }
    public RelativeHumidity Humidity { get; private set; }
    public Pressure Pressure { get; private set; }
    public Illuminance Illuminance { get; private set; }

    public async Task WaitForNextUpdateAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        RandomizeData();
    }

    private void RandomizeData()
    {
        Temperature = new Temperature(_random.NextInt64(0, 100), Temperature.UnitType.Fahrenheit);
        Humidity = new RelativeHumidity(_random.NextInt64(0, 100));
        Pressure = new Pressure(_random.NextInt64(0, 100));
        Illuminance = new Illuminance(_random.NextInt64(0, 100));
        Acceleration = new Vector3(
            _random.NextInt64(0, 100), 
            _random.NextInt64(0, 100), 
            _random.NextInt64(0, 100));
        
        AngularVelocity = new Vector3(
            _random.NextInt64(0, 100), 
            _random.NextInt64(0, 100),
            _random.NextInt64(0, 100));
    }
}