using Gum.Wireframe;
using RenderingLibrary;

namespace MeadowGum.ScratchPad.Common.Components
{
    partial class HoverRuntime : GraphicalUiElement
    {
        private GraphicalUiElement? _attachedElement;
        
        partial void CustomInitialize()
        {
        
        }
        
        public void AttachTo(GraphicalUiElement element)
        {
            _attachedElement = element;
            Visible = true;

            Width = _attachedElement.GetAbsoluteWidth();
            Height = _attachedElement.GetAbsoluteHeight();
            X = _attachedElement.GetAbsoluteLeft();
            Y = _attachedElement.GetAbsoluteTop();
        }

        public void Detach()
        {
            _attachedElement = null;
            Visible = false;
        }
    }
}
