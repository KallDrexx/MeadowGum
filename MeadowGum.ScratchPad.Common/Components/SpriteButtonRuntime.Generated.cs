//Code for SpriteButton (Container)
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
    public partial class SpriteButtonRuntime
    {
        public enum Selection
        {
            Selected,
            Deselected,
        }

        Selection mSelectionState;
        public Selection SelectionState
        {
            get => mSelectionState;
            set
            {
                mSelectionState = value;
                var appliedDynamically = false;
                if(!appliedDynamically)
                {
                    switch (value)
                    {
                        case Selection.Selected:
                            this.ColoredRectangleInstance.Blue = 49;
                            this.ColoredRectangleInstance.Green = 61;
                            this.ColoredRectangleInstance.Red = 228;
                            this.ContainerInstance.Height = 0f;
                            this.ContainerInstance.Width = 0f;
                            this.Left.TextureHeight = 32;
                            this.Left.TextureLeft = 64;
                            this.Left.TextureTop = 48;
                            this.Left.TextureWidth = 9;
                            this.Right.TextureHeight = 32;
                            this.Right.TextureLeft = 118;
                            this.Right.TextureTop = 48;
                            this.Right.TextureWidth = 10;
                            break;
                        case Selection.Deselected:
                            this.ColoredRectangleInstance.Blue = 106;
                            this.ColoredRectangleInstance.Green = 116;
                            this.ColoredRectangleInstance.Red = 81;
                            this.ContainerInstance.Height = 100f;
                            this.ContainerInstance.Width = 100f;
                            this.Left.TextureHeight = 32;
                            this.Left.TextureLeft = 0;
                            this.Left.TextureTop = 48;
                            this.Left.TextureWidth = 9;
                            this.Right.TextureHeight = 32;
                            this.Right.TextureLeft = 54;
                            this.Right.TextureTop = 48;
                            this.Right.TextureWidth = 10;
                            break;
                    }
                }
            }
        }
        public ContainerRuntime ContainerInstance { get; protected set; }
        public SpriteRuntime Left { get; protected set; }
        public ColoredRectangleRuntime ColoredRectangleInstance { get; protected set; }
        public SpriteRuntime Right { get; protected set; }
        public TextRuntime TextInstance { get; protected set; }

        public string ButtonText
        {
            get => TextInstance.Text;
            set => TextInstance.Text = value;
        }

        public SpriteButtonRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

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
            ContainerInstance = new ContainerRuntime();
            ContainerInstance.Name = "ContainerInstance";
            Left = new SpriteRuntime();
            Left.Name = "Left";
            ColoredRectangleInstance = new ColoredRectangleRuntime();
            ColoredRectangleInstance.Name = "ColoredRectangleInstance";
            Right = new SpriteRuntime();
            Right.Name = "Right";
            TextInstance = new TextRuntime();
            TextInstance.Name = "TextInstance";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(ContainerInstance);
            ContainerInstance.Children.Add(Left);
            ContainerInstance.Children.Add(ColoredRectangleInstance);
            ContainerInstance.Children.Add(Right);
            ColoredRectangleInstance.Children.Add(TextInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.ContainerInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.ContainerInstance.Height = 0f;
            this.ContainerInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ContainerInstance.Width = 0f;
            this.ContainerInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.Left.SourceFile = "retro-meadow-ui.bmp";
            this.Left.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Left.TextureHeight = 32;
            this.Left.TextureHeightScale = 1f;
            this.Left.TextureLeft = 0;
            this.Left.TextureTop = 48;
            this.Left.TextureWidth = 9;
            this.Left.TextureWidthScale = 1f;

            this.ColoredRectangleInstance.Blue = 106;
            this.ColoredRectangleInstance.Green = 116;
            this.ColoredRectangleInstance.Height = 32f;
            this.ColoredRectangleInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.ColoredRectangleInstance.Red = 81;
            this.ColoredRectangleInstance.Width = 16f;
            this.ColoredRectangleInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.Right.SourceFile = "retro-meadow-ui.bmp";
            this.Right.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Right.TextureHeight = 32;
            this.Right.TextureHeightScale = 1f;
            this.Right.TextureLeft = 54;
            this.Right.TextureTop = 48;
            this.Right.TextureWidth = 10;
            this.Right.TextureWidthScale = 1f;

            this.TextInstance.Blue = 194;
            this.TextInstance.Green = 229;
            this.TextInstance.Height = 0f;
            this.TextInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TextInstance.Red = 238;
            this.TextInstance.Text = "Button Text";
            this.TextInstance.Width = 0f;
            this.TextInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TextInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TextInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.TextInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.TextInstance.YUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
