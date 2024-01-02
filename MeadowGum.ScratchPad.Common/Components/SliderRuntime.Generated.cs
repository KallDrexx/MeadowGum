//Code for Slider (Container)
using Gum.Converters;
using Gum.DataTypes;
using Gum.Managers;
using Gum.Wireframe;

using RenderingLibrary.Graphics;

using MeadowGum.Shared;
using MeadowGum.Shared.Components;
using MeadowGum.ScratchPad.Common.Components;


namespace MeadowGum.ScratchPad.Common.Components
{
    public partial class SliderRuntime
    {
        public ContainerRuntime TextArea { get; protected set; }
        public TextRuntime Label { get; protected set; }
        public ContainerRuntime SliderArea { get; protected set; }
        public SpriteRuntime Left { get; protected set; }
        public ColoredRectangleRuntime ColoredRectangleInstance { get; protected set; }
        public SpriteRuntime Right { get; protected set; }
        public SpriteRuntime Indicator { get; protected set; }
        public ContainerRuntime SliderComponents { get; protected set; }

        public string SliderLabelText
        {
            get => Label.Text;
            set => Label.Text = value;
        }

        public SliderRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                this.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
                this.Height = 0f;
                this.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                 
                this.Width = 100f;
                this.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;

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
            TextArea = new ContainerRuntime();
            TextArea.Name = "TextArea";
            Label = new TextRuntime();
            Label.Name = "Label";
            SliderArea = new ContainerRuntime();
            SliderArea.Name = "SliderArea";
            Left = new SpriteRuntime();
            Left.Name = "Left";
            ColoredRectangleInstance = new ColoredRectangleRuntime();
            ColoredRectangleInstance.Name = "ColoredRectangleInstance";
            Right = new SpriteRuntime();
            Right.Name = "Right";
            Indicator = new SpriteRuntime();
            Indicator.Name = "Indicator";
            SliderComponents = new ContainerRuntime();
            SliderComponents.Name = "SliderComponents";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(TextArea);
            TextArea.Children.Add(Label);
            this.Children.Add(SliderArea);
            SliderComponents.Children.Add(Left);
            SliderComponents.Children.Add(ColoredRectangleInstance);
            SliderComponents.Children.Add(Right);
            this.Children.Add(Indicator);
            SliderArea.Children.Add(SliderComponents);
        }
        private void ApplyDefaultVariables()
        {
            this.TextArea.Height = 0f;
            this.TextArea.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TextArea.Width = 0f;
            this.TextArea.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.Label.Blue = 144;
            this.Label.Green = 186;
            this.Label.Height = 0f;
            this.Label.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.Red = 206;
            this.Label.Text = "Label";
            this.Label.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Label.Width = 0f;
            this.Label.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.X = 5f;
            this.Label.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Label.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Label.YUnits = GeneralUnitType.PixelsFromLarge;

            this.SliderArea.ChildrenLayout = global::Gum.Managers.ChildrenLayout.Regular;
            this.SliderArea.Height = 16f;
            this.SliderArea.Width = 100f;
            this.SliderArea.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;

            this.Left.SourceFile = "retro-meadow-ui.bmp";
            this.Left.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Left.TextureHeight = 16;
            this.Left.TextureLeft = 45;
            this.Left.TextureTop = 13;
            this.Left.TextureWidth = 6;

            this.ColoredRectangleInstance.Blue = 144;
            this.ColoredRectangleInstance.Green = 186;
            this.ColoredRectangleInstance.Height = 16f;
            this.ColoredRectangleInstance.Red = 206;
            this.ColoredRectangleInstance.Width = -12f;
            this.ColoredRectangleInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;

            this.Right.SourceFile = "retro-meadow-ui.bmp";
            this.Right.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Right.TextureHeight = 16;
            this.Right.TextureLeft = 52;
            this.Right.TextureTop = 13;
            this.Right.TextureWidth = 6;

            this.Indicator.SourceFile = "retro-meadow-ui.bmp";
            this.Indicator.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Indicator.TextureHeight = 10;
            this.Indicator.TextureLeft = 32;
            this.Indicator.TextureTop = 0;
            this.Indicator.TextureWidth = 10;
            this.Indicator.X = 3f;
            this.Indicator.Y = -13f;

            this.SliderComponents.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.SliderComponents.Height = 100f;
            this.SliderComponents.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.SliderComponents.Width = 100f;
            this.SliderComponents.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;

        }
        partial void CustomInitialize();
    }
}
