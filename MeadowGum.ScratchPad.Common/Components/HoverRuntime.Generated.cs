//Code for Hover (Container)
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
    public partial class HoverRuntime
    {
        public SpriteRuntime TopLeft { get; protected set; }
        public SpriteRuntime TopRight { get; protected set; }
        public SpriteRuntime BottomRight { get; protected set; }
        public SpriteRuntime BottomLeft { get; protected set; }

        public HoverRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                 
                this.Visible = true;
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
            TopLeft = new SpriteRuntime();
            TopLeft.Name = "TopLeft";
            TopRight = new SpriteRuntime();
            TopRight.Name = "TopRight";
            BottomRight = new SpriteRuntime();
            BottomRight.Name = "BottomRight";
            BottomLeft = new SpriteRuntime();
            BottomLeft.Name = "BottomLeft";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(TopLeft);
            this.Children.Add(TopRight);
            this.Children.Add(BottomRight);
            this.Children.Add(BottomLeft);
        }
        private void ApplyDefaultVariables()
        {
            this.TopLeft.SourceFile = "retro-70s-UI.bmp";
            this.TopLeft.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.TopLeft.TextureHeight = 13;
            this.TopLeft.TextureLeft = 0;
            this.TopLeft.TextureTop = 208;
            this.TopLeft.TextureWidth = 13;

            this.TopRight.SourceFile = "retro-70s-UI.bmp";
            this.TopRight.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.TopRight.TextureHeight = 13;
            this.TopRight.TextureLeft = 51;
            this.TopRight.TextureTop = 208;
            this.TopRight.TextureWidth = 13;
            this.TopRight.X = 0f;
            this.TopRight.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TopRight.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TopRight.Y = 0f;
            this.TopRight.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopRight.YUnits = GeneralUnitType.PixelsFromSmall;

            this.BottomRight.SourceFile = "retro-70s-UI.bmp";
            this.BottomRight.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.BottomRight.TextureHeight = 13;
            this.BottomRight.TextureLeft = 51;
            this.BottomRight.TextureTop = 227;
            this.BottomRight.TextureWidth = 13;
            this.BottomRight.X = 0f;
            this.BottomRight.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.BottomRight.XUnits = GeneralUnitType.PixelsFromLarge;
            this.BottomRight.Y = 0f;
            this.BottomRight.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomRight.YUnits = GeneralUnitType.PixelsFromLarge;

            this.BottomLeft.SourceFile = "retro-70s-UI.bmp";
            this.BottomLeft.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.BottomLeft.TextureHeight = 13;
            this.BottomLeft.TextureLeft = 0;
            this.BottomLeft.TextureTop = 227;
            this.BottomLeft.TextureWidth = 13;
            this.BottomLeft.X = 0f;
            this.BottomLeft.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.BottomLeft.XUnits = GeneralUnitType.PixelsFromSmall;
            this.BottomLeft.Y = 0f;
            this.BottomLeft.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomLeft.YUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
