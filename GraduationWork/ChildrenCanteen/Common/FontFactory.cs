namespace ChildrenCanteen.Common
{
    using System.Drawing;

    public static class FontFactory
    {
        public static Font GetFont(CommonFonts font, int fontSize = 24)
        {
            switch (font)
            {
                case CommonFonts.DefauldGeorgia:
                    return new Font("Georgia", fontSize, FontStyle.Regular);
                default: return new Font("Georgia", 12, FontStyle.Regular);
            }
        }
    }
}
