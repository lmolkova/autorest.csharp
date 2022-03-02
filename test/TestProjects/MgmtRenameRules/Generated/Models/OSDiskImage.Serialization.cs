// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    internal partial class OSDiskImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operatingSystem");
            writer.WriteStringValue(OperatingSystem.ToSerialString());
            writer.WriteEndObject();
        }

        internal static OSDiskImage DeserializeOSDiskImage(JsonElement element)
        {
            OperatingSystemTypes operatingSystem = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operatingSystem"))
                {
                    operatingSystem = property.Value.GetString().ToOperatingSystemTypes();
                    continue;
                }
            }
            return new OSDiskImage(operatingSystem);
        }
    }
}
