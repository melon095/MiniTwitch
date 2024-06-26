﻿using System.Text.Json.Serialization;
using MiniTwitch.Helix.Internal.Json;

namespace MiniTwitch.Helix.Requests;

public readonly struct ExtensionPubSubMessage
{
    public required IEnumerable<string> Target { get; init; }

    [JsonConverter(typeof(LongConverter))]
    public required long BroadcasterId { get; init; }

    public required string Message { get; init; }

    public bool? IsGlobalBroadcast { get; init; }
}
