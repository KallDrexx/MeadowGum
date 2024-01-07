//Code for KeyboardScreen
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
    public partial class KeyboardScreenRuntime
    {
        public BackgroundRuntime BackgroundInstance { get; protected set; }
        public ScreenLabelRuntime ScreenLabelInstance { get; protected set; }
        public PanelRuntime PanelInstance { get; protected set; }
        public TextRuntime TypedTextDisplay { get; protected set; }
        public ContainerRuntime KeyCapArea { get; protected set; }
        public KeyCapRuntime KeyCap1 { get; protected set; }
        public KeyCapRuntime KeyCap2 { get; protected set; }
        public KeyCapRuntime KeyCap3 { get; protected set; }
        public KeyCapRuntime KeyCap4 { get; protected set; }
        public KeyCapRuntime KeyCap5 { get; protected set; }
        public KeyCapRuntime KeyCap6 { get; protected set; }
        public KeyCapRuntime KeyCap7 { get; protected set; }
        public KeyCapRuntime KeyCap8 { get; protected set; }
        public KeyCapRuntime KeyCap9 { get; protected set; }
        public KeyCapRuntime KeyCap10 { get; protected set; }
        public KeyCapRuntime KeyCap11 { get; protected set; }
        public KeyCapRuntime KeyCap12 { get; protected set; }
        public KeyCapRuntime KeyCap13 { get; protected set; }
        public KeyCapRuntime KeyCap14 { get; protected set; }
        public KeyCapRuntime KeyCap15 { get; protected set; }
        public KeyCapRuntime KeyCap16 { get; protected set; }
        public KeyCapRuntime KeyCap17 { get; protected set; }
        public KeyCapRuntime KeyCap18 { get; protected set; }
        public KeyCapRuntime KeyCap19 { get; protected set; }
        public KeyCapRuntime KeyCap20 { get; protected set; }
        public KeyCapRuntime KeyCap21 { get; protected set; }
        public KeyCapRuntime KeyCap22 { get; protected set; }
        public KeyCapRuntime KeyCap23 { get; protected set; }
        public KeyCapRuntime KeyCap24 { get; protected set; }
        public KeyCapRuntime KeyCap25 { get; protected set; }
        public KeyCapRuntime KeyCap26 { get; protected set; }
        public KeyCapRuntime KeyCap27 { get; protected set; }
        public KeyCapRuntime KeyCap28 { get; protected set; }

        public KeyboardScreenRuntime(bool fullInstantiation = true)
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
            ScreenLabelInstance = new ScreenLabelRuntime();
            ScreenLabelInstance.Name = "ScreenLabelInstance";
            PanelInstance = new PanelRuntime();
            PanelInstance.Name = "PanelInstance";
            TypedTextDisplay = new TextRuntime();
            TypedTextDisplay.Name = "TypedTextDisplay";
            KeyCapArea = new ContainerRuntime();
            KeyCapArea.Name = "KeyCapArea";
            KeyCap1 = new KeyCapRuntime();
            KeyCap1.Name = "KeyCap1";
            KeyCap2 = new KeyCapRuntime();
            KeyCap2.Name = "KeyCap2";
            KeyCap3 = new KeyCapRuntime();
            KeyCap3.Name = "KeyCap3";
            KeyCap4 = new KeyCapRuntime();
            KeyCap4.Name = "KeyCap4";
            KeyCap5 = new KeyCapRuntime();
            KeyCap5.Name = "KeyCap5";
            KeyCap6 = new KeyCapRuntime();
            KeyCap6.Name = "KeyCap6";
            KeyCap7 = new KeyCapRuntime();
            KeyCap7.Name = "KeyCap7";
            KeyCap8 = new KeyCapRuntime();
            KeyCap8.Name = "KeyCap8";
            KeyCap9 = new KeyCapRuntime();
            KeyCap9.Name = "KeyCap9";
            KeyCap10 = new KeyCapRuntime();
            KeyCap10.Name = "KeyCap10";
            KeyCap11 = new KeyCapRuntime();
            KeyCap11.Name = "KeyCap11";
            KeyCap12 = new KeyCapRuntime();
            KeyCap12.Name = "KeyCap12";
            KeyCap13 = new KeyCapRuntime();
            KeyCap13.Name = "KeyCap13";
            KeyCap14 = new KeyCapRuntime();
            KeyCap14.Name = "KeyCap14";
            KeyCap15 = new KeyCapRuntime();
            KeyCap15.Name = "KeyCap15";
            KeyCap16 = new KeyCapRuntime();
            KeyCap16.Name = "KeyCap16";
            KeyCap17 = new KeyCapRuntime();
            KeyCap17.Name = "KeyCap17";
            KeyCap18 = new KeyCapRuntime();
            KeyCap18.Name = "KeyCap18";
            KeyCap19 = new KeyCapRuntime();
            KeyCap19.Name = "KeyCap19";
            KeyCap20 = new KeyCapRuntime();
            KeyCap20.Name = "KeyCap20";
            KeyCap21 = new KeyCapRuntime();
            KeyCap21.Name = "KeyCap21";
            KeyCap22 = new KeyCapRuntime();
            KeyCap22.Name = "KeyCap22";
            KeyCap23 = new KeyCapRuntime();
            KeyCap23.Name = "KeyCap23";
            KeyCap24 = new KeyCapRuntime();
            KeyCap24.Name = "KeyCap24";
            KeyCap25 = new KeyCapRuntime();
            KeyCap25.Name = "KeyCap25";
            KeyCap26 = new KeyCapRuntime();
            KeyCap26.Name = "KeyCap26";
            KeyCap27 = new KeyCapRuntime();
            KeyCap27.Name = "KeyCap27";
            KeyCap28 = new KeyCapRuntime();
            KeyCap28.Name = "KeyCap28";
        }
        protected virtual void AssignParents()
        {
            this.WhatThisContains.Add(BackgroundInstance);
            this.WhatThisContains.Add(ScreenLabelInstance);
            this.WhatThisContains.Add(PanelInstance);
            PanelInstance.Children.Add(TypedTextDisplay);
            PanelInstance.Children.Add(KeyCapArea);
            KeyCapArea.Children.Add(KeyCap1);
            KeyCapArea.Children.Add(KeyCap2);
            KeyCapArea.Children.Add(KeyCap3);
            KeyCapArea.Children.Add(KeyCap4);
            KeyCapArea.Children.Add(KeyCap5);
            KeyCapArea.Children.Add(KeyCap6);
            KeyCapArea.Children.Add(KeyCap7);
            KeyCapArea.Children.Add(KeyCap8);
            KeyCapArea.Children.Add(KeyCap9);
            KeyCapArea.Children.Add(KeyCap10);
            KeyCapArea.Children.Add(KeyCap11);
            KeyCapArea.Children.Add(KeyCap12);
            KeyCapArea.Children.Add(KeyCap13);
            KeyCapArea.Children.Add(KeyCap14);
            KeyCapArea.Children.Add(KeyCap15);
            KeyCapArea.Children.Add(KeyCap16);
            KeyCapArea.Children.Add(KeyCap17);
            KeyCapArea.Children.Add(KeyCap18);
            KeyCapArea.Children.Add(KeyCap19);
            KeyCapArea.Children.Add(KeyCap20);
            KeyCapArea.Children.Add(KeyCap21);
            KeyCapArea.Children.Add(KeyCap22);
            KeyCapArea.Children.Add(KeyCap23);
            KeyCapArea.Children.Add(KeyCap24);
            KeyCapArea.Children.Add(KeyCap25);
            KeyCapArea.Children.Add(KeyCap26);
            KeyCapArea.Children.Add(KeyCap27);
            KeyCapArea.Children.Add(KeyCap28);
        }
        private void ApplyDefaultVariables()
        {

            this.ScreenLabelInstance.Text = "Keyboard Demo";

            this.PanelInstance.Height = 180f;
            this.PanelInstance.Width = 95f;
            this.PanelInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.PanelInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.PanelInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.PanelInstance.Y = 15f;
            this.PanelInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.PanelInstance.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.TypedTextDisplay.Blue = 106;
            this.TypedTextDisplay.Green = 116;
            this.TypedTextDisplay.Height = 0f;
            this.TypedTextDisplay.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TypedTextDisplay.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TypedTextDisplay.Red = 81;
            this.TypedTextDisplay.Text = "_";
            this.TypedTextDisplay.Width = 0f;
            this.TypedTextDisplay.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.TypedTextDisplay.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.TypedTextDisplay.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.TypedTextDisplay.Y = 5f;

            this.KeyCapArea.AutoGridHorizontalCells = 8;
            this.KeyCapArea.ChildrenLayout = global::Gum.Managers.ChildrenLayout.AutoGridHorizontal;
            this.KeyCapArea.Height = 120f;
            this.KeyCapArea.StackSpacing = 3f;
            this.KeyCapArea.Width = 90f;
            this.KeyCapArea.WidthUnits = global::Gum.DataTypes.DimensionUnitType.Percentage;
            this.KeyCapArea.WrapsChildren = true;
            this.KeyCapArea.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.KeyCapArea.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.KeyCapArea.Y = 20f;
            this.KeyCapArea.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.KeyCapArea.YUnits = GeneralUnitType.PixelsFromMiddle;

            this.KeyCap1.KeyText = "A";

            this.KeyCap2.KeyText = "B";

            this.KeyCap3.KeyText = "C";

            this.KeyCap4.KeyText = "D";

            this.KeyCap5.KeyText = "E";

            this.KeyCap6.KeyText = "F";

            this.KeyCap7.KeyText = "G";

            this.KeyCap8.KeyText = "Del";

            this.KeyCap9.KeyText = "H";

            this.KeyCap10.KeyText = "I";

            this.KeyCap11.KeyText = "J";

            this.KeyCap12.KeyText = "K";

            this.KeyCap13.KeyText = "L";

            this.KeyCap14.KeyText = "M";

            this.KeyCap15.KeyText = "N";

            this.KeyCap16.KeyText = "O";

            this.KeyCap17.KeyText = "P";

            this.KeyCap18.KeyText = "Q";

            this.KeyCap19.KeyText = "R";

            this.KeyCap20.KeyText = "S";

            this.KeyCap21.KeyText = "T";

            this.KeyCap22.KeyText = "U";

            this.KeyCap23.KeyText = "V";

            this.KeyCap24.KeyText = "W";

            this.KeyCap25.KeyText = "X";

            this.KeyCap26.KeyText = "Y";

            this.KeyCap27.KeyText = "Z";

            this.KeyCap28.KeyText = "Quit";

        }
        partial void CustomInitialize();
    }
}
