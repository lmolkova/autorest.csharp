// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ServerReview.Models
{
    public partial class TargetDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url");
            writer.WriteStringValue(Url);
            writer.WritePropertyName("filePrefix");
            writer.WriteStringValue(FilePrefix);
            writer.WritePropertyName("restoreTargetLocationType");
            writer.WriteStringValue(RestoreTargetLocationType.ToString());
            writer.WriteEndObject();
        }

        internal static TargetDetails DeserializeTargetDetails(JsonElement element)
        {
            string url = default;
            string filePrefix = default;
            RestoreTargetLocationType restoreTargetLocationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePrefix"))
                {
                    filePrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTargetLocationType"))
                {
                    restoreTargetLocationType = new RestoreTargetLocationType(property.Value.GetString());
                    continue;
                }
            }
            return new TargetDetails(url, filePrefix, restoreTargetLocationType);
        }
    }
}
