//Code for SimpleButton (Container)
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
    public partial class SimpleButtonRuntime
    {
        public enum Selection
        {
            Selected,
            Unselected,
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
                            this.InnerRectangle.Blue = 0;
                            this.InnerRectangle.Green = 0;
                            this.InnerRectangle.Height = -5f;
                            this.InnerRectangle.Red = 0;
                            this.OuterRectangle.Blue = 0;
                            this.OuterRectangle.Green = 255;
                            this.OuterRectangle.Red = 255;
                            break;
                        case Selection.Unselected:
                            this.InnerRectangle.Blue = 0;
                            this.InnerRectangle.Green = 0;
                            this.InnerRectangle.Height = -5f;
                            this.InnerRectangle.Red = 0;
                            this.OuterRectangle.Blue = 255;
                            this.OuterRectangle.Green = 255;
                            this.OuterRectangle.Red = 255;
                            break;
                    }
                }
            }
        }
        public ColoredRectangleRuntime OuterRectangle { get; protected set; }
        public ColoredRectangleRuntime InnerRectangle { get; protected set; }
        public TextRuntime TextInstance { get; protected set; }

        public int InnerRectangleBlue
        {
            get => InnerRectangle.Blue;
            set => InnerRectangle.Blue = value;
        }

        public int InnerRectangleGreen
        {
            get => InnerRectangle.Green;
            set => InnerRectangle.Green = value;
        }

        public float BorderMarginHeight
        {
            get => InnerRectangle.Height;
            set => InnerRectangle.Height = value;
        }

        public int InnerRectangleRed
        {
            get => InnerRectangle.Red;
            set => InnerRectangle.Red = value;
        }

        public float BorderMarginWidth
        {
            get => InnerRectangle.Width;
            set => InnerRectangle.Width = value;
        }

        public int OuterRectangleBlue
        {
            get => OuterRectangle.Blue;
            set => OuterRectangle.Blue = value;
        }

        public int OuterRectangleGreen
        {
            get => OuterRectangle.Green;
            set => OuterRectangle.Green = value;
        }

        public int OuterRectangleRed
        {
            get => OuterRectangle.Red;
            set => OuterRectangle.Red = value;
        }

        public string ButtonText
        {
            get => TextInstance.Text;
            set => TextInstance.Text = value;
        }

        public SimpleButtonRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                this.Height = 25f;
                this.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                 
                this.Width = 25f;
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
            OuterRectangle = new ColoredRectangleRuntime();
            OuterRectangle.Name = "OuterRectangle";
            InnerRectangle = new ColoredRectangleRuntime();
            InnerRectangle.Name = "InnerRectangle";
            TextInstance = new TextRuntime();
            TextInstance.Name = "TextInstance";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(OuterRectangle);
            this.Children.Add(InnerRectangle);
            this.Children.Add(TextInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.OuterRectangle.Blue = 255;
            this.OuterRectangle.Green = 255;
            this.OuterRectangle.Height = 0f;
            this.OuterRectangle.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.OuterRectangle.Red = 255;
            this.OuterRectangle.Width = 0f;
            this.OuterRectangle.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.OuterRectangle.X = 0f;
            this.OuterRectangle.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.OuterRectangle.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.OuterRectangle.Y = 0f;
            this.OuterRectangle.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.OuterRectangle.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.InnerRectangle.Blue = 0;
            this.InnerRectangle.Green = 0;
            this.InnerRectangle.Height = -5f;
            this.InnerRectangle.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.InnerRectangle.Red = 0;
            this.InnerRectangle.Width = -5f;
            this.InnerRectangle.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.InnerRectangle.X = 0f;
            this.InnerRectangle.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.InnerRectangle.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.InnerRectangle.Y = 0f;
            this.InnerRectangle.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.InnerRectangle.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.TextInstance.Height = 0f;
            this.TextInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TextInstance.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TextInstance.Text = "Button Text";
            this.TextInstance.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.TextInstance.Width = 0f;
            this.TextInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TextInstance.X = 0f;
            this.TextInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TextInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.TextInstance.Y = 0f;
            this.TextInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.TextInstance.YUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
