// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace DataProtection.Models
{
    /// <summary> Inner Error. </summary>
    public partial class InnerError
    {
        /// <summary> Initializes a new instance of InnerError. </summary>
        internal InnerError()
        {
            AdditionalInfo = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of InnerError. </summary>
        /// <param name="code"> Unique code for this error. </param>
        /// <param name="additionalInfo"> Any Key value pairs that can be provided to the client for additional  verbose information. </param>
        /// <param name="embeddedInnerError"> Child Inner Error, to allow Nesting. </param>
        internal InnerError(string code, IReadOnlyDictionary<string, string> additionalInfo, InnerError embeddedInnerError)
        {
            Code = code;
            AdditionalInfo = additionalInfo;
            EmbeddedInnerError = embeddedInnerError;
        }

        /// <summary> Unique code for this error. </summary>
        public string Code { get; }
        /// <summary> Any Key value pairs that can be provided to the client for additional  verbose information. </summary>
        public IReadOnlyDictionary<string, string> AdditionalInfo { get; }
        /// <summary> Child Inner Error, to allow Nesting. </summary>
        public InnerError EmbeddedInnerError { get; }
    }
}
