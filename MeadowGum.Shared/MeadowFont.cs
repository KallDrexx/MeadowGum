using System;

namespace MeadowGum.Shared;

public enum MeadowFont
{
    Unspecified = 0,
    Font8X12 = 1
}

public static class MeadowFontExtensions
{
    public static int WidthPerCharacter(this MeadowFont font)
    {
        switch (font)
        {
            case MeadowFont.Font8X12: return 8;
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
            case MeadowFont.Unspecified:
            default:
                throw new NotSupportedException(font.ToString());
        }
    }
}