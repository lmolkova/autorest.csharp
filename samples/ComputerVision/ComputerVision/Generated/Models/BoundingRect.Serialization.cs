// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ComputerVision.Models
{
    public partial class BoundingRect
    {
        internal static BoundingRect DeserializeBoundingRect(JsonElement element)
        {
            Optional<int> x = default;
            Optional<int> y = default;
            Optional<int> w = default;
            Optional<int> h = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x"))
                {
                    x = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("y"))
                {
                    y = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("w"))
                {
                    w = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("h"))
                {
                    h = property.Value.GetInt32();
                    continue;
                }
            }
            return new BoundingRect(Optional.ToNullable(x), Optional.ToNullable(y), Optional.ToNullable(w), Optional.ToNullable(h));
        }
    }
}
