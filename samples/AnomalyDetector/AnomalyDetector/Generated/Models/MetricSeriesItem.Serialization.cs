// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class MetricSeriesItem
    {
        internal static MetricSeriesItem DeserializeMetricSeriesItem(JsonElement element)
        {
            Optional<Guid> metricId = default;
            Optional<IReadOnlyDictionary<string, string>> dimension = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricId"))
                {
                    metricId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("dimension"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    dimension = dictionary;
                    continue;
                }
            }
            return new MetricSeriesItem(Optional.ToNullable(metricId), Optional.ToDictionary(dimension));
        }
    }
}
