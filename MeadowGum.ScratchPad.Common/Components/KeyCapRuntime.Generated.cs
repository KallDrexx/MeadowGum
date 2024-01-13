//Code for KeyCap (Container)
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
    public partial class KeyCapRuntime
    {
        public ColoredRectangleRuntime Border { get; protected set; }
        public ColoredRectangleRuntime Background { get; protected set; }
        public TextRuntime Label { get; protected set; }

        public KeyCapRuntime(bool fullInstantiation = true)
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
            Border = new ColoredRectangleRuntime();
            Border.Name = "Border";
            Background = new ColoredRectangleRuntime();
            Background.Name = "Background";
            Label = new TextRuntime();
            Label.Name = "Label";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(Border);
            this.Children.Add(Background);
            Background.Children.Add(Label);
        }
        private void ApplyDefaultVariables()
        {
            this.Border.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Border.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Border.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Border.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Background.Blue = 0;
            this.Background.Green = 0;
            this.Background.Height = 20f;
            this.Background.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Background.Red = 0;
            this.Background.Width = 10f;
            this.Background.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Background.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Background.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Background.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Background.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Label.Height = 0f;
            this.Label.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.Width = 0f;
            this.Label.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Label.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Label.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Label.YUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
