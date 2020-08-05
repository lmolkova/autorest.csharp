// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class IncidentProperty
    {
        internal static IncidentProperty DeserializeIncidentProperty(JsonElement element)
        {
            Optional<Severity> maxSeverity = default;
            Optional<IncidentStatus> incidentStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSeverity"))
                {
                    maxSeverity = new Severity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incidentStatus"))
                {
                    incidentStatus = new IncidentStatus(property.Value.GetString());
                    continue;
                }
            }
            return new IncidentProperty(Optional.ToNullable(maxSeverity), Optional.ToNullable(incidentStatus));
        }
    }
}
