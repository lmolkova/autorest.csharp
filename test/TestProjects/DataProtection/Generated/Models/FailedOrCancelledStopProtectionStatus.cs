// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace DataProtection.Models
{
    /// <summary> StopProtectionStatus for the failed or cancelled stopProtection operation. </summary>
    public partial class FailedOrCancelledStopProtectionStatus : StopProtectionStatus
    {
        /// <summary> Initializes a new instance of FailedOrCancelledStopProtectionStatus. </summary>
        internal FailedOrCancelledStopProtectionStatus()
        {
        }

        /// <summary> Initializes a new instance of FailedOrCancelledStopProtectionStatus. </summary>
        /// <param name="additionalProperties"> Any additional properties that should be returned along with this operation. </param>
        /// <param name="telemetryData"> Additional Json Serialized Telemetry data from the Plugin. This would be logged with BA Telemetry. </param>
        /// <param name="retryAfterOnRetryableErrorInSeconds"> If Plugin terminates with a retryable ErrorCode, it can set this value in Seconds for BA to retry after this. </param>
        /// <param name="error"> Embedded Error Object. </param>
        internal FailedOrCancelledStopProtectionStatus(IReadOnlyDictionary<string, string> additionalProperties, string telemetryData, int? retryAfterOnRetryableErrorInSeconds, Error error) : base(additionalProperties, telemetryData, retryAfterOnRetryableErrorInSeconds)
        {
            Error = error;
        }

        /// <summary> Embedded Error Object. </summary>
        public Error Error { get; }
    }
}
