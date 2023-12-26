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
        public SimpleButtonRuntime TestScreen1Button { get; protected set; }
        public SimpleButtonRuntime Second { get; protected set; }
        public SimpleButtonRuntime SimpleButtonInstance1 { get; protected set; }
        public ContainerRuntime ButtonContainer { get; protected set; }

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
            TestScreen1Button = new SimpleButtonRuntime();
            TestScreen1Button.Name = "TestScreen1Button";
            Second = new SimpleButtonRuntime();
            Second.Name = "Second";
            SimpleButtonInstance1 = new SimpleButtonRuntime();
            SimpleButtonInstance1.Name = "SimpleButtonInstance1";
            ButtonContainer = new ContainerRuntime();
            ButtonContainer.Name = "ButtonContainer";
        }
        protected virtual void AssignParents()
        {
            ButtonContainer.Children.Add(TestScreen1Button);
            ButtonContainer.Children.Add(Second);
            ButtonContainer.Children.Add(SimpleButtonInstance1);
            this.Children.Add(ButtonContainer);
        }
        private void ApplyDefaultVariables()
        {
            this.TestScreen1Button.BorderMarginHeight = -5f;
            this.TestScreen1Button.BorderMarginWidth = -5f;
            this.TestScreen1Button.ButtonText = "Test Screen #1";
            this.TestScreen1Button.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TestScreen1Button.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TestScreen1Button.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.Second.BorderMarginHeight = -5f;
            this.Second.BorderMarginWidth = -5f;
            this.Second.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Second.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.SimpleButtonInstance1.BorderMarginHeight = -5f;
            this.SimpleButtonInstance1.BorderMarginWidth = -5f;
            this.SimpleButtonInstance1.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.SimpleButtonInstance1.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ButtonContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.ButtonContainer.Height = 50f;
            this.ButtonContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ButtonContainer.StackSpacing = 25f;
            this.ButtonContainer.Width = 50f;
            this.ButtonContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ButtonContainer.X = 0f;
            this.ButtonContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ButtonContainer.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.ButtonContainer.Y = 0f;
            this.ButtonContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.ButtonContainer.YUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
