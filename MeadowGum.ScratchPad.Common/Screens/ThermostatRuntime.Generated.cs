//Code for Thermostat
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
    public partial class ThermostatRuntime
    {
        public enum Activity
        {
            Idle,
            Heating,
            Cooling,
        }

        Activity mActivityState;
        public Activity ActivityState
        {
            get => mActivityState;
            set
            {
                mActivityState = value;
                var appliedDynamically = false;
                if(!appliedDynamically)
                {
                    switch (value)
                    {
                        case Activity.Idle:
                            this.StatusBackground.Blue = 56;
                            this.StatusBackground.Green = 59;
                            this.StatusBackground.Red = 60;
                            this.StatusValue.Text = "IDLE";
                            break;
                        case Activity.Heating:
                            this.StatusBackground.Blue = 49;
                            this.StatusBackground.Green = 61;
                            this.StatusBackground.Red = 228;
                            this.StatusValue.Text = "HEAT";
                            break;
                        case Activity.Cooling:
                            this.StatusBackground.Blue = 150;
                            this.StatusBackground.Green = 116;
                            this.StatusBackground.Red = 81;
                            this.StatusValue.Text = "COOL";
                            break;
                    }
                }
            }
        }
        public BackgroundRuntime BackgroundInstance { get; protected set; }
        public ScreenLabelRuntime ScreenLabelInstance { get; protected set; }
        public PanelRuntime PanelInstance { get; protected set; }
        public ContainerRuntime TopLeftContainer { get; protected set; }
        public VerticalProgressBarRuntime TargetTempProgressBar { get; protected set; }
        public VerticalProgressBarRuntime EcoProgressBar { get; protected set; }
        public VerticalProgressBarRuntime EnergyProgressBar { get; protected set; }
        public ContainerRuntime TargetTempContainer { get; protected set; }
        public ContainerRuntime EcoContainer { get; protected set; }
        public ContainerRuntime EnergyContainer { get; protected set; }
        public SpriteRuntime TargetTempIcon { get; protected set; }
        public SpriteRuntime EcoIcon { get; protected set; }
        public SpriteRuntime EcoIcon1 { get; protected set; }
        public ContainerRuntime TopRightContainer { get; protected set; }
        public SliderRuntime TargetTempSlider { get; protected set; }
        public ToggleButtonRuntime EcoModeToggle { get; protected set; }
        public ToggleButtonRuntime FahrenheitToggle { get; protected set; }
        public ContainerRuntime TopMiddleContainer { get; protected set; }
        public ColoredRectangleRuntime StatusBackground { get; protected set; }
        public ContainerRuntime StatusDisplay { get; protected set; }
        public TextRuntime StatusLabel { get; protected set; }
        public TextRuntime StatusValue { get; protected set; }
        public TextRuntime TargetValue { get; protected set; }
        public ContainerRuntime BottomLeftContainer { get; protected set; }
        public ContainerRuntime ActualDisplayContainer { get; protected set; }
        public ContainerRuntime TargetDisplayContainer { get; protected set; }
        public ColoredRectangleRuntime TargetTextBackground { get; protected set; }
        public ColoredRectangleRuntime ActualTextBackground { get; protected set; }
        public TextRuntime TargetLabel { get; protected set; }
        public TextRuntime ActualLabel { get; protected set; }
        public TextRuntime ActualTempDisplayValue { get; protected set; }
        public SpriteButtonRuntime ResetButton { get; protected set; }
        public ContainerRuntime BottomRightContainer { get; protected set; }
        public SpriteButtonRuntime ExitButton { get; protected set; }
        public HoverRuntime HoverInstance { get; protected set; }

        public ThermostatRuntime(bool fullInstantiation = true)
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
            TopLeftContainer = new ContainerRuntime();
            TopLeftContainer.Name = "TopLeftContainer";
            TargetTempProgressBar = new VerticalProgressBarRuntime();
            TargetTempProgressBar.Name = "TargetTempProgressBar";
            EcoProgressBar = new VerticalProgressBarRuntime();
            EcoProgressBar.Name = "EcoProgressBar";
            EnergyProgressBar = new VerticalProgressBarRuntime();
            EnergyProgressBar.Name = "EnergyProgressBar";
            TargetTempContainer = new ContainerRuntime();
            TargetTempContainer.Name = "TargetTempContainer";
            EcoContainer = new ContainerRuntime();
            EcoContainer.Name = "EcoContainer";
            EnergyContainer = new ContainerRuntime();
            EnergyContainer.Name = "EnergyContainer";
            TargetTempIcon = new SpriteRuntime();
            TargetTempIcon.Name = "TargetTempIcon";
            EcoIcon = new SpriteRuntime();
            EcoIcon.Name = "EcoIcon";
            EcoIcon1 = new SpriteRuntime();
            EcoIcon1.Name = "EcoIcon1";
            TopRightContainer = new ContainerRuntime();
            TopRightContainer.Name = "TopRightContainer";
            TargetTempSlider = new SliderRuntime();
            TargetTempSlider.Name = "TargetTempSlider";
            EcoModeToggle = new ToggleButtonRuntime();
            EcoModeToggle.Name = "EcoModeToggle";
            FahrenheitToggle = new ToggleButtonRuntime();
            FahrenheitToggle.Name = "FahrenheitToggle";
            TopMiddleContainer = new ContainerRuntime();
            TopMiddleContainer.Name = "TopMiddleContainer";
            StatusBackground = new ColoredRectangleRuntime();
            StatusBackground.Name = "StatusBackground";
            StatusDisplay = new ContainerRuntime();
            StatusDisplay.Name = "StatusDisplay";
            StatusLabel = new TextRuntime();
            StatusLabel.Name = "StatusLabel";
            StatusValue = new TextRuntime();
            StatusValue.Name = "StatusValue";
            TargetValue = new TextRuntime();
            TargetValue.Name = "TargetValue";
            BottomLeftContainer = new ContainerRuntime();
            BottomLeftContainer.Name = "BottomLeftContainer";
            ActualDisplayContainer = new ContainerRuntime();
            ActualDisplayContainer.Name = "ActualDisplayContainer";
            TargetDisplayContainer = new ContainerRuntime();
            TargetDisplayContainer.Name = "TargetDisplayContainer";
            TargetTextBackground = new ColoredRectangleRuntime();
            TargetTextBackground.Name = "TargetTextBackground";
            ActualTextBackground = new ColoredRectangleRuntime();
            ActualTextBackground.Name = "ActualTextBackground";
            TargetLabel = new TextRuntime();
            TargetLabel.Name = "TargetLabel";
            ActualLabel = new TextRuntime();
            ActualLabel.Name = "ActualLabel";
            ActualTempDisplayValue = new TextRuntime();
            ActualTempDisplayValue.Name = "ActualTempDisplayValue";
            ResetButton = new SpriteButtonRuntime();
            ResetButton.Name = "ResetButton";
            BottomRightContainer = new ContainerRuntime();
            BottomRightContainer.Name = "BottomRightContainer";
            ExitButton = new SpriteButtonRuntime();
            ExitButton.Name = "ExitButton";
            HoverInstance = new HoverRuntime();
            HoverInstance.Name = "HoverInstance";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(BackgroundInstance);
            this.Children.Add(ScreenLabelInstance);
            this.Children.Add(PanelInstance);
            PanelInstance.Children.Add(TopLeftContainer);
            TargetTempContainer.Children.Add(TargetTempProgressBar);
            EcoContainer.Children.Add(EcoProgressBar);
            EnergyContainer.Children.Add(EnergyProgressBar);
            TopLeftContainer.Children.Add(TargetTempContainer);
            TopLeftContainer.Children.Add(EcoContainer);
            TopLeftContainer.Children.Add(EnergyContainer);
            TargetTempContainer.Children.Add(TargetTempIcon);
            EcoContainer.Children.Add(EcoIcon);
            EnergyContainer.Children.Add(EcoIcon1);
            PanelInstance.Children.Add(TopRightContainer);
            TopRightContainer.Children.Add(TargetTempSlider);
            TopRightContainer.Children.Add(EcoModeToggle);
            TopRightContainer.Children.Add(FahrenheitToggle);
            PanelInstance.Children.Add(TopMiddleContainer);
            StatusDisplay.Children.Add(StatusBackground);
            TopMiddleContainer.Children.Add(StatusDisplay);
            StatusDisplay.Children.Add(StatusLabel);
            StatusDisplay.Children.Add(StatusValue);
            TargetTextBackground.Children.Add(TargetValue);
            PanelInstance.Children.Add(BottomLeftContainer);
            BottomLeftContainer.Children.Add(ActualDisplayContainer);
            BottomLeftContainer.Children.Add(TargetDisplayContainer);
            TargetDisplayContainer.Children.Add(TargetTextBackground);
            ActualDisplayContainer.Children.Add(ActualTextBackground);
            TargetTextBackground.Children.Add(TargetLabel);
            ActualTextBackground.Children.Add(ActualLabel);
            ActualTextBackground.Children.Add(ActualTempDisplayValue);
            BottomRightContainer.Children.Add(ResetButton);
            PanelInstance.Children.Add(BottomRightContainer);
            BottomRightContainer.Children.Add(ExitButton);
            this.Children.Add(HoverInstance);
        }
        private void ApplyDefaultVariables()
        {

            this.ScreenLabelInstance.Text = "MEADOWSTAT";

            this.PanelInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.Regular;
            this.PanelInstance.Height = 185f;
            this.PanelInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.PanelInstance.Width = 95f;
            this.PanelInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.PanelInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.PanelInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.PanelInstance.Y = 15f;
            this.PanelInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.PanelInstance.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.TopLeftContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.TopLeftContainer.Height = 0f;
            this.TopLeftContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TopLeftContainer.StackSpacing = 8f;
            this.TopLeftContainer.Width = 0f;
            this.TopLeftContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TopLeftContainer.X = 8f;
            this.TopLeftContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.TopLeftContainer.XUnits = GeneralUnitType.PixelsFromSmall;
            this.TopLeftContainer.Y = 5f;
            this.TopLeftContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopLeftContainer.YUnits = GeneralUnitType.PixelsFromSmall;

this.TargetTempProgressBar.ColorState = VerticalProgressBarRuntime.Color.Red;

this.EcoProgressBar.ColorState = VerticalProgressBarRuntime.Color.Red;

this.EnergyProgressBar.ColorState = VerticalProgressBarRuntime.Color.Red;

            this.TargetTempContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.TargetTempContainer.Height = 0f;
            this.TargetTempContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TargetTempContainer.StackSpacing = 2f;
            this.TargetTempContainer.Width = 0f;
            this.TargetTempContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.EcoContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.EcoContainer.Height = 0f;
            this.EcoContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.EcoContainer.StackSpacing = 2f;
            this.EcoContainer.Width = 0f;
            this.EcoContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.EnergyContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.EnergyContainer.Height = 0f;
            this.EnergyContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.EnergyContainer.StackSpacing = 2f;
            this.EnergyContainer.Width = 0f;
            this.EnergyContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.TargetTempIcon.SourceFile = "retro-70s-UI.bmp";
            this.TargetTempIcon.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.TargetTempIcon.TextureHeight = 14;
            this.TargetTempIcon.TextureLeft = 129;
            this.TargetTempIcon.TextureTop = 49;
            this.TargetTempIcon.TextureWidth = 14;

            this.EcoIcon.SourceFile = "retro-70s-UI.bmp";
            this.EcoIcon.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.EcoIcon.TextureHeight = 14;
            this.EcoIcon.TextureLeft = 209;
            this.EcoIcon.TextureTop = 81;
            this.EcoIcon.TextureWidth = 14;

            this.EcoIcon1.SourceFile = "retro-70s-UI.bmp";
            this.EcoIcon1.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.EcoIcon1.TextureHeight = 14;
            this.EcoIcon1.TextureLeft = 193;
            this.EcoIcon1.TextureTop = 33;
            this.EcoIcon1.TextureWidth = 14;

            this.TopRightContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.TopRightContainer.Height = 0f;
            this.TopRightContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TopRightContainer.StackSpacing = 5f;
            this.TopRightContainer.Width = 0f;
            this.TopRightContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TopRightContainer.X = -5f;
            this.TopRightContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TopRightContainer.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TopRightContainer.Y = 5f;
            this.TopRightContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopRightContainer.YUnits = GeneralUnitType.PixelsFromSmall;

            this.TargetTempSlider.SliderLabelText = "TARGET TEMP";

            this.EcoModeToggle.LabelText = "ECO MODE";

            this.FahrenheitToggle.LabelText = "CELCIUS";

            this.TopMiddleContainer.Height = 0f;
            this.TopMiddleContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TopMiddleContainer.Width = 0f;
            this.TopMiddleContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TopMiddleContainer.X = -15f;
            this.TopMiddleContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TopMiddleContainer.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.StatusBackground.Blue = 56;
            this.StatusBackground.Green = 59;
            this.StatusBackground.Height = 84f;
            this.StatusBackground.Red = 60;
            this.StatusBackground.Width = 96f;

            this.StatusDisplay.Height = 0f;
            this.StatusDisplay.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.StatusDisplay.Width = 0f;
            this.StatusDisplay.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.StatusDisplay.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.StatusDisplay.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.StatusDisplay.Y = 15f;

            this.StatusLabel.Blue = 194;
            this.StatusLabel.Green = 229;
            this.StatusLabel.Height = 0f;
            this.StatusLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.StatusLabel.Red = 238;
            this.StatusLabel.Text = "STATUS";
            this.StatusLabel.Width = 0f;
            this.StatusLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.StatusLabel.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.StatusLabel.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.StatusLabel.Y = 5f;
            this.StatusLabel.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.StatusLabel.YUnits = GeneralUnitType.PixelsFromSmall;

            this.StatusValue.Blue = 194;
            this.StatusValue.Green = 229;
            this.StatusValue.Height = 0f;
            this.StatusValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.StatusValue.Red = 238;
            this.StatusValue.Text = "IDLE";
            this.StatusValue.Width = 0f;
            this.StatusValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.StatusValue.X = -5f;
            this.StatusValue.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.StatusValue.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.StatusValue.Y = 5f;
            this.StatusValue.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.StatusValue.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.TargetValue.Blue = 194;
            this.TargetValue.Green = 229;
            this.TargetValue.Height = 0f;
            this.TargetValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TargetValue.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TargetValue.Red = 238;
            this.TargetValue.Text = "75F";
            this.TargetValue.Width = 0f;
            this.TargetValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TargetValue.X = -5f;
            this.TargetValue.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TargetValue.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TargetValue.Y = 4f;

            this.BottomLeftContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.BottomLeftContainer.Height = 0f;
            this.BottomLeftContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BottomLeftContainer.StackSpacing = 7f;
            this.BottomLeftContainer.Width = 0f;
            this.BottomLeftContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BottomLeftContainer.X = 5f;
            this.BottomLeftContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.BottomLeftContainer.XUnits = GeneralUnitType.PixelsFromSmall;
            this.BottomLeftContainer.Y = -7f;
            this.BottomLeftContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomLeftContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.ActualDisplayContainer.Height = 0f;
            this.ActualDisplayContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ActualDisplayContainer.Width = 0f;
            this.ActualDisplayContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.TargetDisplayContainer.Height = 0f;
            this.TargetDisplayContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TargetDisplayContainer.Width = 0f;
            this.TargetDisplayContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.TargetTextBackground.Blue = 56;
            this.TargetTextBackground.Green = 59;
            this.TargetTextBackground.Height = 16f;
            this.TargetTextBackground.Red = 60;
            this.TargetTextBackground.Width = 166f;

            this.ActualTextBackground.Blue = 56;
            this.ActualTextBackground.Green = 59;
            this.ActualTextBackground.Height = 16f;
            this.ActualTextBackground.Red = 60;
            this.ActualTextBackground.Width = 166f;

            this.TargetLabel.Blue = 194;
            this.TargetLabel.Green = 229;
            this.TargetLabel.Height = 0f;
            this.TargetLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TargetLabel.Red = 238;
            this.TargetLabel.Text = "TARGET";
            this.TargetLabel.Width = 0f;
            this.TargetLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TargetLabel.X = 5f;
            this.TargetLabel.Y = 4f;

            this.ActualLabel.Blue = 194;
            this.ActualLabel.Green = 229;
            this.ActualLabel.Height = 0f;
            this.ActualLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ActualLabel.Red = 238;
            this.ActualLabel.Text = "ACTUAL";
            this.ActualLabel.Width = 0f;
            this.ActualLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ActualLabel.X = 5f;
            this.ActualLabel.Y = 4f;

            this.ActualTempDisplayValue.Blue = 194;
            this.ActualTempDisplayValue.Green = 229;
            this.ActualTempDisplayValue.Height = 0f;
            this.ActualTempDisplayValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ActualTempDisplayValue.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ActualTempDisplayValue.Red = 238;
            this.ActualTempDisplayValue.Text = "65F";
            this.ActualTempDisplayValue.Width = 0f;
            this.ActualTempDisplayValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ActualTempDisplayValue.X = -5f;
            this.ActualTempDisplayValue.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ActualTempDisplayValue.XUnits = GeneralUnitType.PixelsFromLarge;
            this.ActualTempDisplayValue.Y = 4f;

            this.ResetButton.ButtonText = "RESET";
            this.ResetButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ResetButton.XUnits = GeneralUnitType.PixelsFromLarge;

            this.BottomRightContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.BottomRightContainer.Height = 0f;
            this.BottomRightContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BottomRightContainer.StackSpacing = 5f;
            this.BottomRightContainer.Width = 0f;
            this.BottomRightContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BottomRightContainer.X = -5f;
            this.BottomRightContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.BottomRightContainer.XUnits = GeneralUnitType.PixelsFromLarge;
            this.BottomRightContainer.Y = -7f;
            this.BottomRightContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomRightContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.ExitButton.ButtonText = "EXIT";
            this.ExitButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ExitButton.XUnits = GeneralUnitType.PixelsFromLarge;

            this.HoverInstance.Visible = false;

        }
        partial void CustomInitialize();
    }
}
