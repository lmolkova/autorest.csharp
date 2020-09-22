// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ComputerVision.Models
{
    public partial class FaceRectangle
    {
        internal static FaceRectangle DeserializeFaceRectangle(JsonElement element)
        {
            Optional<int> left = default;
            Optional<int> top = default;
            Optional<int> width = default;
            Optional<int> height = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("left"))
                {
                    left = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("top"))
                {
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("width"))
                {
                    width = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("height"))
                {
                    height = property.Value.GetInt32();
                    continue;
                }
            }
            return new FaceRectangle(Optional.ToNullable(left), Optional.ToNullable(top), Optional.ToNullable(width), Optional.ToNullable(height));
        }
    }
}
