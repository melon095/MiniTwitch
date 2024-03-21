using System.Text.Json.Serialization;
using MiniTwitch.Helix.Models;

namespace MiniTwitch.Helix.Responses;

public class Emotes : BaseResponse<Emotes.Emote>
{
    [JsonPropertyName("template")]
    public string Template { get; init; }

    public record Emote(
        string Id,
        string Name,
        Images Images,
        string Tier,
        string EmoteType,
        string EmoteSetId,
        [property: JsonPropertyName("format")] IReadOnlyList<string> Formats,
        [property: JsonPropertyName("scale")] IReadOnlyList<string> Scales,
        [property: JsonPropertyName("theme_mode")] IReadOnlyList<string> ThemeModes
    );

    public record Images(
        [property: JsonPropertyName("url_1x")] string Url1x,
        [property: JsonPropertyName("url_2x")] string Url2x,
        [property: JsonPropertyName("url_4x")] string Url4x
    );
}