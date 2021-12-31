using System;

namespace CSharpDiscordWebhook.NET.Discord;

public class DiscordException : Exception
{
    public DiscordException()
    {
    }

    public DiscordException(string message)
        : base(message)
    {
    }

    public DiscordException(string message, Exception inner)
        : base(message, inner)
    {
    }
}