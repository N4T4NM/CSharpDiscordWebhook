using System.Drawing;

namespace Discord.Utils
{
    public class DiscordConverter
    {
        public static int ColorToHex(Color SourceColor)
        {
            string HexString = SourceColor.R.ToString("X2") + 
                SourceColor.G.ToString("X2") + 
                SourceColor.B.ToString("X2");

            return int.Parse(HexString, System.Globalization.NumberStyles.HexNumber); 
        }
    }
}
