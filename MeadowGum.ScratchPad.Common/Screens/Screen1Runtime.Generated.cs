//Code for Screen1
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
    public partial class Screen1Runtime
    {
        public ColoredRectangleRuntime OuterRectangle { get; protected set; }
        public ColoredRectangleRuntime TopLeft { get; protected set; }
        public ColoredRectangleRuntime TopRight { get; protected set; }
        public ColoredRectangleRuntime BottomLeft { get; protected set; }
        public ColoredRectangleRuntime BottomRight { get; protected set; }
        public ColoredRectangleRuntime Center { get; protected set; }
        public TextRuntime TextInstance { get; protected set; }
        public SpriteRuntime Sun { get; protected set; }

        public Screen1Runtime(bool fullInstantiation = true)
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
            OuterRectangle = new ColoredRectangleRuntime();
            OuterRectangle.Name = "OuterRectangle";
            TopLeft = new ColoredRectangleRuntime();
            TopLeft.Name = "TopLeft";
            TopRight = new ColoredRectangleRuntime();
            TopRight.Name = "TopRight";
            BottomLeft = new ColoredRectangleRuntime();
            BottomLeft.Name = "BottomLeft";
            BottomRight = new ColoredRectangleRuntime();
            BottomRight.Name = "BottomRight";
            Center = new ColoredRectangleRuntime();
            Center.Name = "Center";
            TextInstance = new TextRuntime();
            TextInstance.Name = "TextInstance";
            Sun = new SpriteRuntime();
            Sun.Name = "Sun";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(OuterRectangle);
            OuterRectangle.Children.Add(TopLeft);
            OuterRectangle.Children.Add(TopRight);
            OuterRectangle.Children.Add(BottomLeft);
            OuterRectangle.Children.Add(BottomRight);
            OuterRectangle.Children.Add(Center);
            this.Children.Add(TextInstance);
            this.Children.Add(Sun);
        }
        private void ApplyDefaultVariables()
        {
            this.OuterRectangle.Height = 200f;
            this.OuterRectangle.Width = 200f;
            this.OuterRectangle.X = 0f;
            this.OuterRectangle.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.OuterRectangle.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.OuterRectangle.Y = 0f;
            this.OuterRectangle.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.OuterRectangle.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.TopLeft.Blue = 0;
            this.TopLeft.Green = 0;
            this.TopLeft.Height = 25f;
            this.TopLeft.Width = 25f;
            this.TopLeft.X = 10f;
            this.TopLeft.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.TopLeft.XUnits = GeneralUnitType.PixelsFromSmall;
            this.TopLeft.Y = 10f;
            this.TopLeft.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopLeft.YUnits = GeneralUnitType.PixelsFromSmall;

            this.TopRight.Blue = 0;
            this.TopRight.Height = 25f;
            this.TopRight.Red = 0;
            this.TopRight.Width = 25f;
            this.TopRight.X = 0f;
            this.TopRight.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TopRight.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TopRight.Y = 0f;
            this.TopRight.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopRight.YUnits = GeneralUnitType.PixelsFromSmall;

            this.BottomLeft.Green = 0;
            this.BottomLeft.Height = 25f;
            this.BottomLeft.Red = 0;
            this.BottomLeft.Width = 25f;
            this.BottomLeft.X = 0f;
            this.BottomLeft.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.BottomLeft.XUnits = GeneralUnitType.PixelsFromSmall;
            this.BottomLeft.Y = 0f;
            this.BottomLeft.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomLeft.YUnits = GeneralUnitType.PixelsFromLarge;

            this.BottomRight.Blue = 0;
            this.BottomRight.Height = 25f;
            this.BottomRight.Width = 25f;
            this.BottomRight.X = -30f;
            this.BottomRight.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.BottomRight.XUnits = GeneralUnitType.PixelsFromLarge;
            this.BottomRight.Y = -15f;
            this.BottomRight.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomRight.YUnits = GeneralUnitType.PixelsFromLarge;

            this.Center.Height = 25f;
            this.Center.Red = 0;
            this.Center.Width = 25f;
            this.Center.X = 0f;
            this.Center.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Center.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Center.Y = 0f;
            this.Center.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Center.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.TextInstance.Blue = 0;
            this.TextInstance.Green = 0;
            this.TextInstance.Height = 50f;
            this.TextInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.TextInstance.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TextInstance.Text = "Helloi";
            this.TextInstance.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TextInstance.Width = 100f;
            this.TextInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.TextInstance.X = 0f;
            this.TextInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TextInstance.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TextInstance.Y = 0f;
            this.TextInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TextInstance.YUnits = GeneralUnitType.PixelsFromSmall;

            this.Sun.FlipHorizontal = false;
            this.Sun.SourceFile = "spritesheet.bmp";
            this.Sun.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Sun.TextureHeight = 14;
            this.Sun.TextureHeightScale = 1f;
            this.Sun.TextureLeft = 1;
            this.Sun.TextureTop = 49;
            this.Sun.TextureWidth = 14;
            this.Sun.TextureWidthScale = 1f;
            this.Sun.X = 0f;
            this.Sun.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Sun.XUnits = GeneralUnitType.PixelsFromLarge;
            this.Sun.Y = 0f;
            this.Sun.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Sun.YUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
