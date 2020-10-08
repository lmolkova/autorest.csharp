// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace LiveVideoAnalytics.Models
{
    /// <summary> Enables a graph to record media to an Azure Media Services asset, for subsequent playback. </summary>
    public partial class MediaGraphAssetSink : MediaGraphSink
    {
        /// <summary> Initializes a new instance of MediaGraphAssetSink. </summary>
        /// <param name="name"> Name to be used for the media graph sink. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this sink node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="inputs"/> is null. </exception>
        public MediaGraphAssetSink(string name, IEnumerable<MediaGraphNodeInput> inputs) : base(name, inputs)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }

            Type = "#Microsoft.Media.MediaGraphAssetSink";
        }

        /// <summary> Initializes a new instance of MediaGraphAssetSink. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="name"> Name to be used for the media graph sink. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this sink node. </param>
        /// <param name="assetNamePattern"> A name pattern when creating new assets. </param>
        /// <param name="segmentLength"> When writing media to an asset, wait until at least this duration of media has been accumulated on the Edge. Expressed in increments of 30 seconds, with a minimum of 30 seconds and a recommended maximum of 5 minutes. </param>
        /// <param name="localMediaCachePath"> Path to a local file system directory for temporary caching of media, before writing to an Asset. Used when the Edge device is temporarily disconnected from Azure. </param>
        /// <param name="localMediaCacheMaximumSizeMiB"> Maximum amount of disk space that can be used for temporary caching of media. </param>
        internal MediaGraphAssetSink(string type, string name, IList<MediaGraphNodeInput> inputs, string assetNamePattern, TimeSpan? segmentLength, string localMediaCachePath, string localMediaCacheMaximumSizeMiB) : base(type, name, inputs)
        {
            AssetNamePattern = assetNamePattern;
            SegmentLength = segmentLength;
            LocalMediaCachePath = localMediaCachePath;
            LocalMediaCacheMaximumSizeMiB = localMediaCacheMaximumSizeMiB;
            Type = type ?? "#Microsoft.Media.MediaGraphAssetSink";
        }

        /// <summary> A name pattern when creating new assets. </summary>
        public string AssetNamePattern { get; set; }
        /// <summary> When writing media to an asset, wait until at least this duration of media has been accumulated on the Edge. Expressed in increments of 30 seconds, with a minimum of 30 seconds and a recommended maximum of 5 minutes. </summary>
        public TimeSpan? SegmentLength { get; set; }
        /// <summary> Path to a local file system directory for temporary caching of media, before writing to an Asset. Used when the Edge device is temporarily disconnected from Azure. </summary>
        public string LocalMediaCachePath { get; set; }
        /// <summary> Maximum amount of disk space that can be used for temporary caching of media. </summary>
        public string LocalMediaCacheMaximumSizeMiB { get; set; }
    }
}
