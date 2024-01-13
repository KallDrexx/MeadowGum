//Code for Background (Container)
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
    public partial class BackgroundRuntime
    {
        public ColoredRectangleRuntime BackgroundColor { get; protected set; }
        public ColoredRectangleRuntime Stripe1 { get; protected set; }
        public ColoredRectangleRuntime Stripe2 { get; protected set; }
        public ColoredRectangleRuntime Stripe3 { get; protected set; }

        public BackgroundRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                this.Height = 0f;
                this.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                 
                this.Width = 0f;
                this.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                this.X = 0f;
                this.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
                this.XUnits = GeneralUnitType.PixelsFromMiddle;
                this.Y = 0f;
                this.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
                this.YUnits = GeneralUnitType.PixelsFromMiddle;

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
            BackgroundColor = new ColoredRectangleRuntime();
            BackgroundColor.Name = "BackgroundColor";
            Stripe1 = new ColoredRectangleRuntime();
            Stripe1.Name = "Stripe1";
            Stripe2 = new ColoredRectangleRuntime();
            Stripe2.Name = "Stripe2";
            Stripe3 = new ColoredRectangleRuntime();
            Stripe3.Name = "Stripe3";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(BackgroundColor);
            this.Children.Add(Stripe1);
            this.Children.Add(Stripe2);
            this.Children.Add(Stripe3);
        }
        private void ApplyDefaultVariables()
        {
            this.BackgroundColor.Blue = 194;
            this.BackgroundColor.Green = 239;
            this.BackgroundColor.Height = 0f;
            this.BackgroundColor.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.BackgroundColor.Red = 238;
            this.BackgroundColor.Width = 0f;
            this.BackgroundColor.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.BackgroundColor.X = 0f;
            this.BackgroundColor.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.BackgroundColor.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.BackgroundColor.Y = 0f;
            this.BackgroundColor.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.BackgroundColor.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Stripe1.Blue = 49;
            this.Stripe1.Green = 61;
            this.Stripe1.Height = 0f;
            this.Stripe1.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Stripe1.Red = 228;
            this.Stripe1.Width = 16f;
            this.Stripe1.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.Stripe1.X = 16f;
            this.Stripe1.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Stripe1.XUnits = GeneralUnitType.PixelsFromSmall;
            this.Stripe1.Y = 0f;
            this.Stripe1.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Stripe1.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Stripe2.Blue = 106;
            this.Stripe2.Green = 116;
            this.Stripe2.Height = 0f;
            this.Stripe2.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Stripe2.Red = 81;
            this.Stripe2.Width = 16f;
            this.Stripe2.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.Stripe2.X = 40f;
            this.Stripe2.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Stripe2.XUnits = GeneralUnitType.PixelsFromSmall;
            this.Stripe2.Y = 0f;
            this.Stripe2.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Stripe2.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Stripe3.Blue = 89;
            this.Stripe3.Green = 193;
            this.Stripe3.Height = 0f;
            this.Stripe3.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Stripe3.Red = 239;
            this.Stripe3.Width = 16f;
            this.Stripe3.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.Stripe3.X = 64f;
            this.Stripe3.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Stripe3.XUnits = GeneralUnitType.PixelsFromSmall;
            this.Stripe3.Y = 0f;
            this.Stripe3.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Stripe3.YUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
