// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Marketplace.Saas.Models
{
    /// <summary> The AadIdentifier. </summary>
    public partial class AadIdentifier
    {
        /// <summary> Initializes a new instance of AadIdentifier. </summary>
        internal AadIdentifier()
        {
        }

        /// <summary> Initializes a new instance of AadIdentifier. </summary>
        /// <param name="emailId"> . </param>
        /// <param name="objectId"> . </param>
        /// <param name="tenantId"> . </param>
        /// <param name="puid"> . </param>
        internal AadIdentifier(string emailId, Guid? objectId, Guid? tenantId, string puid)
        {
            EmailId = emailId;
            ObjectId = objectId;
            TenantId = tenantId;
            Puid = puid;
        }

        public string EmailId { get; }
        public Guid? ObjectId { get; }
        public Guid? TenantId { get; }
        public string Puid { get; }
    }
}
