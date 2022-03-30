// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ServerReview.Models
{
    public partial class BackupSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceType");
            writer.WriteStringValue(DataSourceType);
            writer.WritePropertyName("rules");
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(RawJsonSetting))
            {
                writer.WritePropertyName("rawJsonSetting");
                writer.WriteStringValue(RawJsonSetting);
            }
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName");
                writer.WriteStringValue(PolicyName);
            }
            if (Optional.IsDefined(PolicyParameters))
            {
                writer.WritePropertyName("policyParameters");
                writer.WriteObjectValue(PolicyParameters);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType");
                writer.WriteStringValue(ObjectType);
            }
            writer.WriteEndObject();
        }

        internal static BackupSettings DeserializeBackupSettings(JsonElement element)
        {
            string dataSourceType = default;
            IList<BackupRule> rules = default;
            Optional<string> rawJsonSetting = default;
            Optional<string> policyName = default;
            Optional<PolicyParameters> policyParameters = default;
            Optional<string> objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSourceType"))
                {
                    dataSourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rules"))
                {
                    List<BackupRule> array = new List<BackupRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupRule.DeserializeBackupRule(item));
                    }
                    rules = array;
                    continue;
                }
                if (property.NameEquals("rawJsonSetting"))
                {
                    rawJsonSetting = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyName"))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policyParameters = PolicyParameters.DeserializePolicyParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new BackupSettings(dataSourceType, rules, rawJsonSetting.Value, policyName.Value, policyParameters.Value, objectType.Value);
        }
    }
}
