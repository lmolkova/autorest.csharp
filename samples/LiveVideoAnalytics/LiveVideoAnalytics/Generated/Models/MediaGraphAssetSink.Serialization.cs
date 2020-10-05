// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace LiveVideoAnalytics
{
    public partial class MediaGraphAssetSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AssetNamePattern))
            {
                writer.WritePropertyName("assetNamePattern");
                writer.WriteStringValue(AssetNamePattern);
            }
            if (Optional.IsDefined(SegmentLength))
            {
                writer.WritePropertyName("segmentLength");
                writer.WriteStringValue(SegmentLength.Value, "P");
            }
            if (Optional.IsDefined(LocalMediaCachePath))
            {
                writer.WritePropertyName("localMediaCachePath");
                writer.WriteStringValue(LocalMediaCachePath);
            }
            if (Optional.IsDefined(LocalMediaCacheMaximumSizeMiB))
            {
                writer.WritePropertyName("localMediaCacheMaximumSizeMiB");
                writer.WriteStringValue(LocalMediaCacheMaximumSizeMiB);
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MediaGraphAssetSink DeserializeMediaGraphAssetSink(JsonElement element)
        {
            Optional<string> assetNamePattern = default;
            Optional<TimeSpan> segmentLength = default;
            Optional<string> localMediaCachePath = default;
            Optional<string> localMediaCacheMaximumSizeMiB = default;
            string type = default;
            string name = default;
            IList<MediaGraphNodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetNamePattern"))
                {
                    assetNamePattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segmentLength"))
                {
                    segmentLength = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("localMediaCachePath"))
                {
                    localMediaCachePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localMediaCacheMaximumSizeMiB"))
                {
                    localMediaCacheMaximumSizeMiB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<MediaGraphNodeInput> array = new List<MediaGraphNodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaGraphNodeInput.DeserializeMediaGraphNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new MediaGraphAssetSink(type, name, inputs, assetNamePattern.Value, Optional.ToNullable(segmentLength), localMediaCachePath.Value, localMediaCacheMaximumSizeMiB.Value);
        }
    }
}
