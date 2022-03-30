// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ServerReview.Models
{
    public partial class DataStoreParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("dataStoreType");
            writer.WriteStringValue(DataStoreType.ToString());
            writer.WriteEndObject();
        }

        internal static DataStoreParameters DeserializeDataStoreParameters(JsonElement element)
        {
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureOperationalStoreParameters": return AzureOperationalStoreParameters.DeserializeAzureOperationalStoreParameters(element);
                }
            }
            string objectType = default;
            DataStoreTypes dataStoreType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStoreType"))
                {
                    dataStoreType = new DataStoreTypes(property.Value.GetString());
                    continue;
                }
            }
            return new DataStoreParameters(objectType, dataStoreType);
        }
    }
}
