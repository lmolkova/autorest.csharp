// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class AnomalyDetectionConfigurationList
    {
        internal static AnomalyDetectionConfigurationList DeserializeAnomalyDetectionConfigurationList(JsonElement element)
        {
            Optional<IReadOnlyList<AnomalyDetectionConfiguration>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AnomalyDetectionConfiguration> array = new List<AnomalyDetectionConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnomalyDetectionConfiguration.DeserializeAnomalyDetectionConfiguration(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AnomalyDetectionConfigurationList(Optional.ToList(value));
        }
    }
}
