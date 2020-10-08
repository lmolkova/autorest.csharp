// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace LiveVideoAnalytics.Models
{
    public partial class MediaGraphSignalGateProcessor : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActivationEvaluationWindow))
            {
                writer.WritePropertyName("activationEvaluationWindow");
                writer.WriteStringValue(ActivationEvaluationWindow);
            }
            if (Optional.IsDefined(ActivationSignalOffset))
            {
                writer.WritePropertyName("activationSignalOffset");
                writer.WriteStringValue(ActivationSignalOffset);
            }
            if (Optional.IsDefined(MinimumActivationTime))
            {
                writer.WritePropertyName("minimumActivationTime");
                writer.WriteStringValue(MinimumActivationTime);
            }
            if (Optional.IsDefined(MaximumActivationTime))
            {
                writer.WritePropertyName("maximumActivationTime");
                writer.WriteStringValue(MaximumActivationTime);
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MediaGraphSignalGateProcessor DeserializeMediaGraphSignalGateProcessor(JsonElement element)
        {
            Optional<string> activationEvaluationWindow = default;
            Optional<string> activationSignalOffset = default;
            Optional<string> minimumActivationTime = default;
            Optional<string> maximumActivationTime = default;
            string type = default;
            string name = default;
            IList<MediaGraphNodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activationEvaluationWindow"))
                {
                    activationEvaluationWindow = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activationSignalOffset"))
                {
                    activationSignalOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumActivationTime"))
                {
                    minimumActivationTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumActivationTime"))
                {
                    maximumActivationTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<MediaGraphNodeInput> array = new List<MediaGraphNodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaGraphNodeInput.DeserializeMediaGraphNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new MediaGraphSignalGateProcessor(type, name, inputs, activationEvaluationWindow.Value, activationSignalOffset.Value, minimumActivationTime.Value, maximumActivationTime.Value);
        }
    }
}
