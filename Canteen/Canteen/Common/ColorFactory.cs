namespace Canteen.Common
{
    using System.Drawing;

    public static class ColorFactory
    {
        public static Color GetColor(CommonColors color)
        {
            switch (color)
            {
                case CommonColors.BackgroundGrey:
                    return Color.FromArgb(255, 227, 227, 227);
                case CommonColors.DarkGrey:
                    return Color.FromArgb(255, 57, 70, 76);
                case CommonColors.GreyFontColor:
                    return Color.FromArgb(255, 47, 56, 61);
                default:
                    return Color.FromArgb(50, 1, 156, 217);
            }
        }
    }
}
