// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class IncidentResultList
    {
        internal static IncidentResultList DeserializeIncidentResultList(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<IncidentResult>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<IncidentResult> array = new List<IncidentResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IncidentResult.DeserializeIncidentResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new IncidentResultList(nextLink.Value, Optional.ToList(value));
        }
    }
}
