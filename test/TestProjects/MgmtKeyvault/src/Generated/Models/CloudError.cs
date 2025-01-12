// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtKeyvault.Models
{
    /// <summary> An error response from Key Vault resource provider. </summary>
    internal partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        internal CloudError()
        {
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="error"> An error response from Key Vault resource provider. </param>
        internal CloudError(CloudErrorBody error)
        {
            Error = error;
        }

        /// <summary> An error response from Key Vault resource provider. </summary>
        public CloudErrorBody Error { get; }
    }
}
