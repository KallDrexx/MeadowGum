//Code for SplashScreen
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
    public partial class SplashScreenRuntime
    {
        public BackgroundRuntime BackgroundInstance { get; protected set; }
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
            BackgroundInstance = new BackgroundRuntime();
            BackgroundInstance.Name = "BackgroundInstance";
            Title = new TextRuntime();
            Title.Name = "Title";
            Description = new TextRuntime();
            Description.Name = "Description";
            Instruction = new TextRuntime();
            Instruction.Name = "Instruction";
        }
        protected virtual void AssignParents()
        {
            this.WhatThisContains.Add(BackgroundInstance);
            this.WhatThisContains.Add(Title);
            this.WhatThisContains.Add(Description);
            this.WhatThisContains.Add(Instruction);
        }
        private void ApplyDefaultVariables()
        {

            this.Title.Blue = 106;
            this.Title.Green = 116;
            this.Title.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Title.Red = 81;
            this.Title.Text = "Title";
            this.Title.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Title.X = -10f;
            this.Title.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Title.XUnits = GeneralUnitType.PixelsFromLarge;
            this.Title.Y = 10f;
            this.Title.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Title.YUnits = GeneralUnitType.PixelsFromSmall;

            this.Description.Blue = 106;
            this.Description.Green = 116;
            this.Description.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Description.Red = 81;
            this.Description.Text = "Description";
            this.Description.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Description.Width = 65f;
            this.Description.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.Description.X = -10f;
            this.Description.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Description.XUnits = GeneralUnitType.PixelsFromLarge;
            this.Description.Y = 0f;
            this.Description.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Description.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.Instruction.Blue = 106;
            this.Instruction.Green = 116;
            this.Instruction.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Instruction.Red = 86;
            this.Instruction.Text = "Press 'up' to continue...";
            this.Instruction.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Instruction.Width = 65f;
            this.Instruction.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.Instruction.X = -10f;
            this.Instruction.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.Instruction.XUnits = GeneralUnitType.PixelsFromLarge;
            this.Instruction.Y = -10f;
            this.Instruction.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.Instruction.YUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
