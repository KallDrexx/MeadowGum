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
                            this.Left.TextureHeight = 32;
                            this.Left.TextureLeft = 64;
                            this.Left.TextureTop = 112;
                            this.Left.TextureWidth = 7;
                            this.Right.TextureHeight = 32;
                            this.Right.TextureLeft = 121;
                            this.Right.TextureTop = 112;
                            this.Right.TextureWidth = 7;
                            break;
                        case Selection.Deselected:
                            this.ColoredRectangleInstance.Blue = 106;
                            this.ColoredRectangleInstance.Green = 116;
                            this.ColoredRectangleInstance.Red = 81;
                            this.Left.TextureHeight = 32;
                            this.Left.TextureLeft = 0;
                            this.Left.TextureTop = 112;
                            this.Left.TextureWidth = 7;
                            this.Right.TextureHeight = 32;
                            this.Right.TextureLeft = 57;
                            this.Right.TextureTop = 112;
                            this.Right.TextureWidth = 7;
                            break;
                    }
                }
            }
        }
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

                this.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
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
            TextInstance = new TextRuntime();
            TextInstance.Name = "TextInstance";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(Left);
            this.Children.Add(ColoredRectangleInstance);
            this.Children.Add(Right);
            ColoredRectangleInstance.Children.Add(TextInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.Left.Height = 100f;
            this.Left.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.Left.SourceFile = "retro-70s-UI.bmp";
            this.Left.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Left.TextureHeight = 32;
            this.Left.TextureHeightScale = 1f;
            this.Left.TextureLeft = 0;
            this.Left.TextureTop = 112;
            this.Left.TextureWidth = 7;
            this.Left.TextureWidthScale = 1f;
            this.Left.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;

            this.ColoredRectangleInstance.Blue = 106;
            this.ColoredRectangleInstance.Green = 116;
            this.ColoredRectangleInstance.Height = 32f;
            this.ColoredRectangleInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.ColoredRectangleInstance.Red = 81;
            this.ColoredRectangleInstance.Width = 16f;
            this.ColoredRectangleInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.Right.Height = 100f;
            this.Right.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
            this.Right.SourceFile = "retro-70s-UI.bmp";
            this.Right.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Right.TextureHeight = 32;
            this.Right.TextureHeightScale = 1f;
            this.Right.TextureLeft = 57;
            this.Right.TextureTop = 112;
            this.Right.TextureWidth = 7;
            this.Right.TextureWidthScale = 1f;
            this.Right.Width = 100f;
            this.Right.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;

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
