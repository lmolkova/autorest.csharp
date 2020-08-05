// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace AnomalyDetector.Models
{
    /// <summary> The MetricAnomalyFeedbackSourceInfo. </summary>
    internal partial class MetricAnomalyFeedbackSourceInfo
    {
        /// <summary> Initializes a new instance of MetricAnomalyFeedbackSourceInfo. </summary>
        /// <param name="anomalyDetectionConfiguration"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="anomalyDetectionConfiguration"/> is null. </exception>
        internal MetricAnomalyFeedbackSourceInfo(AnomalyDetectionConfiguration anomalyDetectionConfiguration)
        {
            if (anomalyDetectionConfiguration == null)
            {
                throw new ArgumentNullException(nameof(anomalyDetectionConfiguration));
            }

            AnomalyDetectionConfiguration = anomalyDetectionConfiguration;
        }

        public AnomalyDetectionConfiguration AnomalyDetectionConfiguration { get; }
    }
}
