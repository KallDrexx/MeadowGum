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
        public TextRuntime Label { get; protected set; }
        public ContainerRuntime ButtonContainer { get; protected set; }
        public SpriteButtonRuntime SpriteButtonInstance1 { get; protected set; }
        public SpriteButtonRuntime SpriteButtonInstance { get; protected set; }

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
            Label = new TextRuntime();
            Label.Name = "Label";
            ButtonContainer = new ContainerRuntime();
            ButtonContainer.Name = "ButtonContainer";
            SpriteButtonInstance1 = new SpriteButtonRuntime();
            SpriteButtonInstance1.Name = "SpriteButtonInstance1";
            SpriteButtonInstance = new SpriteButtonRuntime();
            SpriteButtonInstance.Name = "SpriteButtonInstance";
        }
        protected virtual void AssignParents()
        {
            ButtonContainer.Children.Add(TestScreen1Button);
            this.Children.Add(BackgroundInstance);
            this.Children.Add(Label);
            this.Children.Add(ButtonContainer);
            ButtonContainer.Children.Add(SpriteButtonInstance1);
            ButtonContainer.Children.Add(SpriteButtonInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.TestScreen1Button.ButtonText = "Test Screen #1";
            this.TestScreen1Button.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TestScreen1Button.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TestScreen1Button.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TestScreen1Button.YUnits = GeneralUnitType.PixelsFromSmall;

            this.BackgroundInstance.X = 0f;

            this.Label.Blue = 106;
            this.Label.Green = 116;
            this.Label.Height = 0f;
            this.Label.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.Red = 81;
            this.Label.Text = "MAIN MENU";
            this.Label.Width = 0f;
            this.Label.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.X = -10f;
            this.Label.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Label.XUnits = GeneralUnitType.PixelsFromLarge;
            this.Label.Y = 15f;

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

            this.SpriteButtonInstance1.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.SpriteButtonInstance1.XUnits = GeneralUnitType.PixelsFromLarge;
            this.SpriteButtonInstance1.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;

            this.SpriteButtonInstance.ButtonText = "SomeOtherButton";
            this.SpriteButtonInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.SpriteButtonInstance.XUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
