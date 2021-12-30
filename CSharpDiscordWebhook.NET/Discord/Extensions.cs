using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace CSharpDiscordWebhook.NET.Discord;

public static class Extensions
{
    public static int? ToHex(this Color? color)
    {
        string HS =
            color?.R.ToString("X2") +
            color?.G.ToString("X2") +
            color?.B.ToString("X2");

        if (int.TryParse(HS, System.Globalization.NumberStyles.HexNumber, null, out int hex))
            return hex;
        
        return null;
    }

    public static Color? ToColor(this int? hex)
    {
        if (hex == null)
            return null;

        return ColorTranslator.FromHtml(hex?.ToString("X6"));
    }

    public static async Task<string> Decode(this Stream source)
    {
        using var reader = new StreamReader(source);
        return await reader.ReadToEndAsync();
    }
}