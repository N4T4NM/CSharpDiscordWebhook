using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscordWebhook.NET.Discord;

public static class Extensions
{
    public static byte[] Encode(this string source)
        => Encoding.UTF8.GetBytes(source);
    public static string Decode(this byte[] source)
        => Encoding.UTF8.GetString(source);

    public static async Task WriteAsync(this MemoryStream source, string str)
    {
        byte[] buffer = str.Encode();
        await source.WriteAsync(buffer);
    }

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