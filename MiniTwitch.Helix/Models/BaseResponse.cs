﻿using System.Text.Json.Serialization;

namespace MiniTwitch.Helix.Models;

public abstract class BaseResponse<T>
{
    public required IReadOnlyList<T> Data { get; init; }
}
