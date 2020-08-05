// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace AnomalyDetector.Models
{
    /// <summary> The AnomalyDetectorDirection. </summary>
    public readonly partial struct AnomalyDetectorDirection : IEquatable<AnomalyDetectorDirection>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AnomalyDetectorDirection"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnomalyDetectorDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BothValue = "Both";
        private const string DownValue = "Down";
        private const string UpValue = "Up";

        /// <summary> Both. </summary>
        public static AnomalyDetectorDirection Both { get; } = new AnomalyDetectorDirection(BothValue);
        /// <summary> Down. </summary>
        public static AnomalyDetectorDirection Down { get; } = new AnomalyDetectorDirection(DownValue);
        /// <summary> Up. </summary>
        public static AnomalyDetectorDirection Up { get; } = new AnomalyDetectorDirection(UpValue);
        /// <summary> Determines if two <see cref="AnomalyDetectorDirection"/> values are the same. </summary>
        public static bool operator ==(AnomalyDetectorDirection left, AnomalyDetectorDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnomalyDetectorDirection"/> values are not the same. </summary>
        public static bool operator !=(AnomalyDetectorDirection left, AnomalyDetectorDirection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnomalyDetectorDirection"/>. </summary>
        public static implicit operator AnomalyDetectorDirection(string value) => new AnomalyDetectorDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnomalyDetectorDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnomalyDetectorDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
