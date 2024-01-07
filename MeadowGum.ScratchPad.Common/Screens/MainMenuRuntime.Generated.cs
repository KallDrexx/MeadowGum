//Code for MainMenu
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
    public partial class MainMenuRuntime
    {
        public BackgroundRuntime BackgroundInstance { get; protected set; }
        public ContainerRuntime ButtonContainer { get; protected set; }
        public SpriteButtonRuntime ControlsDemoScreenButton { get; protected set; }
        public SpriteButtonRuntime ThermostatButton { get; protected set; }
        public SpriteButtonRuntime SensorsScreenButton { get; protected set; }
        public ScreenLabelRuntime ScreenLabelInstance { get; protected set; }
        public SpriteButtonRuntime KeyboardDemoButton { get; protected set; }

        public string ButtonText
        {
            get => ControlsDemoScreenButton.ButtonText;
            set => ControlsDemoScreenButton.ButtonText = value;
        }

        public MainMenuRuntime(bool fullInstantiation = true)
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
            ButtonContainer = new ContainerRuntime();
            ButtonContainer.Name = "ButtonContainer";
            ControlsDemoScreenButton = new SpriteButtonRuntime();
            ControlsDemoScreenButton.Name = "ControlsDemoScreenButton";
            ThermostatButton = new SpriteButtonRuntime();
            ThermostatButton.Name = "ThermostatButton";
            SensorsScreenButton = new SpriteButtonRuntime();
            SensorsScreenButton.Name = "SensorsScreenButton";
            ScreenLabelInstance = new ScreenLabelRuntime();
            ScreenLabelInstance.Name = "ScreenLabelInstance";
            KeyboardDemoButton = new SpriteButtonRuntime();
            KeyboardDemoButton.Name = "KeyboardDemoButton";
        }
        protected virtual void AssignParents()
        {
            this.WhatThisContains.Add(BackgroundInstance);
            this.WhatThisContains.Add(ButtonContainer);
            ButtonContainer.Children.Add(ControlsDemoScreenButton);
            ButtonContainer.Children.Add(ThermostatButton);
            ButtonContainer.Children.Add(SensorsScreenButton);
            this.WhatThisContains.Add(ScreenLabelInstance);
            ButtonContainer.Children.Add(KeyboardDemoButton);
        }
        private void ApplyDefaultVariables()
        {
            this.BackgroundInstance.X = 0f;

            this.ButtonContainer.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.ButtonContainer.Height = 0f;
            this.ButtonContainer.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ButtonContainer.StackSpacing = 10f;
            this.ButtonContainer.Width = 0f;
            this.ButtonContainer.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ButtonContainer.X = -5f;
            this.ButtonContainer.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ButtonContainer.XUnits = GeneralUnitType.PixelsFromLarge;
            this.ButtonContainer.Y = -5f;
            this.ButtonContainer.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.ButtonContainer.YUnits = GeneralUnitType.PixelsFromLarge;

            this.ControlsDemoScreenButton.ButtonText = "Controls Demo";
            this.ControlsDemoScreenButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ControlsDemoScreenButton.XUnits = GeneralUnitType.PixelsFromLarge;
            this.ControlsDemoScreenButton.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;

            this.ThermostatButton.ButtonText = "Thermostat";
            this.ThermostatButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.ThermostatButton.XUnits = GeneralUnitType.PixelsFromLarge;

            this.SensorsScreenButton.ButtonText = "Sensors Demo Screen";
            this.SensorsScreenButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.SensorsScreenButton.XUnits = GeneralUnitType.PixelsFromLarge;

            this.ScreenLabelInstance.Text = "Main Menu";

            this.KeyboardDemoButton.ButtonText = "Keyboard Demo";
            this.KeyboardDemoButton.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Right;
            this.KeyboardDemoButton.XUnits = GeneralUnitType.PixelsFromLarge;
            this.KeyboardDemoButton.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Bottom;
            this.KeyboardDemoButton.YUnits = GeneralUnitType.PixelsFromLarge;

        }
        partial void CustomInitialize();
    }
}
