using MeadowGum.Core;
using Microgpu.Common;

namespace MeadowGum.Renderer.Microgpu;

internal static class Extensions
{
    public static ColorRgb565 ToColorRgb565(this RgbColor color)
    {
        return ColorRgb565.FromRgb888(color.Red, color.Green, color.Blue);
    }

    public static Font ToGpuFontId(this MeadowFont font)
    {
        return font switch
        {
            MeadowFont.Font8X12 => Font.Font8X12,
            MeadowFont.Font12X16 => Font.Font12X16,
            _ => 0
        };
    }
}