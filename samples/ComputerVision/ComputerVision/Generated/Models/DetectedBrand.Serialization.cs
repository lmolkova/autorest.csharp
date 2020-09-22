// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ComputerVision.Models
{
    public partial class DetectedBrand
    {
        internal static DetectedBrand DeserializeDetectedBrand(JsonElement element)
        {
            Optional<string> name = default;
            Optional<double> confidence = default;
            Optional<BoundingRect> rectangle = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    confidence = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("rectangle"))
                {
                    rectangle = BoundingRect.DeserializeBoundingRect(property.Value);
                    continue;
                }
            }
            return new DetectedBrand(name.Value, Optional.ToNullable(confidence), rectangle.Value);
        }
    }
}
