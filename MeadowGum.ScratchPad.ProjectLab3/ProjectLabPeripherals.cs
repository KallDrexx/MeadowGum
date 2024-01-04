using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Meadow;
using Meadow.Devices;
using Meadow.Units;
using MeadowGum.ScratchPad.Common;

namespace MeadowGum.ScratchPad.ProjectLab3;

public class ProjectLabPeripherals : IPeripherals
{
    private readonly IProjectLabHardware _projectLab;
    private bool _hasBeenUpdated;
    
    public ProjectLabPeripherals(IProjectLabHardware projectLab, TimeSpan pollInterval)
    {
        _projectLab = projectLab;

        _projectLab.EnvironmentalSensor!.Updated += OnEnvironmentalSensorUpdated;
        _projectLab.MotionSensor!.Updated += OnMotionSensorUpdated;
        _projectLab.LightSensor!.Updated += OnLightSensorUpdated;
        
        _projectLab.EnvironmentalSensor.StartUpdating(pollInterval);
        _projectLab.MotionSensor.StartUpdating(pollInterval);
        _projectLab.LightSensor.StartUpdating(pollInterval);
    }

    public Temperature Temperature { get; set; }
    public Vector3 Acceleration { get; set; }
    public Vector3 AngularVelocity { get; set; }
    public RelativeHumidity Humidity { get; set; }
    public Pressure Pressure { get; set; }
    public Illuminance Illuminance { get; set; }
    
    public async Task WaitForNextUpdateAsync(CancellationToken cancellationToken)
    {
        var startedAt = DateTime.Now;
        while (!_hasBeenUpdated && (DateTime.Now - startedAt) < TimeSpan.FromSeconds(1))
        {
            await Task.Delay(10, cancellationToken);
        }

        _hasBeenUpdated = false;
    }

    private void OnLightSensorUpdated(object sender, IChangeResult<Illuminance> e)
    {
        Illuminance = e.New;
        _hasBeenUpdated = true;
    }

    private void OnMotionSensorUpdated(object sender, IChangeResult<(Acceleration3D? Acceleration3D, AngularVelocity3D? AngularVelocity3D, Temperature? Temperature)> e)
    {
        Acceleration = new Vector3(
            (float)e.New.Acceleration3D!.Value.X.Gravity,
            (float)e.New.Acceleration3D!.Value.Y.Gravity,
            (float)e.New.Acceleration3D!.Value.Z.Gravity);

        AngularVelocity = new Vector3(
            (float)e.New.AngularVelocity3D!.Value.X.DegreesPerSecond,
            (float)e.New.AngularVelocity3D!.Value.Y.DegreesPerSecond,
            (float)e.New.AngularVelocity3D!.Value.Z.DegreesPerSecond);
        
        Temperature = e.New.Temperature!.Value;
        _hasBeenUpdated = true;
    }

    private void OnEnvironmentalSensorUpdated(object sender, IChangeResult<(Temperature? Temperature, RelativeHumidity? Humidity, Pressure? Pressure, Resistance? GasResistance)> e)
    {
        Temperature = e.New.Temperature!.Value;
        Humidity = e.New.Humidity!.Value;
        Pressure = e.New.Pressure!.Value;
        _hasBeenUpdated = true;
    }
}