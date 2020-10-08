// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace LiveVideoAnalytics.Models
{
    public partial class MediaGraphInstance : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion");
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData");
                writer.WriteObjectValue(SystemData);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WriteEndObject();
        }
    }
}
