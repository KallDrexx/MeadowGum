//Code for ToggleButton (Container)
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
    public partial class ToggleButtonRuntime
    {
        public enum Toggle
        {
            Off,
            On,
        }

        Toggle mToggleState;
        public Toggle ToggleState
        {
            get => mToggleState;
            set
            {
                mToggleState = value;
                var appliedDynamically = false;
                if(!appliedDynamically)
                {
                    switch (value)
                    {
                        case Toggle.Off:
                            this.Sprite.TextureHeight = 16;
                            this.Sprite.TextureLeft = 64;
                            this.Sprite.TextureTop = 64;
                            this.Sprite.TextureWidth = 32;
                            break;
                        case Toggle.On:
                            this.Sprite.TextureHeight = 16;
                            this.Sprite.TextureLeft = 64;
                            this.Sprite.TextureTop = 80;
                            this.Sprite.TextureWidth = 32;
                            break;
                    }
                }
            }
        }
        public SpriteRuntime Sprite { get; protected set; }
        public ContainerRuntime ContainerInstance { get; protected set; }
        public TextRuntime Label { get; protected set; }

        public string LabelText
        {
            get => Label.Text;
            set => Label.Text = value;
        }

        public ToggleButtonRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                this.ChildrenLayout = global::Gum.Managers.ChildrenLayout.Regular;
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
            Sprite = new SpriteRuntime();
            Sprite.Name = "Sprite";
            ContainerInstance = new ContainerRuntime();
            ContainerInstance.Name = "ContainerInstance";
            Label = new TextRuntime();
            Label.Name = "Label";
        }
        protected virtual void AssignParents()
        {
            ContainerInstance.Children.Add(Sprite);
            this.Children.Add(ContainerInstance);
            ContainerInstance.Children.Add(Label);
        }
        private void ApplyDefaultVariables()
        {
            this.Sprite.SourceFile = "retro-70s-UI.bmp";
            this.Sprite.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Sprite.TextureHeight = 16;
            this.Sprite.TextureLeft = 64;
            this.Sprite.TextureTop = 64;
            this.Sprite.TextureWidth = 32;

            this.ContainerInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.LeftToRightStack;
            this.ContainerInstance.Height = 0f;
            this.ContainerInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ContainerInstance.Width = 0f;
            this.ContainerInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.Label.Blue = 0;
            this.Label.Green = 0;
            this.Label.Height = 0f;
            this.Label.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.Red = 0;
            this.Label.Text = "Label";
            this.Label.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Label.Width = 0f;
            this.Label.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.X = 5f;
            this.Label.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Label.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.Label.YUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
