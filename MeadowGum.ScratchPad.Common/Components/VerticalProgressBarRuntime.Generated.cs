//Code for VerticalProgressBar (Container)
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
    public partial class VerticalProgressBarRuntime
    {
        public enum Color
        {
            Green,
            Red,
            Yellow,
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
                            break;
                        case Color.Red:
                            break;
                        case Color.Yellow:
                            break;
                    }
                }
            }
        }
        public SpriteRuntime Background { get; protected set; }
        public ContainerRuntime Indicators { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance1 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance2 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance3 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance4 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance5 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance6 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance7 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance8 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance9 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance10 { get; protected set; }
        public ProgressIndicatorRuntime ProgressIndicatorInstance11 { get; protected set; }

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
            Background = new SpriteRuntime();
            Background.Name = "Background";
            Indicators = new ContainerRuntime();
            Indicators.Name = "Indicators";
            ProgressIndicatorInstance = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance.Name = "ProgressIndicatorInstance";
            ProgressIndicatorInstance1 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance1.Name = "ProgressIndicatorInstance1";
            ProgressIndicatorInstance2 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance2.Name = "ProgressIndicatorInstance2";
            ProgressIndicatorInstance3 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance3.Name = "ProgressIndicatorInstance3";
            ProgressIndicatorInstance4 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance4.Name = "ProgressIndicatorInstance4";
            ProgressIndicatorInstance5 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance5.Name = "ProgressIndicatorInstance5";
            ProgressIndicatorInstance6 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance6.Name = "ProgressIndicatorInstance6";
            ProgressIndicatorInstance7 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance7.Name = "ProgressIndicatorInstance7";
            ProgressIndicatorInstance8 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance8.Name = "ProgressIndicatorInstance8";
            ProgressIndicatorInstance9 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance9.Name = "ProgressIndicatorInstance9";
            ProgressIndicatorInstance10 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance10.Name = "ProgressIndicatorInstance10";
            ProgressIndicatorInstance11 = new ProgressIndicatorRuntime();
            ProgressIndicatorInstance11.Name = "ProgressIndicatorInstance11";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(Background);
            this.Children.Add(Indicators);
            Indicators.Children.Add(ProgressIndicatorInstance);
            Indicators.Children.Add(ProgressIndicatorInstance1);
            Indicators.Children.Add(ProgressIndicatorInstance2);
            Indicators.Children.Add(ProgressIndicatorInstance3);
            Indicators.Children.Add(ProgressIndicatorInstance4);
            Indicators.Children.Add(ProgressIndicatorInstance5);
            Indicators.Children.Add(ProgressIndicatorInstance6);
            Indicators.Children.Add(ProgressIndicatorInstance7);
            Indicators.Children.Add(ProgressIndicatorInstance8);
            Indicators.Children.Add(ProgressIndicatorInstance9);
            Indicators.Children.Add(ProgressIndicatorInstance10);
            Indicators.Children.Add(ProgressIndicatorInstance11);
        }
        private void ApplyDefaultVariables()
        {
            this.Background.SourceFile = "retro-70s-UI.bmp";
            this.Background.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Background.TextureHeight = 96;
            this.Background.TextureLeft = 128;
            this.Background.TextureTop = 112;
            this.Background.TextureWidth = 16;

            this.Indicators.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.Indicators.ContainedType = "ProgressIndicator";
            this.Indicators.Height = 0f;
            this.Indicators.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Indicators.StackSpacing = 2f;
            this.Indicators.Width = 100f;
            this.Indicators.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.Indicators.Y = -1f;
            this.Indicators.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Indicators.YUnits = GeneralUnitType.PixelsFromLarge;

            this.ProgressIndicatorInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance1.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance1.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance2.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance2.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance3.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance3.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance4.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance4.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance5.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance5.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance6.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance6.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance7.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance7.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance8.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance8.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance9.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance9.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance10.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance10.XUnits = GeneralUnitType.PixelsFromMiddle;

            this.ProgressIndicatorInstance11.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ProgressIndicatorInstance11.XUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
