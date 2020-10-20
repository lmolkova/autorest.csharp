// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Marketplace.Saas.Models
{
    public partial class UpdateOperation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PlanId))
            {
                writer.WritePropertyName("planId");
                writer.WriteStringValue(PlanId);
            }
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity");
                writer.WriteNumberValue(Quantity.Value);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }
    }
}
