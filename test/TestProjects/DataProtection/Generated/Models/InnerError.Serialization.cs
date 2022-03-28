// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace DataProtection.Models
{
    public partial class InnerError
    {
        internal static InnerError DeserializeInnerError(JsonElement element)
        {
            Optional<string> code = default;
            Optional<IReadOnlyDictionary<string, string>> additionalInfo = default;
            Optional<InnerError> embeddedInnerError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalInfo"))
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
                    additionalInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("embeddedInnerError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    embeddedInnerError = DeserializeInnerError(property.Value);
                    continue;
                }
            }
            return new InnerError(code.Value, Optional.ToDictionary(additionalInfo), embeddedInnerError.Value);
        }
    }
}
