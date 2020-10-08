// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace TestModel
{
    internal static class TestNonExtensibleEnumExtensions
    {
        public static string ToSerialString(this TestNonExtensibleEnum value) => value switch
        {
            TestNonExtensibleEnum.A => "A",
            TestNonExtensibleEnum.B => "B",
            TestNonExtensibleEnum.C => "C",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TestNonExtensibleEnum value.")
        };

        public static TestNonExtensibleEnum ToTestNonExtensibleEnum(this string value)
        {
            if (string.Equals(value, "A", StringComparison.InvariantCultureIgnoreCase)) return TestNonExtensibleEnum.A;
            if (string.Equals(value, "B", StringComparison.InvariantCultureIgnoreCase)) return TestNonExtensibleEnum.B;
            if (string.Equals(value, "C", StringComparison.InvariantCultureIgnoreCase)) return TestNonExtensibleEnum.C;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TestNonExtensibleEnum value.");
        }
    }
}
