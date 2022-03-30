// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ServerReview.Models
{
    public partial class TriggerContext : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static TriggerContext DeserializeTriggerContext(JsonElement element)
        {
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AdhocBasedTriggerContext": return AdhocBasedTriggerContext.DeserializeAdhocBasedTriggerContext(element);
                    case "ScheduleBasedTriggerContext": return ScheduleBasedTriggerContext.DeserializeScheduleBasedTriggerContext(element);
                }
            }
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new TriggerContext(objectType);
        }
    }
}
