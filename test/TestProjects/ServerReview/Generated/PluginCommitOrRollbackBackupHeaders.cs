// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace ServerReview
{
    internal partial class PluginCommitOrRollbackBackupHeaders
    {
        private readonly Response _response;
        public PluginCommitOrRollbackBackupHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Polling interval in seconds to get the next status of the LRO. </summary>
        public int? RetryAfter => _response.Headers.TryGetValue("Retry-After", out int? value) ? value : null;
        /// <summary> ErrorCode string in the event of a failure. </summary>
        public string XMsErrorCode => _response.Headers.TryGetValue("x-ms-error-code", out string value) ? value : null;
    }
}
