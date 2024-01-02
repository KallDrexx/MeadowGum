//Code for Hover (Container)
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
    public partial class HoverRuntime
    {
        public ColoredRectangleRuntime TopLeftHorizontal { get; protected set; }
        public ColoredRectangleRuntime TopLeftVertical { get; protected set; }
        public ColoredRectangleRuntime TopRightHorizontal { get; protected set; }
        public ColoredRectangleRuntime TopRightVertical { get; protected set; }
        public ColoredRectangleRuntime BottomLeftHorizontal { get; protected set; }
        public ColoredRectangleRuntime BottomLeftVertical { get; protected set; }
        public ColoredRectangleRuntime BottomRightHorizontal { get; protected set; }
        public ColoredRectangleRuntime BottomRightVertical { get; protected set; }

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
            TopLeftHorizontal = new ColoredRectangleRuntime();
            TopLeftHorizontal.Name = "TopLeftHorizontal";
            TopLeftVertical = new ColoredRectangleRuntime();
            TopLeftVertical.Name = "TopLeftVertical";
            TopRightHorizontal = new ColoredRectangleRuntime();
            TopRightHorizontal.Name = "TopRightHorizontal";
            TopRightVertical = new ColoredRectangleRuntime();
            TopRightVertical.Name = "TopRightVertical";
            BottomLeftHorizontal = new ColoredRectangleRuntime();
            BottomLeftHorizontal.Name = "BottomLeftHorizontal";
            BottomLeftVertical = new ColoredRectangleRuntime();
            BottomLeftVertical.Name = "BottomLeftVertical";
            BottomRightHorizontal = new ColoredRectangleRuntime();
            BottomRightHorizontal.Name = "BottomRightHorizontal";
            BottomRightVertical = new ColoredRectangleRuntime();
            BottomRightVertical.Name = "BottomRightVertical";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(TopLeftHorizontal);
            this.Children.Add(TopLeftVertical);
            this.Children.Add(TopRightHorizontal);
            this.Children.Add(TopRightVertical);
            this.Children.Add(BottomLeftHorizontal);
            this.Children.Add(BottomLeftVertical);
            this.Children.Add(BottomRightHorizontal);
            this.Children.Add(BottomRightVertical);
        }
        private void ApplyDefaultVariables()
        {
            this.TopLeftHorizontal.Blue = 0;
            this.TopLeftHorizontal.Green = 0;
            this.TopLeftHorizontal.Height = 2f;
            this.TopLeftHorizontal.Red = 0;
            this.TopLeftHorizontal.Width = 20f;
            this.TopLeftHorizontal.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.TopLeftHorizontal.X = 0f;
            this.TopLeftHorizontal.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.TopLeftHorizontal.XUnits = GeneralUnitType.PixelsFromSmall;
            this.TopLeftHorizontal.Y = 0f;
            this.TopLeftHorizontal.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopLeftHorizontal.YUnits = GeneralUnitType.PixelsFromSmall;

            this.TopLeftVertical.Blue = 0;
            this.TopLeftVertical.Green = 0;
            this.TopLeftVertical.Height = 20f;
            this.TopLeftVertical.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.TopLeftVertical.Red = 0;
            this.TopLeftVertical.Width = 2f;
            this.TopLeftVertical.X = 0f;
            this.TopLeftVertical.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.TopLeftVertical.XUnits = GeneralUnitType.PixelsFromSmall;
            this.TopLeftVertical.Y = 0f;
            this.TopLeftVertical.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopLeftVertical.YUnits = GeneralUnitType.PixelsFromSmall;

            this.TopRightHorizontal.Blue = 0;
            this.TopRightHorizontal.Green = 0;
            this.TopRightHorizontal.Height = 2f;
            this.TopRightHorizontal.Red = 0;
            this.TopRightHorizontal.Width = 20f;
            this.TopRightHorizontal.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.TopRightHorizontal.X = 0f;
            this.TopRightHorizontal.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TopRightHorizontal.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TopRightHorizontal.Y = 0f;
            this.TopRightHorizontal.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopRightHorizontal.YUnits = GeneralUnitType.PixelsFromSmall;

            this.TopRightVertical.Blue = 0;
            this.TopRightVertical.Green = 0;
            this.TopRightVertical.Height = 20f;
            this.TopRightVertical.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.TopRightVertical.Red = 0;
            this.TopRightVertical.Width = 2f;
            this.TopRightVertical.X = 0f;
            this.TopRightVertical.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.TopRightVertical.XUnits = GeneralUnitType.PixelsFromLarge;
            this.TopRightVertical.Y = 0f;
            this.TopRightVertical.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.TopRightVertical.YUnits = GeneralUnitType.PixelsFromSmall;

            this.BottomLeftHorizontal.Blue = 0;
            this.BottomLeftHorizontal.Green = 0;
            this.BottomLeftHorizontal.Height = 2f;
            this.BottomLeftHorizontal.Red = 0;
            this.BottomLeftHorizontal.Width = 20f;
            this.BottomLeftHorizontal.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.BottomLeftHorizontal.X = 0f;
            this.BottomLeftHorizontal.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.BottomLeftHorizontal.XUnits = GeneralUnitType.PixelsFromSmall;
            this.BottomLeftHorizontal.Y = 0f;
            this.BottomLeftHorizontal.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomLeftHorizontal.YUnits = GeneralUnitType.PixelsFromLarge;

            this.BottomLeftVertical.Blue = 0;
            this.BottomLeftVertical.Green = 0;
            this.BottomLeftVertical.Height = 20f;
            this.BottomLeftVertical.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.BottomLeftVertical.Red = 0;
            this.BottomLeftVertical.Width = 2f;
            this.BottomLeftVertical.X = 0f;
            this.BottomLeftVertical.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.BottomLeftVertical.XUnits = GeneralUnitType.PixelsFromSmall;
            this.BottomLeftVertical.Y = 0f;
            this.BottomLeftVertical.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomLeftVertical.YUnits = GeneralUnitType.PixelsFromLarge;

            this.BottomRightHorizontal.Blue = 0;
            this.BottomRightHorizontal.Green = 0;
            this.BottomRightHorizontal.Height = 2f;
            this.BottomRightHorizontal.Red = 0;
            this.BottomRightHorizontal.Width = 20f;
            this.BottomRightHorizontal.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.BottomRightHorizontal.X = 0f;
            this.BottomRightHorizontal.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.BottomRightHorizontal.XUnits = GeneralUnitType.PixelsFromLarge;
            this.BottomRightHorizontal.Y = 0f;
            this.BottomRightHorizontal.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomRightHorizontal.YUnits = GeneralUnitType.PixelsFromLarge;

            this.BottomRightVertical.Blue = 0;
            this.BottomRightVertical.Green = 0;
            this.BottomRightVertical.Height = 20f;
            this.BottomRightVertical.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.BottomRightVertical.Red = 0;
            this.BottomRightVertical.Width = 2f;
            this.BottomRightVertical.X = 0f;
            this.BottomRightVertical.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.BottomRightVertical.XUnits = GeneralUnitType.PixelsFromLarge;
            this.BottomRightVertical.Y = 0f;
            this.BottomRightVertical.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.BottomRightVertical.YUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
