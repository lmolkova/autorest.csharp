// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class AliasPath
    {
        internal static AliasPath DeserializeAliasPath(JsonElement element)
        {
            Optional<string> path = default;
            Optional<IReadOnlyList<string>> apiVersions = default;
            Optional<AliasPattern> pattern = default;
            Optional<AliasPathMetadata> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("pattern"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pattern = AliasPattern.DeserializeAliasPattern(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = AliasPathMetadata.DeserializeAliasPathMetadata(property.Value);
                    continue;
                }
            }
            return new AliasPath(path.Value, Optional.ToList(apiVersions), pattern.Value, metadata.Value);
        }
    }
}