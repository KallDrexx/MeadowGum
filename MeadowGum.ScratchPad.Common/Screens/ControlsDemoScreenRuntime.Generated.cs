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
        public ContainerRuntime ProgressBars { get; protected set; }
        public SpriteRuntime BatteryIcon { get; protected set; }
        public SpriteRuntime HomeIcon { get; protected set; }
        public VerticalProgressBarRuntime BatteryProgressBar { get; protected set; }
        public VerticalProgressBarRuntime HomeProgressBar { get; protected set; }
        public ContainerRuntime HomeContainer { get; protected set; }
        public ContainerRuntime BatteryContainer { get; protected set; }

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
            ProgressBars = new ContainerRuntime();
            ProgressBars.Name = "ProgressBars";
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
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(BackgroundInstance);
            this.Children.Add(ScreenLabelInstance);
            this.Children.Add(PanelInstance);
            PanelInstance.Children.Add(ProgressBars);
            BatteryContainer.Children.Add(BatteryIcon);
            HomeContainer.Children.Add(HomeIcon);
            BatteryContainer.Children.Add(BatteryProgressBar);
            HomeContainer.Children.Add(HomeProgressBar);
            ProgressBars.Children.Add(HomeContainer);
            ProgressBars.Children.Add(BatteryContainer);
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

            this.ProgressBars.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.ProgressBars.Height = 0f;
            this.ProgressBars.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ProgressBars.StackSpacing = 7f;
            this.ProgressBars.Width = 0f;
            this.ProgressBars.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ProgressBars.X = -10f;
            this.ProgressBars.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ProgressBars.XUnits = GeneralUnitType.PixelsFromLarge;
            this.ProgressBars.Y = -16f;
            this.ProgressBars.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.ProgressBars.YUnits = GeneralUnitType.PixelsFromLarge;

            this.BatteryIcon.SourceFile = "retro-meadow-ui.bmp";
            this.BatteryIcon.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.BatteryIcon.TextureHeight = 13;
            this.BatteryIcon.TextureLeft = 76;
            this.BatteryIcon.TextureTop = 0;
            this.BatteryIcon.TextureWidth = 14;
            this.BatteryIcon.X = 1f;

            this.HomeIcon.SourceFile = "retro-meadow-ui.bmp";
            this.HomeIcon.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.HomeIcon.TextureHeight = 13;
            this.HomeIcon.TextureLeft = 44;
            this.HomeIcon.TextureTop = 0;
            this.HomeIcon.TextureWidth = 14;
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

        }
        partial void CustomInitialize();
    }
}
