//Code for LabelValueItem (Container)
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
    public partial class LabelValueItemRuntime
    {
        public TextRuntime LabelInstance { get; protected set; }
        public TextRuntime ValueInstance { get; protected set; }

        public string LabelText
        {
            get => LabelInstance.Text;
            set => LabelInstance.Text = value;
        }

        public string ValueText
        {
            get => ValueInstance.Text;
            set => ValueInstance.Text = value;
        }

        public LabelValueItemRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {
                this.SetContainedObject(new InvisibleRenderable());

                this.ChildrenLayout = global::Gum.Managers.ChildrenLayout.TopToBottomStack;
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
            LabelInstance = new TextRuntime();
            LabelInstance.Name = "LabelInstance";
            ValueInstance = new TextRuntime();
            ValueInstance.Name = "ValueInstance";
        }
        protected virtual void AssignParents()
        {
            this.Children.Add(LabelInstance);
            this.Children.Add(ValueInstance);
        }
        private void ApplyDefaultVariables()
        {
            this.LabelInstance.Blue = 0;
            this.LabelInstance.Green = 0;
            this.LabelInstance.Height = 0f;
            this.LabelInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.LabelInstance.Red = 0;
            this.LabelInstance.Text = "Label";
            this.LabelInstance.Width = 0f;
            this.LabelInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            this.ValueInstance.Blue = 106;
            this.ValueInstance.Green = 116;
            this.ValueInstance.Height = 0f;
            this.ValueInstance.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ValueInstance.Red = 86;
            this.ValueInstance.Text = "Value";
            this.ValueInstance.Width = 0f;
            this.ValueInstance.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToChildren;
            this.ValueInstance.X = 10f;

        }
        partial void CustomInitialize();
    }
}
