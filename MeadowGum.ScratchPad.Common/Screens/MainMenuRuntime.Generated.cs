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
            this.Children.Add(ButtonContainer);
            ButtonContainer.Children.Add(SpriteButtonInstance1);
            ButtonContainer.Children.Add(SpriteButtonInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.TestScreen1Button.ButtonText = "Test Screen #1";
            this.TestScreen1Button.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TestScreen1Button.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.TestScreen1Button.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TestScreen1Button.YUnits = GeneralUnitType.PixelsFromSmall;

            this.ButtonContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.ButtonContainer.Height = 0f;
            this.ButtonContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ButtonContainer.StackSpacing = 25f;
            this.ButtonContainer.Width = 0f;
            this.ButtonContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ButtonContainer.X = 0f;
            this.ButtonContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ButtonContainer.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.ButtonContainer.Y = 0f;
            this.ButtonContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.ButtonContainer.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.SpriteButtonInstance1.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.SpriteButtonInstance1.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.SpriteButtonInstance1.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;

            this.SpriteButtonInstance.ButtonText = "SomeOtherButton";
            this.SpriteButtonInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.SpriteButtonInstance.XUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
