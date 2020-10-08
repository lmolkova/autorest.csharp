// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text;
using System.Text.Json;
using Azure.Core;
using LiveVideoAnalytics.Models;

namespace LiveVideoAnalytics
{
    public class MediaGraphTopologySerialization
    {
        /// <summary>
        ///  Serialize MediaGraphTopology.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string SerializeMediaGraphTopology(MediaGraphTopology model)
        {
            return SerializeMediaGraphTopologyInternal(model);
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
        /// <param name="element"></param>
        /// <returns></returns>
        public static MediaGraphTopology DeserializeMediaGraphTopology(JsonElement element)
        {
            return MediaGraphTopology.DeserializeMediaGraphTopology(element);
        }
    }
}
