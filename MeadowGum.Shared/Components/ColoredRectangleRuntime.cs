using System;
using RenderingLibrary;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components
{
    public class ColoredRectangleRuntime : MeadowGumComponent
    {
        public byte Red { get; set; } = 255;
        public byte Green { get; set; } = 255;
        public byte Blue { get; set; } = 255;
        
        public ColoredRectangleRuntime() 
        {
            SetContainedObject(new InvisibleRenderable { Visible = true });
        }

        public override void Render(ISystemManagers managers)
        {
            if (DefaultRenderer == null)
            {
                const string message = "No default renderer set yet";
                throw new InvalidOperationException(message);
            }
            
            DefaultRenderer.RenderRectangle(
                (int)this.GetAbsoluteLeft(),
                (int)this.GetAbsoluteTop(),
                (int)GetAbsoluteWidth(), 
                (int)GetAbsoluteHeight(), 
                Red, 
                Green, 
                Blue);
        }
    }
}