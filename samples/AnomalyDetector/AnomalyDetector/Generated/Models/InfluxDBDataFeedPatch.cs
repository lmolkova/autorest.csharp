// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AnomalyDetector.Models
{
    /// <summary> The InfluxDBDataFeedPatch. </summary>
    internal partial class InfluxDBDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of InfluxDBDataFeedPatch. </summary>
        internal InfluxDBDataFeedPatch()
        {
            DataSourceType = new DataSourceType("InfluxDBDataFeedPatch");
        }

        public InfluxDBParameter DataSourceParameter { get; }
    }
}
