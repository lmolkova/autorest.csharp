// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ComputerVision.Models
{
    public partial class ColorInfo
    {
        internal static ColorInfo DeserializeColorInfo(JsonElement element)
        {
            Optional<string> dominantColorForeground = default;
            Optional<string> dominantColorBackground = default;
            Optional<IReadOnlyList<string>> dominantColors = default;
            Optional<string> accentColor = default;
            Optional<bool> isBWImg = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dominantColorForeground"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dominantColorForeground = null;
                        continue;
                    }
                    dominantColorForeground = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dominantColorBackground"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dominantColorBackground = null;
                        continue;
                    }
                    dominantColorBackground = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dominantColors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dominantColors = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    dominantColors = array;
                    continue;
                }
                if (property.NameEquals("accentColor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accentColor = null;
                        continue;
                    }
                    accentColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isBWImg"))
                {
                    isBWImg = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ColorInfo(dominantColorForeground.Value, dominantColorBackground.Value, Optional.ToList(dominantColors), accentColor.Value, Optional.ToNullable(isBWImg));
        }
    }
}
