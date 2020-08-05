// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace AnomalyDetector.Models
{
    /// <summary> The AnomalyAlertingConfigurationPatch. </summary>
    internal partial class AnomalyAlertingConfigurationPatch
    {
        /// <summary> Initializes a new instance of AnomalyAlertingConfigurationPatch. </summary>
        internal AnomalyAlertingConfigurationPatch()
        {
            HookIds = new ChangeTrackingList<Guid>();
            MetricAlertingConfigurations = new ChangeTrackingList<MetricAlertingConfiguration>();
        }

        /// <summary> Anomaly alerting configuration name. </summary>
        public string Name { get; }
        public AnomalyAlertingConfigurationLogicType? CrossMetricsOperator { get; }
        /// <summary> hook unique ids. </summary>
        public IReadOnlyList<Guid> HookIds { get; }
        /// <summary> Anomaly alerting configurations. </summary>
        public IReadOnlyList<MetricAlertingConfiguration> MetricAlertingConfigurations { get; }
    }
}
