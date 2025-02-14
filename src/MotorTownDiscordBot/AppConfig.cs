﻿using System.Text.Json.Serialization;

public class EmbedConfig
{
    [JsonPropertyName("title_template")]
    public string? TitleFormat { get; set; }

    [JsonPropertyName("description_template")]
    public string? DescriptionFormat { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailURL { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }
}

public class MessageConfig
{
    [JsonPropertyName("text_template")]
    public string? TextFormat { get; set; }

    [JsonPropertyName("embed_settings")]
    public EmbedConfig? EmbedConfig { get; set; }

    [JsonPropertyName("channel_id")]
    public ulong ChannelId { get; set; }

}

public class MessagesConfig
{

    [JsonPropertyName("chat")]
    public MessageConfig? ChatMessageConfig { get; set; }

    [JsonPropertyName("login")]
    public MessageConfig? LoginMessageConfig { get; set; }

    [JsonPropertyName("logout")]
    public MessageConfig? LogoutMessageConfig { get; set; }

    [JsonPropertyName("ban")]
    public MessageConfig? BanMessageConfig { get; set; }
}

public class AppConfig
{
    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("discord_token")]
    public string Token { get; set; }

    [JsonPropertyName("message_settings")]
    public MessagesConfig? MessagesConfig { get; set; }


    [JsonPropertyName("admin_mention")]
    public AdminMentionConfig? AdminMentionConfig { get; set; }


}

public class AdminMentionConfig
{
    [JsonPropertyName("keyword")]
    public string Keyword { get; set; }

    [JsonPropertyName("discord_id")]
    public string DiscordID { get; set; }
}