//Code for ProgressIndicator (Sprite)
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
    public partial class ProgressIndicatorRuntime
    {
        public enum Color
        {
            Green,
            Red,
        }

        Color mColorState;
        public Color ColorState
        {
            get => mColorState;
            set
            {
                mColorState = value;
                var appliedDynamically = false;
                if(!appliedDynamically)
                {
                    switch (value)
                    {
                        case Color.Green:
                            this.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
                            this.TextureHeight = 6;
                            this.TextureLeft = 32;
                            this.TextureTop = 19;
                            this.TextureWidth = 12;
                            this.Wrap = false;
                            break;
                        case Color.Red:
                            this.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
                            this.TextureHeight = 6;
                            this.TextureLeft = 32;
                            this.TextureTop = 11;
                            this.TextureWidth = 12;
                            this.Wrap = false;
                            break;
                    }
                }
            }
        }

        public ProgressIndicatorRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {

                this.Alpha = 255;
                this.Animate = false;
                this.Blue = 255;
                 
                this.FlipHorizontal = false;
                this.FlipVertical = false;
                this.Green = 255;
                 
                this.Height = 100f;
                this.HeightUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                this.IgnoredByParentSize = false;
                 
                this.Red = 255;
                this.SourceFile = "retro-meadow-ui.bmp";
                this.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
                this.TextureHeight = 6;
                this.TextureHeightScale = 0f;
                this.TextureLeft = 32;
                this.TextureTop = 19;
                this.TextureWidth = 12;
                this.TextureWidthScale = 0f;
                this.Visible = true;
                this.Width = 100f;
                this.WidthUnits = global::Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                this.Wrap = false;
                this.X = 0f;
                this.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
                this.XUnits = GeneralUnitType.PixelsFromSmall;
                this.Y = 0f;
                this.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
                this.YUnits = GeneralUnitType.PixelsFromSmall;

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
        }
        protected virtual void AssignParents()
        {
        }
        private void ApplyDefaultVariables()
        {
        }
        partial void CustomInitialize();
    }
}
