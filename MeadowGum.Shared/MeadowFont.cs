using System;

namespace MeadowGum.Shared;

public enum MeadowFont
{
    Unspecified = 0,
    Font8X12 = 1,
    Font12X16 = 2,
}

public static class MeadowFontExtensions
{
    public static int WidthPerCharacter(this MeadowFont font)
    {
        switch (font)
        {
            case MeadowFont.Font8X12: return 8;
            case MeadowFont.Font12X16: return 12;
            case MeadowFont.Unspecified:
            default:
                throw new NotSupportedException(font.ToString());
        }
    }

    public static int HeightPerCharacter(this MeadowFont font)
    {
        switch (font)
        {
            case MeadowFont.Font8X12: return 12;
            case MeadowFont.Font12X16: return 16; 
            case MeadowFont.Unspecified:
            default:
                throw new NotSupportedException(font.ToString());
        }
    }
}