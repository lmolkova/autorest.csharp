// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    public partial class PatchSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PatchMode))
            {
                writer.WritePropertyName("patchMode");
                writer.WriteStringValue(PatchMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static PatchSettings DeserializePatchSettings(JsonElement element)
        {
            Optional<InGuestPatchMode> patchMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    patchMode = new InGuestPatchMode(property.Value.GetString());
                    continue;
                }
            }
            return new PatchSettings(Optional.ToNullable(patchMode));
        }
    }
}