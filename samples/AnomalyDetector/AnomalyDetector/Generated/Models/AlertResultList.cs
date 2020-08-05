// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace AnomalyDetector.Models
{
    /// <summary> The AlertResultList. </summary>
    public partial class AlertResultList
    {
        /// <summary> Initializes a new instance of AlertResultList. </summary>
        internal AlertResultList()
        {
            Value = new ChangeTrackingList<AlertResult>();
        }

        /// <summary> Initializes a new instance of AlertResultList. </summary>
        /// <param name="nextLink"> . </param>
        /// <param name="value"> . </param>
        internal AlertResultList(string nextLink, IReadOnlyList<AlertResult> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        public IReadOnlyList<AlertResult> Value { get; }
    }
}
