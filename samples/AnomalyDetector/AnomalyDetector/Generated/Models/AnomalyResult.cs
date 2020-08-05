// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace AnomalyDetector.Models
{
    /// <summary> The AnomalyResult. </summary>
    public partial class AnomalyResult
    {
        /// <summary> Initializes a new instance of AnomalyResult. </summary>
        internal AnomalyResult()
        {
            Dimension = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of AnomalyResult. </summary>
        /// <param name="metricId">
        /// metric unique id
        /// 
        /// 
        /// 
        /// only return for alerting anomaly result.
        /// </param>
        /// <param name="anomalyDetectionConfigurationId">
        /// anomaly detection configuration unique id
        /// 
        /// 
        /// 
        /// only return for alerting anomaly result.
        /// </param>
        /// <param name="timestamp"> anomaly time. </param>
        /// <param name="createdTime">
        /// created time
        /// 
        /// 
        /// 
        /// only return for alerting result.
        /// </param>
        /// <param name="modifiedTime">
        /// modified time
        /// 
        /// 
        /// 
        /// only return for alerting result.
        /// </param>
        /// <param name="dimension"> dimension specified for series. </param>
        /// <param name="property"> . </param>
        internal AnomalyResult(Guid? metricId, Guid? anomalyDetectionConfigurationId, DateTimeOffset? timestamp, DateTimeOffset? createdTime, DateTimeOffset? modifiedTime, IReadOnlyDictionary<string, string> dimension, AnomalyProperty property)
        {
            MetricId = metricId;
            AnomalyDetectionConfigurationId = anomalyDetectionConfigurationId;
            Timestamp = timestamp;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            Dimension = dimension;
            Property = property;
        }

        /// <summary>
        /// metric unique id
        /// 
        /// 
        /// 
        /// only return for alerting anomaly result.
        /// </summary>
        public Guid? MetricId { get; }
        /// <summary>
        /// anomaly detection configuration unique id
        /// 
        /// 
        /// 
        /// only return for alerting anomaly result.
        /// </summary>
        public Guid? AnomalyDetectionConfigurationId { get; }
        /// <summary> anomaly time. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary>
        /// created time
        /// 
        /// 
        /// 
        /// only return for alerting result.
        /// </summary>
        public DateTimeOffset? CreatedTime { get; }
        /// <summary>
        /// modified time
        /// 
        /// 
        /// 
        /// only return for alerting result.
        /// </summary>
        public DateTimeOffset? ModifiedTime { get; }
        /// <summary> dimension specified for series. </summary>
        public IReadOnlyDictionary<string, string> Dimension { get; }
        public AnomalyProperty Property { get; }
    }
}
