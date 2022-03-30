// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ServerReview.Models
{
    public partial class PolicyInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName");
                writer.WriteStringValue(PolicyName);
            }
            if (Optional.IsDefined(PolicyVersion))
            {
                writer.WritePropertyName("policyVersion");
                writer.WriteStringValue(PolicyVersion);
            }
            writer.WriteEndObject();
        }

        internal static PolicyInfo DeserializePolicyInfo(JsonElement element)
        {
            Optional<string> policyName = default;
            Optional<string> policyVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyName"))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyVersion"))
                {
                    policyVersion = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyInfo(policyName.Value, policyVersion.Value);
        }
    }
}
