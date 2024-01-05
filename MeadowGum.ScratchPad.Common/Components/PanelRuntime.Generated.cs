//Code for Panel (Container)
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
    public partial class PanelRuntime
    {
        public ColoredRectangleRuntime Background { get; protected set; }
        public ColoredRectangleRuntime Left { get; protected set; }
        public ColoredRectangleRuntime Right { get; protected set; }
        public ColoredRectangleRuntime Top { get; protected set; }
        public ColoredRectangleRuntime ColoredRectangleInstance { get; protected set; }

        public PanelRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                 

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
            Background = new ColoredRectangleRuntime();
            Background.Name = "Background";
            Left = new ColoredRectangleRuntime();
            Left.Name = "Left";
            Right = new ColoredRectangleRuntime();
            Right.Name = "Right";
            Top = new ColoredRectangleRuntime();
            Top.Name = "Top";
            ColoredRectangleInstance = new ColoredRectangleRuntime();
            ColoredRectangleInstance.Name = "ColoredRectangleInstance";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(Background);
            this.Children.Add(Left);
            this.Children.Add(Right);
            this.Children.Add(Top);
            this.Children.Add(ColoredRectangleInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.Background.Blue = 194;
            this.Background.Green = 229;
            this.Background.Height = 0f;
            this.Background.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Background.Red = 238;
            this.Background.Width = 0f;
            this.Background.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Background.X = 0f;
            this.Background.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Background.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Background.Y = 0f;
            this.Background.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Background.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Left.Blue = 0;
            this.Left.Green = 0;
            this.Left.Height = 0f;
            this.Left.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Left.Red = 0;
            this.Left.Width = 2f;
            this.Left.X = 0f;
            this.Left.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Left.XUnits = GeneralUnitType.PixelsFromSmall;
            this.Left.Y = 0f;
            this.Left.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Left.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Right.Blue = 0;
            this.Right.Green = 0;
            this.Right.Height = 0f;
            this.Right.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Right.Red = 0;
            this.Right.Width = 2f;
            this.Right.X = 0f;
            this.Right.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Right.XUnits = GeneralUnitType.PixelsFromLarge;
            this.Right.Y = 0f;
            this.Right.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Right.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Top.Blue = 0;
            this.Top.Green = 0;
            this.Top.Height = 2f;
            this.Top.Red = 0;
            this.Top.Width = 0f;
            this.Top.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Top.X = 0f;
            this.Top.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Top.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Top.Y = 0f;
            this.Top.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Top.YUnits = GeneralUnitType.PixelsFromSmall;

            this.ColoredRectangleInstance.Blue = 0;
            this.ColoredRectangleInstance.Green = 0;
            this.ColoredRectangleInstance.Height = 2f;
            this.ColoredRectangleInstance.Red = 0;
            this.ColoredRectangleInstance.Width = 0f;
            this.ColoredRectangleInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.ColoredRectangleInstance.X = 0f;
            this.ColoredRectangleInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ColoredRectangleInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.ColoredRectangleInstance.Y = 0f;
            this.ColoredRectangleInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.ColoredRectangleInstance.YUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
