// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using LiveVideoAnalytics.Models;

namespace LiveVideoAnalytics
{
    public partial class MediaGraphGrpcExtensionDataTransfer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SharedMemorySizeMiB))
            {
                writer.WritePropertyName("sharedMemorySizeMiB");
                writer.WriteStringValue(SharedMemorySizeMiB);
            }
            writer.WritePropertyName("mode");
            writer.WriteStringValue(Mode.ToString());
            writer.WriteEndObject();
        }

        internal static MediaGraphGrpcExtensionDataTransfer DeserializeMediaGraphGrpcExtensionDataTransfer(JsonElement element)
        {
            Optional<string> sharedMemorySizeMiB = default;
            MediaGraphGrpcExtensionDataTransferMode mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sharedMemorySizeMiB"))
                {
                    sharedMemorySizeMiB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    mode = new MediaGraphGrpcExtensionDataTransferMode(property.Value.GetString());
                    continue;
                }
            }
            return new MediaGraphGrpcExtensionDataTransfer(sharedMemorySizeMiB.Value, mode);
        }
    }
}
