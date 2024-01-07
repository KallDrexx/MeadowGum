//Code for KeyCap (Container)
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
    public partial class KeyCapRuntime
    {
        public enum Selection
        {
            Selected,
            UnSelected,
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
                            this.Border.Blue = 0;
                            this.KeyLabel.Blue = 0;
                            break;
                        case Selection.UnSelected:
                            this.Border.Blue = 255;
                            this.KeyLabel.Blue = 255;
                            break;
                    }
                }
            }
        }
        public TextRuntime KeyLabel { get; protected set; }
        public ColoredRectangleRuntime Background { get; protected set; }
        public ColoredRectangleRuntime Border { get; protected set; }

        public string KeyText
        {
            get => KeyLabel.Text;
            set => KeyLabel.Text = value;
        }

        public KeyCapRuntime(bool fullInstantiation = true)
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
            KeyLabel = new TextRuntime();
            KeyLabel.Name = "KeyLabel";
            Background = new ColoredRectangleRuntime();
            Background.Name = "Background";
            Border = new ColoredRectangleRuntime();
            Border.Name = "Border";
        }
        protected virtual void AssignParents()
        {
            Background.Children.Add(KeyLabel);
            Border.Children.Add(Background);
            this.Children.Add(Border);
        }
        private void ApplyDefaultVariables()
        {
            this.KeyLabel.Height = 0f;
            this.KeyLabel.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.KeyLabel.Width = 0f;
            this.KeyLabel.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.KeyLabel.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.KeyLabel.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.KeyLabel.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.KeyLabel.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Background.Blue = 0;
            this.Background.Green = 0;
            this.Background.Height = 5f;
            this.Background.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Background.Red = 0;
            this.Background.Width = 5f;
            this.Background.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Background.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Background.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Background.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Background.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Border.Height = 2f;
            this.Border.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Border.Width = 2f;
            this.Border.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

        }
        partial void CustomInitialize();
    }
}
