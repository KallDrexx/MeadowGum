using Gum.Wireframe;

namespace MeadowGum.ScratchPad.Common.Components
{
    partial class SpriteButtonRuntime : GraphicalUiElement
    {
        partial void CustomInitialize()
        {
            SelectionState = Selection.Deselected;
        }

        public void Select()
        {
            if (this.SelectionState == Selection.Deselected)
            {
                this.SelectionState = Selection.Selected;
            }
        }
        
        public void Deselect()
        {
            if (this.SelectionState == Selection.Selected)
            {
                this.SelectionState = Selection.Deselected;
            }
        }
    }
}
