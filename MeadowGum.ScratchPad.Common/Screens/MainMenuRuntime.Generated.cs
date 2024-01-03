//Code for MainMenu
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
    public partial class MainMenuRuntime
    {
        public SpriteButtonRuntime TestScreen1Button { get; protected set; }
        public BackgroundRuntime BackgroundInstance { get; protected set; }
        public ContainerRuntime ButtonContainer { get; protected set; }
        public SpriteButtonRuntime ControlsDemoScreenButton { get; protected set; }
        public SpriteButtonRuntime SensorsScreenButton { get; protected set; }
        public ScreenLabelRuntime ScreenLabelInstance { get; protected set; }

        public string ButtonText
        {
            get => ControlsDemoScreenButton.ButtonText;
            set => ControlsDemoScreenButton.ButtonText = value;
        }

        public MainMenuRuntime(bool fullInstantiation = true)
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
            TestScreen1Button = new SpriteButtonRuntime();
            TestScreen1Button.Name = "TestScreen1Button";
            BackgroundInstance = new BackgroundRuntime();
            BackgroundInstance.Name = "BackgroundInstance";
            ButtonContainer = new ContainerRuntime();
            ButtonContainer.Name = "ButtonContainer";
            ControlsDemoScreenButton = new SpriteButtonRuntime();
            ControlsDemoScreenButton.Name = "ControlsDemoScreenButton";
            SensorsScreenButton = new SpriteButtonRuntime();
            SensorsScreenButton.Name = "SensorsScreenButton";
            ScreenLabelInstance = new ScreenLabelRuntime();
            ScreenLabelInstance.Name = "ScreenLabelInstance";
        }
        protected virtual void AssignParents()
        {
            ButtonContainer.Children.Add(TestScreen1Button);
            this.Children.Add(BackgroundInstance);
            this.Children.Add(ButtonContainer);
            ButtonContainer.Children.Add(ControlsDemoScreenButton);
            ButtonContainer.Children.Add(SensorsScreenButton);
            this.Children.Add(ScreenLabelInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.TestScreen1Button.ButtonText = "Test Screen #1";
            this.TestScreen1Button.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TestScreen1Button.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TestScreen1Button.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TestScreen1Button.YUnits = GeneralUnitType.PixelsFromSmall;

            this.BackgroundInstance.X = 0f;

            this.ButtonContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.ButtonContainer.Height = 0f;
            this.ButtonContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ButtonContainer.StackSpacing = 10f;
            this.ButtonContainer.Width = 0f;
            this.ButtonContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ButtonContainer.X = -5f;
            this.ButtonContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ButtonContainer.XUnits = GeneralUnitType.PixelsFromLarge;
            this.ButtonContainer.Y = -5f;
            this.ButtonContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.ButtonContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.ControlsDemoScreenButton.ButtonText = "Controls Demo";
            this.ControlsDemoScreenButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ControlsDemoScreenButton.XUnits = GeneralUnitType.PixelsFromLarge;
            this.ControlsDemoScreenButton.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;

            this.SensorsScreenButton.ButtonText = "Sensors Demo Screen";
            this.SensorsScreenButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.SensorsScreenButton.XUnits = GeneralUnitType.PixelsFromLarge;

            this.ScreenLabelInstance.Text = "Main Menu";

        }
        partial void CustomInitialize();
    }
}
