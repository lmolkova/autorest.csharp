// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AnomalyDetector.Models
{
    /// <summary> The AzureEventHubsDataFeedPatch. </summary>
    internal partial class AzureEventHubsDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of AzureEventHubsDataFeedPatch. </summary>
        internal AzureEventHubsDataFeedPatch()
        {
            DataSourceType = new DataSourceType("AzureEventHubsDataFeedPatch");
        }

        public AzureEventHubsParameter DataSourceParameter { get; }
    }
}
