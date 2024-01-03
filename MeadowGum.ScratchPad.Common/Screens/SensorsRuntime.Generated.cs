//Code for Sensors
using Gum.Converters;
using Gum.DataTypes;
using Gum.Managers;
using Gum.Wireframe;

using RenderingLibrary.Graphics;

using MeadowGum.Shared;
using MeadowGum.Shared.Components;
using MeadowGum.ScratchPad.Common.Components;


namespace MeadowGum.ScratchPad.Common.Screens
{
    public partial class SensorsRuntime
    {
        public BackgroundRuntime BackgroundInstance { get; protected set; }
        public ScreenLabelRuntime ScreenLabelInstance { get; protected set; }
        public PanelRuntime PanelInstance { get; protected set; }
        public ContainerRuntime TextContainer { get; protected set; }
        public TextRuntime TempLabel { get; protected set; }
        public TextRuntime TempValue { get; protected set; }
        public TextRuntime LuxLabel { get; protected set; }
        public TextRuntime LuxValue { get; protected set; }
        public TextRuntime PressureLabel { get; protected set; }
        public TextRuntime PressureValue { get; protected set; }
        public TextRuntime HumidityLabel { get; protected set; }
        public TextRuntime HumidityValue { get; protected set; }
        public TextRuntime AccelerationLabel { get; protected set; }
        public TextRuntime AccelerationValue { get; protected set; }
        public TextRuntime AnglularVelocityLabel { get; protected set; }
        public TextRuntime AngularVelocityValue { get; protected set; }

        public SensorsRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {

                 

                InitializeInstances();

                if(fullInstantiation)
                {
                    ApplyDefaultVariables();
                }
                AssignParents();
                CustomInitialize();
            }
        }
        protected virtual void InitializeInstances()
        {
            BackgroundInstance = new BackgroundRuntime();
            BackgroundInstance.Name = "BackgroundInstance";
            ScreenLabelInstance = new ScreenLabelRuntime();
            ScreenLabelInstance.Name = "ScreenLabelInstance";
            PanelInstance = new PanelRuntime();
            PanelInstance.Name = "PanelInstance";
            TextContainer = new ContainerRuntime();
            TextContainer.Name = "TextContainer";
            TempLabel = new TextRuntime();
            TempLabel.Name = "TempLabel";
            TempValue = new TextRuntime();
            TempValue.Name = "TempValue";
            LuxLabel = new TextRuntime();
            LuxLabel.Name = "LuxLabel";
            LuxValue = new TextRuntime();
            LuxValue.Name = "LuxValue";
            PressureLabel = new TextRuntime();
            PressureLabel.Name = "PressureLabel";
            PressureValue = new TextRuntime();
            PressureValue.Name = "PressureValue";
            HumidityLabel = new TextRuntime();
            HumidityLabel.Name = "HumidityLabel";
            HumidityValue = new TextRuntime();
            HumidityValue.Name = "HumidityValue";
            AccelerationLabel = new TextRuntime();
            AccelerationLabel.Name = "AccelerationLabel";
            AccelerationValue = new TextRuntime();
            AccelerationValue.Name = "AccelerationValue";
            AnglularVelocityLabel = new TextRuntime();
            AnglularVelocityLabel.Name = "AnglularVelocityLabel";
            AngularVelocityValue = new TextRuntime();
            AngularVelocityValue.Name = "AngularVelocityValue";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(BackgroundInstance);
            this.Children.Add(ScreenLabelInstance);
            this.Children.Add(PanelInstance);
            PanelInstance.Children.Add(TextContainer);
            TextContainer.Children.Add(TempLabel);
            TextContainer.Children.Add(TempValue);
            TextContainer.Children.Add(LuxLabel);
            TextContainer.Children.Add(LuxValue);
            TextContainer.Children.Add(PressureLabel);
            TextContainer.Children.Add(PressureValue);
            TextContainer.Children.Add(HumidityLabel);
            TextContainer.Children.Add(HumidityValue);
            TextContainer.Children.Add(AccelerationLabel);
            TextContainer.Children.Add(AccelerationValue);
            TextContainer.Children.Add(AnglularVelocityLabel);
            TextContainer.Children.Add(AngularVelocityValue);
        }
        private void ApplyDefaultVariables()
        {

            this.ScreenLabelInstance.Text = "Sensors Demo";

            this.PanelInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.Regular;
            this.PanelInstance.Height = 180f;
            this.PanelInstance.Width = 95f;
            this.PanelInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.PanelInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.PanelInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.PanelInstance.Y = 50f;

            this.TextContainer.AutoGridHorizontalCells = 2;
            this.TextContainer.AutoGridVerticalCells = 6;
            this.TextContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.AutoGridHorizontal;
            this.TextContainer.Height = 90f;
            this.TextContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.TextContainer.StackSpacing = 10f;
            this.TextContainer.Width = 90f;
            this.TextContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.TextContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TextContainer.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.TextContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.TextContainer.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.TempLabel.Blue = 106;
            this.TempLabel.Green = 116;
            this.TempLabel.Height = 0f;
            this.TempLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TempLabel.Red = 81;
            this.TempLabel.Text = "Temperature: ";
            this.TempLabel.Width = 0f;
            this.TempLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TempLabel.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TempLabel.XUnits = GeneralUnitType.PixelsFromLarge;

            this.TempValue.Blue = 0;
            this.TempValue.Green = 0;
            this.TempValue.Height = 0f;
            this.TempValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TempValue.Red = 255;
            this.TempValue.Width = 0f;
            this.TempValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.LuxLabel.Blue = 106;
            this.LuxLabel.Green = 116;
            this.LuxLabel.Height = 0f;
            this.LuxLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.LuxLabel.Red = 81;
            this.LuxLabel.Text = "Lux: ";
            this.LuxLabel.Width = 0f;
            this.LuxLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.LuxLabel.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.LuxLabel.XUnits = GeneralUnitType.PixelsFromLarge;

            this.LuxValue.Blue = 0;
            this.LuxValue.Green = 0;
            this.LuxValue.Height = 0f;
            this.LuxValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.LuxValue.Width = 0f;
            this.LuxValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.PressureLabel.Blue = 106;
            this.PressureLabel.Green = 116;
            this.PressureLabel.Height = 0f;
            this.PressureLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.PressureLabel.Red = 81;
            this.PressureLabel.Text = "Pressure: ";
            this.PressureLabel.Width = 0f;
            this.PressureLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.PressureLabel.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.PressureLabel.XUnits = GeneralUnitType.PixelsFromLarge;

            this.PressureValue.Blue = 0;
            this.PressureValue.Green = 0;
            this.PressureValue.Height = 0f;
            this.PressureValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.PressureValue.Width = 0f;
            this.PressureValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.HumidityLabel.Blue = 106;
            this.HumidityLabel.Green = 116;
            this.HumidityLabel.Height = 0f;
            this.HumidityLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.HumidityLabel.Red = 81;
            this.HumidityLabel.Text = "Humidity: ";
            this.HumidityLabel.Width = 0f;
            this.HumidityLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.HumidityLabel.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.HumidityLabel.XUnits = GeneralUnitType.PixelsFromLarge;

            this.HumidityValue.Blue = 0;
            this.HumidityValue.Green = 0;
            this.HumidityValue.Height = 0f;
            this.HumidityValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.HumidityValue.Width = 0f;
            this.HumidityValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.AccelerationLabel.Blue = 106;
            this.AccelerationLabel.Green = 116;
            this.AccelerationLabel.Height = 0f;
            this.AccelerationLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.AccelerationLabel.Red = 81;
            this.AccelerationLabel.Text = "Acceleration: ";
            this.AccelerationLabel.Width = 0f;
            this.AccelerationLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.AccelerationLabel.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.AccelerationLabel.XUnits = GeneralUnitType.PixelsFromLarge;

            this.AccelerationValue.Blue = 0;
            this.AccelerationValue.Green = 0;
            this.AccelerationValue.Height = 0f;
            this.AccelerationValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.AccelerationValue.Width = 0f;
            this.AccelerationValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.AnglularVelocityLabel.Blue = 106;
            this.AnglularVelocityLabel.Green = 116;
            this.AnglularVelocityLabel.Height = 0f;
            this.AnglularVelocityLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.AnglularVelocityLabel.Red = 81;
            this.AnglularVelocityLabel.Text = "Angular Velocity: ";
            this.AnglularVelocityLabel.Width = 0f;
            this.AnglularVelocityLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.AnglularVelocityLabel.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.AnglularVelocityLabel.XUnits = GeneralUnitType.PixelsFromLarge;

            this.AngularVelocityValue.Blue = 0;
            this.AngularVelocityValue.Green = 0;
            this.AngularVelocityValue.Height = 0f;
            this.AngularVelocityValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.AngularVelocityValue.Width = 0f;
            this.AngularVelocityValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

        }
        partial void CustomInitialize();
    }
}
