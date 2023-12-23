//Code for SplashScreen (Container)
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
    public partial class SplashScreenRuntime
    {
        public ColoredRectangleRuntime Background { get; protected set; }
        public TextRuntime Title { get; protected set; }
        public TextRuntime Description { get; protected set; }
        public TextRuntime Instruction { get; protected set; }

        public string DescriptionText
        {
            get => Description.Text;
            set => Description.Text = value;
        }

        public string TitleText
        {
            get => Title.Text;
            set => Title.Text = value;
        }

        public SplashScreenRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                this.Height = 100f;
                this.HeightUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
                 
                this.Width = 100f;
                this.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;

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
            Title = new TextRuntime();
            Title.Name = "Title";
            Description = new TextRuntime();
            Description.Name = "Description";
            Instruction = new TextRuntime();
            Instruction.Name = "Instruction";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(Background);
            this.Children.Add(Title);
            this.Children.Add(Description);
            this.Children.Add(Instruction);
        }
        private void ApplyDefaultVariables()
        {
            this.Background.Blue = 0;
            this.Background.Green = 0;
            this.Background.Height = 0f;
            this.Background.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Background.Red = 0;
            this.Background.Width = 0f;
            this.Background.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.Background.X = 0f;
            this.Background.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Background.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Background.Y = 0f;
            this.Background.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Background.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Title.Height = 25f;
            this.Title.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Title.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Title.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.Title.X = 0f;
            this.Title.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Title.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Title.Y = 0f;
            this.Title.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Title.YUnits = GeneralUnitType.PixelsFromSmall;

            this.Description.Height = 100f;
            this.Description.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Description.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Description.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.Description.X = 0f;
            this.Description.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Description.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Description.Y = 0f;
            this.Description.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Description.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Instruction.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Instruction.Text = "Press 'up' to continue";
            this.Instruction.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Instruction.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.Instruction.X = 0f;
            this.Instruction.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.Instruction.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.Instruction.Y = 0f;
            this.Instruction.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Instruction.YUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
