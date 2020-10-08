// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace LiveVideoAnalytics.Models
{
    public partial class MediaGraphHttpHeaderCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("headerName");
            writer.WriteStringValue(HeaderName);
            writer.WritePropertyName("headerValue");
            writer.WriteStringValue(HeaderValue);
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }
    }
}
