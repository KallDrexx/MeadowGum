//Code for ControlsDemoScreen
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
    public partial class ControlsDemoScreenRuntime
    {
        public enum Something
        {
            Foo,
        }

        Something mSomethingState;
        public Something SomethingState
        {
            get => mSomethingState;
            set
            {
                mSomethingState = value;
                var appliedDynamically = false;
                if(!appliedDynamically)
                {
                    switch (value)
                    {
                        case Something.Foo:
                            break;
                    }
                }
            }
        }
        public BackgroundRuntime BackgroundInstance { get; protected set; }
        public ScreenLabelRuntime ScreenLabelInstance { get; protected set; }
        public PanelRuntime PanelInstance { get; protected set; }
        public SpriteRuntime BatteryIcon { get; protected set; }
        public SpriteRuntime HomeIcon { get; protected set; }
        public VerticalProgressBarRuntime BatteryProgressBar { get; protected set; }
        public VerticalProgressBarRuntime HomeProgressBar { get; protected set; }
        public ContainerRuntime HomeContainer { get; protected set; }
        public ContainerRuntime BatteryContainer { get; protected set; }
        public ContainerRuntime OtherControls { get; protected set; }
        public ContainerRuntime Buttons { get; protected set; }
        public ContainerRuntime ProgressBars { get; protected set; }
        public ContainerRuntime Container { get; protected set; }
        public SpriteButtonRuntime HomeButton { get; protected set; }
        public SpriteButtonRuntime MainMenuButton { get; protected set; }
        public SliderRuntime HomeSlider { get; protected set; }
        public ToggleButtonRuntime BoostToggle { get; protected set; }
        public HoverRuntime HoverInstance { get; protected set; }

        public string LabelText
        {
            get => BoostToggle.LabelText;
            set => BoostToggle.LabelText = value;
        }

        public string SliderLabelText
        {
            get => HomeSlider.SliderLabelText;
            set => HomeSlider.SliderLabelText = value;
        }

        public ControlsDemoScreenRuntime(bool fullInstantiation = true)
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
            BatteryIcon = new SpriteRuntime();
            BatteryIcon.Name = "BatteryIcon";
            HomeIcon = new SpriteRuntime();
            HomeIcon.Name = "HomeIcon";
            BatteryProgressBar = new VerticalProgressBarRuntime();
            BatteryProgressBar.Name = "BatteryProgressBar";
            HomeProgressBar = new VerticalProgressBarRuntime();
            HomeProgressBar.Name = "HomeProgressBar";
            HomeContainer = new ContainerRuntime();
            HomeContainer.Name = "HomeContainer";
            BatteryContainer = new ContainerRuntime();
            BatteryContainer.Name = "BatteryContainer";
            OtherControls = new ContainerRuntime();
            OtherControls.Name = "OtherControls";
            Buttons = new ContainerRuntime();
            Buttons.Name = "Buttons";
            ProgressBars = new ContainerRuntime();
            ProgressBars.Name = "ProgressBars";
            Container = new ContainerRuntime();
            Container.Name = "Container";
            HomeButton = new SpriteButtonRuntime();
            HomeButton.Name = "HomeButton";
            MainMenuButton = new SpriteButtonRuntime();
            MainMenuButton.Name = "MainMenuButton";
            HomeSlider = new SliderRuntime();
            HomeSlider.Name = "HomeSlider";
            BoostToggle = new ToggleButtonRuntime();
            BoostToggle.Name = "BoostToggle";
            HoverInstance = new HoverRuntime();
            HoverInstance.Name = "HoverInstance";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(BackgroundInstance);
            this.Children.Add(ScreenLabelInstance);
            this.Children.Add(PanelInstance);
            BatteryContainer.Children.Add(BatteryIcon);
            HomeContainer.Children.Add(HomeIcon);
            BatteryContainer.Children.Add(BatteryProgressBar);
            HomeContainer.Children.Add(HomeProgressBar);
            ProgressBars.Children.Add(HomeContainer);
            ProgressBars.Children.Add(BatteryContainer);
            Container.Children.Add(OtherControls);
            Container.Children.Add(Buttons);
            Container.Children.Add(ProgressBars);
            PanelInstance.Children.Add(Container);
            Buttons.Children.Add(HomeButton);
            Buttons.Children.Add(MainMenuButton);
            OtherControls.Children.Add(HomeSlider);
            OtherControls.Children.Add(BoostToggle);
            this.Children.Add(HoverInstance);
        }
        private void ApplyDefaultVariables()
        {

            this.ScreenLabelInstance.Text = "Controls Demo";

            this.PanelInstance.Width = -20f;
            this.PanelInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.PanelInstance.X = 0f;
            this.PanelInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.PanelInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.PanelInstance.Y = 50f;

            this.BatteryIcon.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.BatteryIcon.SourceFile = "retro-meadow-ui.bmp";
            this.BatteryIcon.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.BatteryIcon.TextureHeight = 13;
            this.BatteryIcon.TextureLeft = 76;
            this.BatteryIcon.TextureTop = 0;
            this.BatteryIcon.TextureWidth = 14;
            this.BatteryIcon.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.BatteryIcon.X = 1f;

            this.HomeIcon.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.HomeIcon.SourceFile = "retro-meadow-ui.bmp";
            this.HomeIcon.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.HomeIcon.TextureHeight = 13;
            this.HomeIcon.TextureLeft = 44;
            this.HomeIcon.TextureTop = 0;
            this.HomeIcon.TextureWidth = 14;
            this.HomeIcon.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.HomeIcon.X = 1f;



            this.HomeContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.HomeContainer.Height = 0f;
            this.HomeContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.HomeContainer.StackSpacing = 0f;
            this.HomeContainer.Width = 0f;
            this.HomeContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.HomeContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.HomeContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.BatteryContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.BatteryContainer.Height = 0f;
            this.BatteryContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BatteryContainer.StackSpacing = 0f;
            this.BatteryContainer.Width = 0f;
            this.BatteryContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.BatteryContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BatteryContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.OtherControls.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.OtherControls.Height = 0f;
            this.OtherControls.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.OtherControls.StackSpacing = 5f;
            this.OtherControls.Visible = true;
            this.OtherControls.Width = 110f;
            this.OtherControls.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.OtherControls.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.OtherControls.YUnits = GeneralUnitType.PixelsFromLarge;

            this.Buttons.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.Buttons.Height = 0f;
            this.Buttons.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Buttons.StackSpacing = 5f;
            this.Buttons.Visible = true;
            this.Buttons.Width = 0f;
            this.Buttons.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Buttons.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Buttons.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Buttons.YUnits = GeneralUnitType.PixelsFromLarge;

            this.ProgressBars.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.ProgressBars.Height = 0f;
            this.ProgressBars.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ProgressBars.StackSpacing = 7f;
            this.ProgressBars.Width = 0f;
            this.ProgressBars.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ProgressBars.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.ProgressBars.YUnits = GeneralUnitType.PixelsFromLarge;

            this.Container.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.Container.Height = 90f;
            this.Container.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.Container.StackSpacing = 5f;
            this.Container.Width = 0f;
            this.Container.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Container.X = -15f;
            this.Container.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Container.XUnits = GeneralUnitType.PixelsFromLarge;

            this.HomeButton.ButtonText = "Home";
            this.HomeButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.HomeButton.XUnits = GeneralUnitType.PixelsFromLarge;

            this.MainMenuButton.ButtonText = "Main Menu";
            this.MainMenuButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.MainMenuButton.XUnits = GeneralUnitType.PixelsFromLarge;

            this.HomeSlider.SliderLabelText = "Home Amount";
            this.HomeSlider.Width = 100f;

            this.BoostToggle.LabelText = "Boost";

            this.HoverInstance.Visible = false;

        }
        partial void CustomInitialize();
    }
}
