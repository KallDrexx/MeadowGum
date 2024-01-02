using System;
using Gum.Wireframe;

namespace MeadowGum.ScratchPad.Common.Components
{
    partial class SpriteButtonRuntime : GraphicalUiElement
    {
        public Action? OnSelected { get; set; }
        public Action? OnDeselected { get; set; }
        
        partial void CustomInitialize()
        {
            SelectionState = Selection.Deselected;
        }

        public void Select()
        {
            if (SelectionState == Selection.Deselected)
            {
                SelectionState = Selection.Selected;
                OnSelected?.Invoke();
            }
        }
        
        public void Deselect()
        {
            if (SelectionState == Selection.Selected)
            {
                SelectionState = Selection.Deselected;
                OnDeselected?.Invoke();
            }
        }
    }
}
