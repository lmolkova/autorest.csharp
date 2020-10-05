// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace LiveVideoAnalytics.Models
{
    internal static class MediaGraphParameterTypeExtensions
    {
        public static string ToSerialString(this MediaGraphParameterType value) => value switch
        {
            MediaGraphParameterType.String => "String",
            MediaGraphParameterType.SecretString => "SecretString",
            MediaGraphParameterType.Int => "Int",
            MediaGraphParameterType.Double => "Double",
            MediaGraphParameterType.Bool => "Bool",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MediaGraphParameterType value.")
        };

        public static MediaGraphParameterType ToMediaGraphParameterType(this string value)
        {
            if (string.Equals(value, "String", StringComparison.InvariantCultureIgnoreCase)) return MediaGraphParameterType.String;
            if (string.Equals(value, "SecretString", StringComparison.InvariantCultureIgnoreCase)) return MediaGraphParameterType.SecretString;
            if (string.Equals(value, "Int", StringComparison.InvariantCultureIgnoreCase)) return MediaGraphParameterType.Int;
            if (string.Equals(value, "Double", StringComparison.InvariantCultureIgnoreCase)) return MediaGraphParameterType.Double;
            if (string.Equals(value, "Bool", StringComparison.InvariantCultureIgnoreCase)) return MediaGraphParameterType.Bool;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MediaGraphParameterType value.");
        }
    }
}
