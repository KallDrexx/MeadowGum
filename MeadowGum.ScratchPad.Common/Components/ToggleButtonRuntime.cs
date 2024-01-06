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
        
        public void SwapToggleState()
        {
            ToggleState = ToggleState == Toggle.Off 
                ? Toggle.On 
                : Toggle.Off;

            OnToggleChanged?.Invoke(ToggleState == Toggle.On);
        }
        
        public bool IsOn => ToggleState == Toggle.On;
    }
}
