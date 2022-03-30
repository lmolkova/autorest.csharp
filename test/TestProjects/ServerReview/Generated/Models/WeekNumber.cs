// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ServerReview.Models
{
    /// <summary> The WeekNumber. </summary>
    public readonly partial struct WeekNumber : IEquatable<WeekNumber>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WeekNumber"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WeekNumber(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FirstValue = "First";
        private const string SecondValue = "Second";
        private const string ThirdValue = "Third";
        private const string FourthValue = "Fourth";
        private const string LastValue = "Last";
        private const string InvalidValue = "Invalid";

        /// <summary> First. </summary>
        public static WeekNumber First { get; } = new WeekNumber(FirstValue);
        /// <summary> Second. </summary>
        public static WeekNumber Second { get; } = new WeekNumber(SecondValue);
        /// <summary> Third. </summary>
        public static WeekNumber Third { get; } = new WeekNumber(ThirdValue);
        /// <summary> Fourth. </summary>
        public static WeekNumber Fourth { get; } = new WeekNumber(FourthValue);
        /// <summary> Last. </summary>
        public static WeekNumber Last { get; } = new WeekNumber(LastValue);
        /// <summary> Invalid. </summary>
        public static WeekNumber Invalid { get; } = new WeekNumber(InvalidValue);
        /// <summary> Determines if two <see cref="WeekNumber"/> values are the same. </summary>
        public static bool operator ==(WeekNumber left, WeekNumber right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WeekNumber"/> values are not the same. </summary>
        public static bool operator !=(WeekNumber left, WeekNumber right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WeekNumber"/>. </summary>
        public static implicit operator WeekNumber(string value) => new WeekNumber(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WeekNumber other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WeekNumber other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
