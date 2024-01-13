using System.Threading;
using System.Threading.Tasks;
using MeadowGum.Core;


namespace MeadowGum.ScratchPad.Common.Screens
{
    partial class SensorsRuntime : MeadowGumScreen
    {
        partial void CustomInitialize()
        {
            PeripheralManager.Peripherals.StartUpdating();
        }

        public override async Task<MeadowGumScreen?> RunAsync(CancellationToken cancellationToken)
        {
            InputManager.ButtonEvent? buttonEvent;
            while (true)
            {
                while ((buttonEvent = InputManager.Instance.NextButtonEvent()) != null)
                {
                    if (buttonEvent.Name == ButtonNames.Left && buttonEvent.State == InputManager.ButtonState.Clicked)
                    {
                        PeripheralManager.Peripherals.StopUpdating();
                        return new MainMenuRuntime();
                    }
                }
                
                UpdateSensorData();
                Render();
                await PeripheralManager.Peripherals.WaitForNextUpdateAsync(cancellationToken);
            }
        }

        private void UpdateSensorData()
        {
            TempValue.Text = $"{PeripheralManager.Peripherals.Temperature.Fahrenheit:0.0}°F";
            LuxValue.Text = $"{PeripheralManager.Peripherals.Illuminance.Lux:0.0} lux";
            PressureValue.Text = $"{PeripheralManager.Peripherals.Pressure.Millibar:0.0} mbar";
            HumidityValue.Text = $"{PeripheralManager.Peripherals.Humidity.Percent:0.0}%";
            AccelerationValue.Text = $"{PeripheralManager.Peripherals.Acceleration.X:0.0}g, " +
                                     $"{PeripheralManager.Peripherals.Acceleration.Y:0.0}g, " +
                                     $"{PeripheralManager.Peripherals.Acceleration.Z:0.0}g";
            AngularVelocityValue.Text = $"{PeripheralManager.Peripherals.AngularVelocity.X:0.0}, " +
                                     $"{PeripheralManager.Peripherals.AngularVelocity.Y:0.0}, " +
                                     $"{PeripheralManager.Peripherals.AngularVelocity.Z:0.0}";
        }
    }
}
