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
        public SliderRuntime SliderInstance { get; protected set; }
        public ToggleButtonRuntime ToggleButtonInstance { get; protected set; }
        public ToggleButtonRuntime ToggleButtonInstance1 { get; protected set; }

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
            SliderInstance = new SliderRuntime();
            SliderInstance.Name = "SliderInstance";
            ToggleButtonInstance = new ToggleButtonRuntime();
            ToggleButtonInstance.Name = "ToggleButtonInstance";
            ToggleButtonInstance1 = new ToggleButtonRuntime();
            ToggleButtonInstance1.Name = "ToggleButtonInstance1";
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
            TopRightContainer.Children.Add(SliderInstance);
            TopRightContainer.Children.Add(ToggleButtonInstance);
            TopRightContainer.Children.Add(ToggleButtonInstance1);
        }
        private void ApplyDefaultVariables()
        {

            this.ScreenLabelInstance.Text = "MeadowStat";

            this.PanelInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.Regular;
            this.PanelInstance.Height = 170f;
            this.PanelInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.PanelInstance.Width = 95f;
            this.PanelInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.PanelInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.PanelInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.PanelInstance.Y = 10f;
            this.PanelInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.PanelInstance.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.TopLeftContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.TopLeftContainer.Height = 0f;
            this.TopLeftContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TopLeftContainer.StackSpacing = 5f;
            this.TopLeftContainer.Width = 0f;
            this.TopLeftContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TopLeftContainer.X = 5f;
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

            this.SliderInstance.SliderLabelText = "Target Temp";

            this.ToggleButtonInstance.LabelText = "Eco Mode";

            this.ToggleButtonInstance1.LabelText = "Celcius";

        }
        partial void CustomInitialize();
    }
}
