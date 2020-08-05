// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AnomalyDetector.Models
{
    /// <summary> The MySqlDataFeedPatch. </summary>
    internal partial class MySqlDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of MySqlDataFeedPatch. </summary>
        internal MySqlDataFeedPatch()
        {
            DataSourceType = new DataSourceType("MySqlDataFeedPatch");
        }

        public SqlSourceParameter DataSourceParameter { get; }
    }
}
