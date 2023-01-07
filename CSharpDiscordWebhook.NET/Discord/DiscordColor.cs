using System.Drawing;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class DiscordColor
    {
        public Color Color { get; set; }

        public DiscordColor(int color) : this(ColorTranslator.FromHtml(color.ToString("X6")))
        {

        }

        public DiscordColor(Color color)
        {
            Color = color;
        }

        public int ToHexRgb()
        {
            string HS =
            Color.R.ToString("X2") +
            Color.G.ToString("X2") +
            Color.B.ToString("X2");

            return int.Parse(HS, System.Globalization.NumberStyles.HexNumber, null);
        }
    }
}
