//Code for ToggleButton (Container)
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
    public partial class ToggleButtonRuntime
    {
        public enum Toggle
        {
            Off,
            On,
        }

        Toggle mToggleState;
        public Toggle ToggleState
        {
            get => mToggleState;
            set
            {
                mToggleState = value;
                var appliedDynamically = false;
                if(!appliedDynamically)
                {
                    switch (value)
                    {
                        case Toggle.Off:
                            this.Indicator.TextureHeight = 10;
                            this.Indicator.TextureLeft = 59;
                            this.Indicator.TextureTop = 14;
                            this.Indicator.TextureWidth = 10;
                            this.Indicator.X = 3f;
                            this.Indicator.Y = 3f;
                            this.Indicator.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
                            this.Indicator.YUnits = GeneralUnitType.PixelsFromSmall;
                            break;
                        case Toggle.On:
                            this.Indicator.TextureHeight = 10;
                            this.Indicator.TextureLeft = 70;
                            this.Indicator.TextureTop = 14;
                            this.Indicator.TextureWidth = 10;
                            this.Indicator.X = 19f;
                            this.Indicator.Y = 3f;
                            this.Indicator.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
                            this.Indicator.YUnits = GeneralUnitType.PixelsFromSmall;
                            break;
                    }
                }
            }
        }
        public SpriteRuntime Left { get; protected set; }
        public ColoredRectangleRuntime ColoredRectangleInstance { get; protected set; }
        public SpriteRuntime Right { get; protected set; }
        public ContainerRuntime ContainerInstance { get; protected set; }
        public TextRuntime Label { get; protected set; }
        public SpriteRuntime Indicator { get; protected set; }

        public string LabelText
        {
            get => Label.Text;
            set => Label.Text = value;
        }

        public ToggleButtonRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                this.ChildrenLayout = global::Gum.Managers.ChildrenLayout.Regular;
                this.Height = 0f;
                this.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                 
                this.Width = 0f;
                this.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

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
            Left = new SpriteRuntime();
            Left.Name = "Left";
            ColoredRectangleInstance = new ColoredRectangleRuntime();
            ColoredRectangleInstance.Name = "ColoredRectangleInstance";
            Right = new SpriteRuntime();
            Right.Name = "Right";
            ContainerInstance = new ContainerRuntime();
            ContainerInstance.Name = "ContainerInstance";
            Label = new TextRuntime();
            Label.Name = "Label";
            Indicator = new SpriteRuntime();
            Indicator.Name = "Indicator";
        }
        protected virtual void AssignParents()
        {
            ContainerInstance.Children.Add(Left);
            ContainerInstance.Children.Add(ColoredRectangleInstance);
            ContainerInstance.Children.Add(Right);
            this.Children.Add(ContainerInstance);
            ContainerInstance.Children.Add(Label);
            this.Children.Add(Indicator);
        }
        private void ApplyDefaultVariables()
        {
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
            this.ColoredRectangleInstance.Width = 20f;
            this.ColoredRectangleInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;

            this.Right.SourceFile = "retro-meadow-ui.bmp";
            this.Right.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Right.TextureHeight = 16;
            this.Right.TextureLeft = 52;
            this.Right.TextureTop = 13;
            this.Right.TextureWidth = 6;

            this.ContainerInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.ContainerInstance.Height = 0f;
            this.ContainerInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ContainerInstance.Width = 0f;
            this.ContainerInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

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
            this.Label.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Label.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Indicator.SourceFile = "retro-meadow-ui.bmp";
            this.Indicator.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Indicator.TextureHeight = 0;
            this.Indicator.TextureLeft = 0;
            this.Indicator.TextureTop = 0;
            this.Indicator.TextureWidth = 0;

        }
        partial void CustomInitialize();
    }
}
