// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace AnomalyDetector.Models
{
    /// <summary> The AnomalyDimensionQuery. </summary>
    public partial class AnomalyDimensionQuery
    {
        /// <summary> Initializes a new instance of AnomalyDimensionQuery. </summary>
        /// <param name="startTime"> start time. </param>
        /// <param name="endTime"> end time. </param>
        /// <param name="dimensionName"> dimension to query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dimensionName"/> is null. </exception>
        public AnomalyDimensionQuery(DateTimeOffset startTime, DateTimeOffset endTime, string dimensionName)
        {
            if (dimensionName == null)
            {
                throw new ArgumentNullException(nameof(dimensionName));
            }

            StartTime = startTime;
            EndTime = endTime;
            DimensionName = dimensionName;
        }

        /// <summary> start time. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> end time. </summary>
        public DateTimeOffset EndTime { get; }
        /// <summary> dimension to query. </summary>
        public string DimensionName { get; }
        public DimensionGroupIdentity DimensionFilter { get; set; }
    }
}
