// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace DataProtection.Models
{
    public partial class UpdateProtectionStatus
    {
        internal static UpdateProtectionStatus DeserializeUpdateProtectionStatus(JsonElement element)
        {
            Optional<IReadOnlyDictionary<string, string>> additionalProperties = default;
            Optional<string> telemetryData = default;
            Optional<int> retryAfterOnRetryableErrorInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalProperties = dictionary;
                    continue;
                }
                if (property.NameEquals("telemetryData"))
                {
                    telemetryData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retryAfterOnRetryableErrorInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retryAfterOnRetryableErrorInSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new UpdateProtectionStatus(Optional.ToDictionary(additionalProperties), telemetryData.Value, Optional.ToNullable(retryAfterOnRetryableErrorInSeconds));
        }
    }
}
