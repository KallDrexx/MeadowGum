using RenderingLibrary.Graphics;

namespace MeadowGum.Shared
{
    public interface IComponentRenderer
    {
        void RenderRectangle(int x, int y, int width, int height, byte red, byte green, byte blue);
        void RenderText(int x, 
            int y, 
            MeadowFont font, 
            HorizontalAlignment horizontalAlignment, 
            VerticalAlignment verticalAlignment,  
            string text, 
            byte red, 
            byte green, 
            byte blue);
        
        void Show();
    }
}