// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ServerReview.Models
{
    public partial class Error : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details");
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code");
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target");
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(InnerError))
            {
                writer.WritePropertyName("innerError");
                writer.WriteObjectValue(InnerError);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static Error DeserializeError(JsonElement element)
        {
            Optional<string> message = default;
            Optional<IList<Error>> details = default;
            Optional<string> code = default;
            Optional<string> target = default;
            Optional<InnerError> innerError = default;
            Optional<IDictionary<string, string>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Error> array = new List<Error>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    innerError = InnerError.DeserializeInnerError(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
            }
            return new Error(message.Value, Optional.ToList(details), code.Value, target.Value, innerError.Value, Optional.ToDictionary(properties));
        }
    }
}
