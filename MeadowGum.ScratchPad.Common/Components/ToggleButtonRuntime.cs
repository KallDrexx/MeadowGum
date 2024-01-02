using System;
using Gum.Wireframe;

namespace MeadowGum.ScratchPad.Common.Components
{
    partial class ToggleButtonRuntime : GraphicalUiElement
    {
        public Action<bool>? OnToggleChanged { get; set; }
        
        partial void CustomInitialize()
        {
            ToggleState = Toggle.Off;
        }
        
        public void SetToggle()
        {
            if (ToggleState == Toggle.Off)
            {
                ToggleState = Toggle.On;
            }
            else
            {
                ToggleState = Toggle.Off;
            }
            
            OnToggleChanged?.Invoke(ToggleState == Toggle.On);
        }
    }
}
