// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace DataProtection.Models
{
    public partial class RestoreRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LoopBackContext))
            {
                writer.WritePropertyName("loopBackContext");
                writer.WriteStringValue(LoopBackContext);
            }
            writer.WritePropertyName("restoreType");
            writer.WriteStringValue(RestoreType.ToString());
            if (Optional.IsDefined(SourceDatasourceSet))
            {
                writer.WritePropertyName("sourceDatasourceSet");
                writer.WriteObjectValue(SourceDatasourceSet);
            }
            writer.WritePropertyName("sourceDatasource");
            writer.WriteObjectValue(SourceDatasource);
            if (Optional.IsDefined(TargetDatasourceSet))
            {
                writer.WritePropertyName("targetDatasourceSet");
                writer.WriteObjectValue(TargetDatasourceSet);
            }
            if (Optional.IsDefined(TargetDatasource))
            {
                writer.WritePropertyName("targetDatasource");
                writer.WriteObjectValue(TargetDatasource);
            }
            if (Optional.IsDefined(RestoreAsFilesTargetDetails))
            {
                writer.WritePropertyName("restoreAsFilesTargetDetails");
                writer.WriteObjectValue(RestoreAsFilesTargetDetails);
            }
            if (Optional.IsCollectionDefined(ILRRestoreCriteria))
            {
                writer.WritePropertyName("iLRRestoreCriteria");
                writer.WriteStartArray();
                foreach (var item in ILRRestoreCriteria)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RestoreToRPId))
            {
                writer.WritePropertyName("restoreToRPId");
                writer.WriteStringValue(RestoreToRPId);
            }
            if (Optional.IsDefined(RestoreToPointInTime))
            {
                writer.WritePropertyName("restoreToPointInTime");
                writer.WriteStringValue(RestoreToPointInTime);
            }
            if (Optional.IsCollectionDefined(RPCatalogInitializeParams))
            {
                writer.WritePropertyName("rPCatalogInitializeParams");
                writer.WriteStartObject();
                foreach (var item in RPCatalogInitializeParams)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(DatastoreInitializeParams))
            {
                writer.WritePropertyName("datastoreInitializeParams");
                writer.WriteStartObject();
                foreach (var item in DatastoreInitializeParams)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("forceOverwrite");
            writer.WriteBooleanValue(ForceOverwrite);
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

        internal static RestoreRequest DeserializeRestoreRequest(JsonElement element)
        {
            Optional<string> loopBackContext = default;
            RestoreType restoreType = default;
            Optional<DatasourceSet> sourceDatasourceSet = default;
            Datasource sourceDatasource = default;
            Optional<DatasourceSet> targetDatasourceSet = default;
            Optional<Datasource> targetDatasource = default;
            Optional<TargetDetails> restoreAsFilesTargetDetails = default;
            Optional<IList<ItemLevelRestoreCriteria>> ilrRestoreCriteria = default;
            Optional<string> restoreToRPId = default;
            Optional<string> restoreToPointInTime = default;
            Optional<IDictionary<string, string>> rpCatalogInitializeParams = default;
            Optional<IDictionary<string, string>> datastoreInitializeParams = default;
            bool forceOverwrite = default;
            Optional<string> jobLibraryInitializationParams = default;
            Optional<DatasourceTokens> datasourceAccessToken = default;
            Optional<IDictionary<string, string>> additionalProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loopBackContext"))
                {
                    loopBackContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreType"))
                {
                    restoreType = new RestoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceDatasourceSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceDatasourceSet = DatasourceSet.DeserializeDatasourceSet(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDatasource"))
                {
                    sourceDatasource = Datasource.DeserializeDatasource(property.Value);
                    continue;
                }
                if (property.NameEquals("targetDatasourceSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetDatasourceSet = DatasourceSet.DeserializeDatasourceSet(property.Value);
                    continue;
                }
                if (property.NameEquals("targetDatasource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetDatasource = Datasource.DeserializeDatasource(property.Value);
                    continue;
                }
                if (property.NameEquals("restoreAsFilesTargetDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    restoreAsFilesTargetDetails = TargetDetails.DeserializeTargetDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("iLRRestoreCriteria"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ItemLevelRestoreCriteria> array = new List<ItemLevelRestoreCriteria>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ItemLevelRestoreCriteria.DeserializeItemLevelRestoreCriteria(item));
                    }
                    ilrRestoreCriteria = array;
                    continue;
                }
                if (property.NameEquals("restoreToRPId"))
                {
                    restoreToRPId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreToPointInTime"))
                {
                    restoreToPointInTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rPCatalogInitializeParams"))
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
                    rpCatalogInitializeParams = dictionary;
                    continue;
                }
                if (property.NameEquals("datastoreInitializeParams"))
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
                    datastoreInitializeParams = dictionary;
                    continue;
                }
                if (property.NameEquals("forceOverwrite"))
                {
                    forceOverwrite = property.Value.GetBoolean();
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
            return new RestoreRequest(jobLibraryInitializationParams.Value, datasourceAccessToken.Value, Optional.ToDictionary(additionalProperties), restoreType, sourceDatasourceSet.Value, sourceDatasource, targetDatasourceSet.Value, targetDatasource.Value, restoreAsFilesTargetDetails.Value, Optional.ToList(ilrRestoreCriteria), restoreToRPId.Value, restoreToPointInTime.Value, Optional.ToDictionary(rpCatalogInitializeParams), Optional.ToDictionary(datastoreInitializeParams), forceOverwrite, loopBackContext.Value);
        }
    }
}
