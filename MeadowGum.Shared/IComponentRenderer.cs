namespace MeadowGum.Shared
{
    public interface IComponentRenderer
    {
        void RenderRectangle(int x, int y, int width, int height, byte red, byte green, byte blue);
        void Show();
    }
}