// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ServerReview.Models
{
    public partial class AdhocBasedTriggerContext : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("taggingCriteria");
            writer.WriteObjectValue(TaggingCriteria);
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static AdhocBasedTriggerContext DeserializeAdhocBasedTriggerContext(JsonElement element)
        {
            AdhocBasedTaggingCriteria taggingCriteria = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taggingCriteria"))
                {
                    taggingCriteria = AdhocBasedTaggingCriteria.DeserializeAdhocBasedTaggingCriteria(property.Value);
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new AdhocBasedTriggerContext(objectType, taggingCriteria);
        }
    }
}
