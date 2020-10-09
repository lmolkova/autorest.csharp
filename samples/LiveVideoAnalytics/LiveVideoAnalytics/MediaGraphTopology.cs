// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace LiveVideoAnalytics.Models
{
    public partial class MediaGraphTopology
    {
        /// <summary>
        ///  Serialize MediaGraphTopology.
        /// </summary>
        /// <returns></returns>
        public string SerializeMediaGraphTopology()
        {
            return SerializeMediaGraphTopologyInternal(this);
        }

        internal string SerializeMediaGraphTopologyInternal(IUtf8JsonSerializable serializable)
        {
            using var memoryStream = new MemoryStream();

            using (var writer = new Utf8JsonWriter(memoryStream))
            {
                serializable.Write(writer);
            }

            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }

        /// <summary>
        ///  Deserialize MediaGraphTopology.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static MediaGraphTopology DeserializeMediaGraphTopology(string model)
        {
            var modelAsJson = JsonSerializer.Serialize(model);
            return DeserializeMediaGraphTopology(modelAsJson);
        }
    }
}
