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
    private readonly TimeSpan _pollInterval;
    private bool _hasBeenUpdated, _isPolling;
    
    public ProjectLabPeripherals(IProjectLabHardware projectLab, TimeSpan pollInterval)
    {
        _projectLab = projectLab;
        _pollInterval = pollInterval;

        _projectLab.Gyroscope!.Updated += OnGyroscopeUpdated;
        _projectLab.Accelerometer!.Updated += OnAccelerometerUpdated;
        _projectLab.LightSensor!.Updated += OnLightSensorUpdated;
        _projectLab.TemperatureSensor!.Updated += OnTemperatureUpdated;
        _projectLab.HumiditySensor!.Updated += OnHumidityUpdated;
        _projectLab.BarometricPressureSensor!.Updated += OnPressureUdpated;
    }

    public Temperature Temperature { get; set; }
    public Vector3 Acceleration { get; set; }
    public Vector3 AngularVelocity { get; set; }
    public RelativeHumidity Humidity { get; set; }
    public Pressure Pressure { get; set; }
    public Illuminance Illuminance { get; set; }
    
    public async Task WaitForNextUpdateAsync(CancellationToken cancellationToken)
    {
        StartUpdating();
        
        var startedAt = DateTime.Now;
        while (!_hasBeenUpdated && (DateTime.Now - startedAt) < TimeSpan.FromSeconds(1))
        {
            await Task.Delay(10, cancellationToken);
        }

        _hasBeenUpdated = false;
    }

    public void StartUpdating()
    {
        if (!_isPolling)
        {
            _projectLab.LightSensor?.StartUpdating(_pollInterval);
            _projectLab.Accelerometer?.StartUpdating(_pollInterval);
            _projectLab.TemperatureSensor?.StartUpdating(_pollInterval);
            _projectLab.Gyroscope?.StartUpdating(_pollInterval);
            _projectLab.HumiditySensor?.StartUpdating(_pollInterval);

            _isPolling = true;
        }
    }

    public void StopUpdating()
    {
        if (_isPolling)
        {
            _projectLab.LightSensor?.StartUpdating();
            _projectLab.Accelerometer?.StopUpdating();
            _projectLab.TemperatureSensor?.StopUpdating();
            _projectLab.Gyroscope?.StopUpdating();
            _projectLab.HumiditySensor?.StopUpdating();

            _isPolling = false;
        }
    }

    private void OnLightSensorUpdated(object sender, IChangeResult<Illuminance> e)
    {
        Illuminance = e.New;
        _hasBeenUpdated = true;
    }

    private void OnAccelerometerUpdated(object sender, IChangeResult<Acceleration3D> e)
    {
        Acceleration = new Vector3(
            (float)e.New.X.Gravity,
            (float)e.New.Y.Gravity,
            (float)e.New.Z.Gravity);
        
        _hasBeenUpdated = true;
    }

    private void OnEnvironmentalSensorUpdated(object sender, IChangeResult<(Temperature? Temperature, RelativeHumidity? Humidity, Pressure? Pressure, Resistance? GasResistance)> e)
    {
        Temperature = e.New.Temperature!.Value;
        Humidity = e.New.Humidity!.Value;
        Pressure = e.New.Pressure!.Value;
        _hasBeenUpdated = true;
    }

    private void OnGyroscopeUpdated(object sender, IChangeResult<AngularVelocity3D> e)
    {
        AngularVelocity = new Vector3(
            (float)e.New.X.DegreesPerSecond,
            (float)e.New.Y.DegreesPerSecond,
            (float)e.New.Z.DegreesPerSecond);

        _hasBeenUpdated = true;
    }

    private void OnTemperatureUpdated(object sender, IChangeResult<Temperature> e)
    {
        Temperature = e.New;
        _hasBeenUpdated = true;
    }

    private void OnHumidityUpdated(object sender, IChangeResult<RelativeHumidity> e)
    {
        Humidity = e.New;
        _hasBeenUpdated = true;
    }

    private void OnPressureUdpated(object sender, IChangeResult<Pressure> e)
    {
        Pressure = e.New;
        _hasBeenUpdated = true;
    }
}