using System.Drawing;
using System.IO;
using System.Text;

namespace CSharpDiscordWebhook.NET.Discord
{
    public static class Extensions
    {
        public static byte[] Encode(this string source)
            => Encoding.UTF8.GetBytes(source);
        public static string Decode(this byte[] source)
            => Encoding.UTF8.GetString(source);

        public static void Write(this MemoryStream source, string str)
        {
            byte[] buffer = str.Encode();
            source.Write(buffer, 0, buffer.Length);
        }

        public static int? ToHex(this Color? color)
        {
            string HS =
                color?.R.ToString("X2") +
                color?.G.ToString("X2") +
                color?.B.ToString("X2");

            int hex;
            if (int.TryParse(HS, System.Globalization.NumberStyles.HexNumber, null, out hex))
                return hex;
            else return null;
        }

        public static Color? ToColor(this int? hex)
        {
            if (hex == null)
                return null;

            return ColorTranslator.FromHtml(hex?.ToString("X6"));
        }

        public static string Decode(this Stream source)
        {
            using (StreamReader reader = new StreamReader(source))
                return reader.ReadToEnd();
        }
    }
}
