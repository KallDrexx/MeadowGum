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
        public TextRuntime Label { get; protected set; }
        public SpriteRuntime Sprite { get; protected set; }
        public ContainerRuntime ContainerInstance { get; protected set; }

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

                this.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
                this.Height = 0f;
                this.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                 
                this.StackSpacing = 2f;
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
            Label = new TextRuntime();
            Label.Name = "Label";
            Sprite = new SpriteRuntime();
            Sprite.Name = "Sprite";
            ContainerInstance = new ContainerRuntime();
            ContainerInstance.Name = "ContainerInstance";
        }
        protected virtual void AssignParents()
        {
            ContainerInstance.Children.Add(Label);
            ContainerInstance.Children.Add(Sprite);
            this.Children.Add(ContainerInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.Label.Blue = 0;
            this.Label.Green = 0;
            this.Label.Height = 0f;
            this.Label.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.HorizontalAlignment = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Label.Red = 0;
            this.Label.Text = "Label";
            this.Label.VerticalAlignment = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Label.Width = 0f;
            this.Label.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.Label.X = 5f;
            this.Label.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Left;
            this.Label.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Top;
            this.Label.YUnits = GeneralUnitType.PixelsFromSmall;

            this.Sprite.SourceFile = "retro-70s-UI.bmp";
            this.Sprite.TextureAddress = global::Gum.Managers.TextureAddress.Custom;
            this.Sprite.TextureHeight = 16;
            this.Sprite.TextureLeft = 64;
            this.Sprite.TextureTop = 64;
            this.Sprite.TextureWidth = 32;

            this.ContainerInstance.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
            this.ContainerInstance.Height = 3f;
            this.ContainerInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ContainerInstance.Width = 3f;
            this.ContainerInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ContainerInstance.X = 3f;
            this.ContainerInstance.XOrigin = global::RenderingLibrary.Graphics.HorizontalAlignment.Center;
            this.ContainerInstance.XUnits = GeneralUnitType.PixelsFromMiddle;
            this.ContainerInstance.Y = 3f;
            this.ContainerInstance.YOrigin = global::RenderingLibrary.Graphics.VerticalAlignment.Center;
            this.ContainerInstance.YUnits = GeneralUnitType.PixelsFromMiddle;

        }
        partial void CustomInitialize();
    }
}
