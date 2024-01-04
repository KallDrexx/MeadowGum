//Code for EbikeUi
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
    public partial class EbikeUiRuntime
    {
        public BackgroundRuntime BackgroundInstance { get; protected set; }
        public ScreenLabelRuntime ScreenLabelInstance { get; protected set; }
        public PanelRuntime PanelInstance { get; protected set; }
        public ContainerRuntime ContainerInstance { get; protected set; }
        public ContainerRuntime BatteryInfoContainer { get; protected set; }
        public ContainerRuntime SpeedContainer { get; protected set; }
        public ContainerRuntime BatteryTextContainer { get; protected set; }
        public VerticalProgressBarRuntime BatteryProgressBar { get; protected set; }
        public ContainerRuntime SpeedTextContainer { get; protected set; }
        public VerticalProgressBarRuntime SpeedProgressBar { get; protected set; }
        public TextRuntime BatteryValue { get; protected set; }
        public TextRuntime SpeedValue { get; protected set; }
        public TextRuntime TextInstance { get; protected set; }
        public SpriteRuntime BatteryIcon { get; protected set; }
        public TextRuntime TextInstance1 { get; protected set; }
        public ContainerRuntime MiscInfoContainer { get; protected set; }
        public ContainerRuntime LeftInfoContainer { get; protected set; }
        public ContainerRuntime RightInfoContainer { get; protected set; }
        public LabelValueItemRuntime TripDisplay { get; protected set; }
        public LabelValueItemRuntime AverageSpeedDisplay { get; protected set; }
        public LabelValueItemRuntime OdometerDisplay { get; protected set; }
        public LabelValueItemRuntime RideTimeDisplay { get; protected set; }
        public LabelValueItemRuntime MaxSpeedDisplay { get; protected set; }
        public LabelValueItemRuntime EtaDisplay { get; protected set; }
        public ContainerRuntime StatusBarContainer { get; protected set; }
        public ContainerRuntime TemperatureContainer { get; protected set; }
        public ContainerRuntime TimeContainer { get; protected set; }
        public TextRuntime TemperatureValue { get; protected set; }
        public TextRuntime CurrentTimeValue { get; protected set; }
        public TextRuntime TemperatureUnits { get; protected set; }
        public TextRuntime CurrentTimeUnits { get; protected set; }
        public SpriteRuntime HomeIcon { get; protected set; }
        public SpriteRuntime HomeIcon1 { get; protected set; }
        public ContainerRuntime ButtonsContainer { get; protected set; }
        public HoverRuntime HoverInstance { get; protected set; }

        public EbikeUiRuntime(bool fullInstantiation = true)
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
            ContainerInstance = new ContainerRuntime();
            ContainerInstance.Name = "ContainerInstance";
            BatteryInfoContainer = new ContainerRuntime();
            BatteryInfoContainer.Name = "BatteryInfoContainer";
            SpeedContainer = new ContainerRuntime();
            SpeedContainer.Name = "SpeedContainer";
            BatteryTextContainer = new ContainerRuntime();
            BatteryTextContainer.Name = "BatteryTextContainer";
            BatteryProgressBar = new VerticalProgressBarRuntime();
            BatteryProgressBar.Name = "BatteryProgressBar";
            SpeedTextContainer = new ContainerRuntime();
            SpeedTextContainer.Name = "SpeedTextContainer";
            SpeedProgressBar = new VerticalProgressBarRuntime();
            SpeedProgressBar.Name = "SpeedProgressBar";
            BatteryValue = new TextRuntime();
            BatteryValue.Name = "BatteryValue";
            SpeedValue = new TextRuntime();
            SpeedValue.Name = "SpeedValue";
            TextInstance = new TextRuntime();
            TextInstance.Name = "TextInstance";
            BatteryIcon = new SpriteRuntime();
            BatteryIcon.Name = "BatteryIcon";
            TextInstance1 = new TextRuntime();
            TextInstance1.Name = "TextInstance1";
            MiscInfoContainer = new ContainerRuntime();
            MiscInfoContainer.Name = "MiscInfoContainer";
            LeftInfoContainer = new ContainerRuntime();
            LeftInfoContainer.Name = "LeftInfoContainer";
            RightInfoContainer = new ContainerRuntime();
            RightInfoContainer.Name = "RightInfoContainer";
            TripDisplay = new LabelValueItemRuntime();
            TripDisplay.Name = "TripDisplay";
            AverageSpeedDisplay = new LabelValueItemRuntime();
            AverageSpeedDisplay.Name = "AverageSpeedDisplay";
            OdometerDisplay = new LabelValueItemRuntime();
            OdometerDisplay.Name = "OdometerDisplay";
            RideTimeDisplay = new LabelValueItemRuntime();
            RideTimeDisplay.Name = "RideTimeDisplay";
            MaxSpeedDisplay = new LabelValueItemRuntime();
            MaxSpeedDisplay.Name = "MaxSpeedDisplay";
            EtaDisplay = new LabelValueItemRuntime();
            EtaDisplay.Name = "EtaDisplay";
            StatusBarContainer = new ContainerRuntime();
            StatusBarContainer.Name = "StatusBarContainer";
            TemperatureContainer = new ContainerRuntime();
            TemperatureContainer.Name = "TemperatureContainer";
            TimeContainer = new ContainerRuntime();
            TimeContainer.Name = "TimeContainer";
            TemperatureValue = new TextRuntime();
            TemperatureValue.Name = "TemperatureValue";
            CurrentTimeValue = new TextRuntime();
            CurrentTimeValue.Name = "CurrentTimeValue";
            TemperatureUnits = new TextRuntime();
            TemperatureUnits.Name = "TemperatureUnits";
            CurrentTimeUnits = new TextRuntime();
            CurrentTimeUnits.Name = "CurrentTimeUnits";
            HomeIcon = new SpriteRuntime();
            HomeIcon.Name = "HomeIcon";
            HomeIcon1 = new SpriteRuntime();
            HomeIcon1.Name = "HomeIcon1";
            ButtonsContainer = new ContainerRuntime();
            ButtonsContainer.Name = "ButtonsContainer";
            HoverInstance = new HoverRuntime();
            HoverInstance.Name = "HoverInstance";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(BackgroundInstance);
            this.Children.Add(ScreenLabelInstance);
            this.Children.Add(PanelInstance);
            PanelInstance.Children.Add(ContainerInstance);
            ContainerInstance.Children.Add(BatteryInfoContainer);
            ContainerInstance.Children.Add(SpeedContainer);
            BatteryInfoContainer.Children.Add(BatteryTextContainer);
            BatteryInfoContainer.Children.Add(BatteryProgressBar);
            SpeedContainer.Children.Add(SpeedTextContainer);
            SpeedContainer.Children.Add(SpeedProgressBar);
            BatteryTextContainer.Children.Add(BatteryValue);
            SpeedTextContainer.Children.Add(SpeedValue);
            BatteryTextContainer.Children.Add(TextInstance);
            BatteryInfoContainer.Children.Add(BatteryIcon);
            SpeedTextContainer.Children.Add(TextInstance1);
            ContainerInstance.Children.Add(MiscInfoContainer);
            MiscInfoContainer.Children.Add(LeftInfoContainer);
            MiscInfoContainer.Children.Add(RightInfoContainer);
            LeftInfoContainer.Children.Add(TripDisplay);
            LeftInfoContainer.Children.Add(AverageSpeedDisplay);
            RightInfoContainer.Children.Add(OdometerDisplay);
            LeftInfoContainer.Children.Add(RideTimeDisplay);
            RightInfoContainer.Children.Add(MaxSpeedDisplay);
            RightInfoContainer.Children.Add(EtaDisplay);
            PanelInstance.Children.Add(StatusBarContainer);
            StatusBarContainer.Children.Add(TemperatureContainer);
            StatusBarContainer.Children.Add(TimeContainer);
            TemperatureContainer.Children.Add(TemperatureValue);
            TimeContainer.Children.Add(CurrentTimeValue);
            TemperatureContainer.Children.Add(TemperatureUnits);
            TimeContainer.Children.Add(CurrentTimeUnits);
            ButtonsContainer.Children.Add(HomeIcon);
            ButtonsContainer.Children.Add(HomeIcon1);
            PanelInstance.Children.Add(ButtonsContainer);
            this.Children.Add(HoverInstance);
        }
        private void ApplyDefaultVariables()
        {

            this.ScreenLabelInstance.Text = "Ebike UI Demo";

            this.PanelInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.Regular;
            this.PanelInstance.Height = 170f;
            this.PanelInstance.Width = 95f;
            this.PanelInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.PanelInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.PanelInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.PanelInstance.Y = 20f;
            this.PanelInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.PanelInstance.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.ContainerInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.ContainerInstance.Height = 98f;
            this.ContainerInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.ContainerInstance.StackSpacing = 10f;
            this.ContainerInstance.Width = 100f;
            this.ContainerInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;

            this.BatteryInfoContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.BatteryInfoContainer.Height = 0f;
            this.BatteryInfoContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BatteryInfoContainer.StackSpacing = 5f;
            this.BatteryInfoContainer.Width = 0f;
            this.BatteryInfoContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BatteryInfoContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BatteryInfoContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.SpeedContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.SpeedContainer.Height = 18f;
            this.SpeedContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.SpeedContainer.StackSpacing = 5f;
            this.SpeedContainer.Width = 0f;
            this.SpeedContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.SpeedContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.SpeedContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.BatteryTextContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.BatteryTextContainer.Height = 0f;
            this.BatteryTextContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BatteryTextContainer.Width = 0f;
            this.BatteryTextContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BatteryTextContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.BatteryTextContainer.YUnits = GeneralUnitType.PixelsFromSmall;

            this.BatteryProgressBar.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.BatteryProgressBar.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.BatteryProgressBar.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.BatteryProgressBar.YUnits = GeneralUnitType.PixelsFromSmall;

            this.SpeedTextContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.SpeedTextContainer.Height = 0f;
            this.SpeedTextContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.SpeedTextContainer.Width = 0f;
            this.SpeedTextContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.SpeedTextContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.SpeedTextContainer.YUnits = GeneralUnitType.PixelsFromSmall;

            this.SpeedProgressBar.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.SpeedProgressBar.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.SpeedProgressBar.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.SpeedProgressBar.YUnits = GeneralUnitType.PixelsFromSmall;

            this.BatteryValue.Blue = 106;
            this.BatteryValue.Green = 116;
            this.BatteryValue.Height = 0f;
            this.BatteryValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BatteryValue.Red = 86;
            this.BatteryValue.Text = "000";
            this.BatteryValue.Width = 0f;
            this.BatteryValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BatteryValue.X = 5f;

            this.SpeedValue.Blue = 106;
            this.SpeedValue.Green = 116;
            this.SpeedValue.Height = 0f;
            this.SpeedValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.SpeedValue.Red = 86;
            this.SpeedValue.Text = "000";
            this.SpeedValue.Width = 3f;
            this.SpeedValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.SpeedValue.X = 5f;

            this.TextInstance.Blue = 106;
            this.TextInstance.Green = 116;
            this.TextInstance.Height = 0f;
            this.TextInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TextInstance.Red = 86;
            this.TextInstance.Text = "%";
            this.TextInstance.Width = 5f;
            this.TextInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.BatteryIcon.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.BatteryIcon.SourceFile = "retro-meadow-ui.bmp";
            this.BatteryIcon.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.BatteryIcon.TextureHeight = 13;
            this.BatteryIcon.TextureLeft = 76;
            this.BatteryIcon.TextureTop = 0;
            this.BatteryIcon.TextureWidth = 14;
            this.BatteryIcon.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.BatteryIcon.X = 0f;
            this.BatteryIcon.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.BatteryIcon.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.TextInstance1.Blue = 106;
            this.TextInstance1.Green = 116;
            this.TextInstance1.Height = 0f;
            this.TextInstance1.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TextInstance1.Red = 86;
            this.TextInstance1.Text = "mph";
            this.TextInstance1.Width = 5f;
            this.TextInstance1.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.MiscInfoContainer.AutoGridHorizontalCells = 2;
            this.MiscInfoContainer.AutoGridVerticalCells = 1;
            this.MiscInfoContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.MiscInfoContainer.Height = 100f;
            this.MiscInfoContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.MiscInfoContainer.StackSpacing = 10f;
            this.MiscInfoContainer.Width = 170f;
            this.MiscInfoContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.MiscInfoContainer.Y = -20f;
            this.MiscInfoContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.MiscInfoContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.LeftInfoContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.LeftInfoContainer.StackSpacing = 10f;
            this.LeftInfoContainer.Width = 0f;
            this.LeftInfoContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.RightInfoContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.RightInfoContainer.StackSpacing = 10f;
            this.RightInfoContainer.Width = 0f;
            this.RightInfoContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.TripDisplay.LabelText = "Trip";
            this.TripDisplay.ValueText = "0.00";

            this.AverageSpeedDisplay.LabelText = "Avg. Speed";
            this.AverageSpeedDisplay.ValueText = "0.0";

            this.OdometerDisplay.LabelText = "Odometer";
            this.OdometerDisplay.ValueText = "000.0";

            this.RideTimeDisplay.LabelText = "Time";
            this.RideTimeDisplay.ValueText = "00:00";

            this.MaxSpeedDisplay.LabelText = "Max Speed";
            this.MaxSpeedDisplay.ValueText = "0.0 mph";

            this.EtaDisplay.LabelText = "ETA";
            this.EtaDisplay.ValueText = "00:00";

            this.StatusBarContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.StatusBarContainer.Height = 0f;
            this.StatusBarContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.StatusBarContainer.StackSpacing = 10f;
            this.StatusBarContainer.Width = 0f;
            this.StatusBarContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.StatusBarContainer.X = -5f;
            this.StatusBarContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.StatusBarContainer.XUnits = GeneralUnitType.PixelsFromLarge;
            this.StatusBarContainer.Y = 5f;

            this.TemperatureContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.TemperatureContainer.Height = 0f;
            this.TemperatureContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TemperatureContainer.StackSpacing = 2f;
            this.TemperatureContainer.Width = 0f;
            this.TemperatureContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.TimeContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.TimeContainer.Height = 0f;
            this.TimeContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TimeContainer.StackSpacing = 2f;
            this.TimeContainer.Width = 0f;
            this.TimeContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.TemperatureValue.Blue = 106;
            this.TemperatureValue.Green = 116;
            this.TemperatureValue.Height = 0f;
            this.TemperatureValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TemperatureValue.Red = 86;
            this.TemperatureValue.Text = "75";
            this.TemperatureValue.Width = 0f;
            this.TemperatureValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.CurrentTimeValue.Blue = 106;
            this.CurrentTimeValue.Green = 116;
            this.CurrentTimeValue.Height = 0f;
            this.CurrentTimeValue.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.CurrentTimeValue.Red = 86;
            this.CurrentTimeValue.Text = "4:52";
            this.CurrentTimeValue.Width = 0f;
            this.CurrentTimeValue.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.TemperatureUnits.Blue = 171;
            this.TemperatureUnits.Green = 171;
            this.TemperatureUnits.Height = 0f;
            this.TemperatureUnits.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TemperatureUnits.Red = 171;
            this.TemperatureUnits.Text = "F";
            this.TemperatureUnits.Width = 0f;
            this.TemperatureUnits.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.CurrentTimeUnits.Blue = 171;
            this.CurrentTimeUnits.Green = 171;
            this.CurrentTimeUnits.Height = 0f;
            this.CurrentTimeUnits.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.CurrentTimeUnits.Red = 171;
            this.CurrentTimeUnits.Text = "pm";
            this.CurrentTimeUnits.Width = 0f;
            this.CurrentTimeUnits.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.HomeIcon.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.HomeIcon.SourceFile = "retro-meadow-ui.bmp";
            this.HomeIcon.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.HomeIcon.TextureHeight = 13;
            this.HomeIcon.TextureLeft = 44;
            this.HomeIcon.TextureTop = 0;
            this.HomeIcon.TextureWidth = 14;
            this.HomeIcon.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.HomeIcon.X = 1f;

            this.HomeIcon1.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.HomeIcon1.SourceFile = "retro-meadow-ui.bmp";
            this.HomeIcon1.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.HomeIcon1.TextureHeight = 13;
            this.HomeIcon1.TextureLeft = 60;
            this.HomeIcon1.TextureTop = 0;
            this.HomeIcon1.TextureWidth = 14;
            this.HomeIcon1.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.HomeIcon1.X = 1f;

            this.ButtonsContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.ButtonsContainer.StackSpacing = 5f;
            this.ButtonsContainer.X = 5f;
            this.ButtonsContainer.Y = 5f;

            this.HoverInstance.Visible = false;

        }
        partial void CustomInitialize();
    }
}
