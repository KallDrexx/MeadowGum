//Code for ScreenLabel (Text)
using Gum.Converters;
using Gum.DataTypes;
using Gum.Managers;
using Gum.Wireframe;

using RenderingLibrary.Graphics;

using MeadowGum.Core;
using MeadowGum.Core.Components;
using MeadowGum.ScratchPad.Common.Components;


namespace MeadowGum.ScratchPad.Common.Components
{
    public partial class ScreenLabelRuntime
    {

        public ScreenLabelRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {

                this.Alpha = 255;
                this.Blue = 106;
                this.CustomFontFile = "";
                 
                this.Font = "Arial";
                this.FontScale = 1f;
                this.FontSize = 18;
                this.Green = 116;
                 
                this.Height = 0f;
                this.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                this.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
                this.IgnoredByParentSize = false;
                this.IsBold = false;
                this.IsItalic = false;
                 
                this.LineHeightMultiplier = 1f;
                this.OutlineThickness = 0;
                this.Red = 81;
                this.Text = "Some Screen";
                this.TextOverflowHorizontalMode = global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.TruncateWord;
                this.TextOverflowVerticalMode = global::RenderingLibrary.Graphics.TextOverflowVerticalMode.SpillOver;
                this.UseCustomFont = false;
                this.UseFontSmoothing = true;
                this.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
                this.Visible = true;
                this.Width = 0f;
                this.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                this.X = -10f;
                this.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
                this.XUnits = GeneralUnitType.PixelsFromLarge;
                this.Y = 15f;
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
