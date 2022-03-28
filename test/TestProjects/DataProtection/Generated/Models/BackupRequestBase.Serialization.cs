// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace DataProtection.Models
{
    public partial class BackupRequestBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DatasourceSet))
            {
                writer.WritePropertyName("datasourceSet");
                writer.WriteObjectValue(DatasourceSet);
            }
            writer.WritePropertyName("datasource");
            writer.WriteObjectValue(Datasource);
            writer.WritePropertyName("rPCatalogInitializeParams");
            writer.WriteStartObject();
            foreach (var item in RPCatalogInitializeParams)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("datastoreInitializeParams");
            writer.WriteStartObject();
            foreach (var item in DatastoreInitializeParams)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("backupParameters");
            writer.WriteObjectValue(BackupParameters);
            if (Optional.IsDefined(JobLibraryInitializationParams))
            {
                writer.WritePropertyName("jobLibraryInitializationParams");
                writer.WriteStringValue(JobLibraryInitializationParams);
            }
            if (Optional.IsDefined(DatasourceAccessToken))
            {
                writer.WritePropertyName("datasourceAccessToken");
                writer.WriteObjectValue(DatasourceAccessToken);
            }
            if (Optional.IsCollectionDefined(AdditionalProperties))
            {
                writer.WritePropertyName("additionalProperties");
                writer.WriteStartObject();
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static BackupRequestBase DeserializeBackupRequestBase(JsonElement element)
        {
            Optional<DatasourceSet> datasourceSet = default;
            Datasource datasource = default;
            IDictionary<string, string> rpCatalogInitializeParams = default;
            IDictionary<string, string> datastoreInitializeParams = default;
            AzureBackupParamsForPlugin backupParameters = default;
            Optional<string> jobLibraryInitializationParams = default;
            Optional<DatasourceTokens> datasourceAccessToken = default;
            Optional<IDictionary<string, string>> additionalProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasourceSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    datasourceSet = DatasourceSet.DeserializeDatasourceSet(property.Value);
                    continue;
                }
                if (property.NameEquals("datasource"))
                {
                    datasource = Datasource.DeserializeDatasource(property.Value);
                    continue;
                }
                if (property.NameEquals("rPCatalogInitializeParams"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    rpCatalogInitializeParams = dictionary;
                    continue;
                }
                if (property.NameEquals("datastoreInitializeParams"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    datastoreInitializeParams = dictionary;
                    continue;
                }
                if (property.NameEquals("backupParameters"))
                {
                    backupParameters = AzureBackupParamsForPlugin.DeserializeAzureBackupParamsForPlugin(property.Value);
                    continue;
                }
                if (property.NameEquals("jobLibraryInitializationParams"))
                {
                    jobLibraryInitializationParams = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasourceAccessToken"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    datasourceAccessToken = DatasourceTokens.DeserializeDatasourceTokens(property.Value);
                    continue;
                }
                if (property.NameEquals("additionalProperties"))
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
                    additionalProperties = dictionary;
                    continue;
                }
            }
            return new BackupRequestBase(jobLibraryInitializationParams.Value, datasourceAccessToken.Value, Optional.ToDictionary(additionalProperties), datasourceSet.Value, datasource, rpCatalogInitializeParams, datastoreInitializeParams, backupParameters);
        }
    }
}
