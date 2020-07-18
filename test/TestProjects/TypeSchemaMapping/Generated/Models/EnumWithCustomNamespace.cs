// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Very.Custom.Namespace.From.Swagger
{
    /// <summary> Letters. </summary>
    internal readonly partial struct EnumWithCustomNamespace : IEquatable<EnumWithCustomNamespace>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnumWithCustomNamespace"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnumWithCustomNamespace(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AValue = "A";
        private const string BValue = "B";
        private const string CValue = "C";

        /// <summary> A. </summary>
        public static EnumWithCustomNamespace A { get; } = new EnumWithCustomNamespace(AValue);
        /// <summary> B. </summary>
        public static EnumWithCustomNamespace B { get; } = new EnumWithCustomNamespace(BValue);
        /// <summary> C. </summary>
        public static EnumWithCustomNamespace C { get; } = new EnumWithCustomNamespace(CValue);
        /// <summary> Determines if two <see cref="EnumWithCustomNamespace"/> values are the same. </summary>
        public static bool operator ==(EnumWithCustomNamespace left, EnumWithCustomNamespace right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnumWithCustomNamespace"/> values are not the same. </summary>
        public static bool operator !=(EnumWithCustomNamespace left, EnumWithCustomNamespace right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnumWithCustomNamespace"/>. </summary>
        public static implicit operator EnumWithCustomNamespace(string value) => new EnumWithCustomNamespace(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnumWithCustomNamespace other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnumWithCustomNamespace other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
