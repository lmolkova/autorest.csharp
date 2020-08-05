// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace AnomalyDetector.Models
{
    /// <summary> The MetricDataList. </summary>
    public partial class MetricDataList
    {
        /// <summary> Initializes a new instance of MetricDataList. </summary>
        internal MetricDataList()
        {
            Value = new ChangeTrackingList<MetricDataItem>();
        }

        /// <summary> Initializes a new instance of MetricDataList. </summary>
        /// <param name="nextLink"> . </param>
        /// <param name="value"> . </param>
        internal MetricDataList(string nextLink, IReadOnlyList<MetricDataItem> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        public IReadOnlyList<MetricDataItem> Value { get; }
    }
}
