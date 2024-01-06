using Gum.Wireframe;
using RenderingLibrary;

namespace MeadowGum.ScratchPad.Common.Components
{
    partial class HoverRuntime : GraphicalUiElement
    {
        private const int Margin = 3;
        
        private GraphicalUiElement? _attachedElement;
        
        partial void CustomInitialize()
        {
        
        }
        
        public void AttachTo(GraphicalUiElement element)
        {
            _attachedElement = element;
            Visible = true;

            Width = _attachedElement.GetAbsoluteWidth() + Margin * 2;
            Height = _attachedElement.GetAbsoluteHeight() + Margin * 2;
            X = _attachedElement.GetAbsoluteLeft() - Margin;
            Y = _attachedElement.GetAbsoluteTop() - Margin;
        }

        public void Detach()
        {
            _attachedElement = null;
            Visible = false;
        }
    }
}
