using MeadowGum.Shared.Components;


namespace MeadowGum.ScratchPad.Common.Components
{
    partial class SimpleButtonRuntime : MeadowGumComponent
    {
        public bool IsSelected => SelectionState == Selection.Selected;
        
        partial void CustomInitialize()
        {
            SelectionState = Selection.Unselected;
        }

        public void Select()
        {
            SelectionState = Selection.Selected;
        }

        public void Unselect()
        {
            SelectionState = Selection.Unselected;
        }
    }
}
