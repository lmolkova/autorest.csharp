// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace DataProtection.Models
{
    /// <summary> Service-set extensible enum indicating operation?s kind. </summary>
    public readonly partial struct OperationType : IEquatable<OperationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidateForProtectionValue = "ValidateForProtection";
        private const string StartProtectionValue = "StartProtection";
        private const string UpdateProtectionValue = "UpdateProtection";
        private const string StopProtectionValue = "StopProtection";
        private const string ValidateForBackupValue = "ValidateForBackup";
        private const string BackupValue = "Backup";
        private const string CommitOrRollbackBackupValue = "CommitOrRollbackBackup";
        private const string ValidateForRestoreValue = "ValidateForRestore";
        private const string RestoreValue = "Restore";
        private const string CommitOrRollbackRestoreValue = "CommitOrRollbackRestore";

        /// <summary> ValidateForProtection. </summary>
        public static OperationType ValidateForProtection { get; } = new OperationType(ValidateForProtectionValue);
        /// <summary> StartProtection. </summary>
        public static OperationType StartProtection { get; } = new OperationType(StartProtectionValue);
        /// <summary> UpdateProtection. </summary>
        public static OperationType UpdateProtection { get; } = new OperationType(UpdateProtectionValue);
        /// <summary> StopProtection. </summary>
        public static OperationType StopProtection { get; } = new OperationType(StopProtectionValue);
        /// <summary> ValidateForBackup. </summary>
        public static OperationType ValidateForBackup { get; } = new OperationType(ValidateForBackupValue);
        /// <summary> Backup. </summary>
        public static OperationType Backup { get; } = new OperationType(BackupValue);
        /// <summary> CommitOrRollbackBackup. </summary>
        public static OperationType CommitOrRollbackBackup { get; } = new OperationType(CommitOrRollbackBackupValue);
        /// <summary> ValidateForRestore. </summary>
        public static OperationType ValidateForRestore { get; } = new OperationType(ValidateForRestoreValue);
        /// <summary> Restore. </summary>
        public static OperationType Restore { get; } = new OperationType(RestoreValue);
        /// <summary> CommitOrRollbackRestore. </summary>
        public static OperationType CommitOrRollbackRestore { get; } = new OperationType(CommitOrRollbackRestoreValue);
        /// <summary> Determines if two <see cref="OperationType"/> values are the same. </summary>
        public static bool operator ==(OperationType left, OperationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationType"/> values are not the same. </summary>
        public static bool operator !=(OperationType left, OperationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationType"/>. </summary>
        public static implicit operator OperationType(string value) => new OperationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
