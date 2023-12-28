//Code for VerticalProgressBar (Container)
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
    public partial class VerticalProgressBarRuntime
    {
        public ColoredRectangleRuntime Background { get; protected set; }
        public ContainerRuntime Indicators { get; protected set; }

        public VerticalProgressBarRuntime(bool fullInstantiation = true)
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
            Background = new ColoredRectangleRuntime();
            Background.Name = "Background";
            Indicators = new ContainerRuntime();
            Indicators.Name = "Indicators";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(Background);
            this.Children.Add(Indicators);
        }
        private void ApplyDefaultVariables()
        {
            this.Background.Blue = 144;
            this.Background.Green = 186;
            this.Background.Height = 96f;
            this.Background.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;
            this.Background.Red = 206;
            this.Background.Width = 16f;
            this.Background.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Absolute;

            this.Indicators.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.Indicators.ContainedType = "ProgressIndicator";
            this.Indicators.Height = 0f;
            this.Indicators.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Indicators.StackSpacing = 2f;
            this.Indicators.Width = 100f;
            this.Indicators.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.Indicators.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Indicators.YUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
