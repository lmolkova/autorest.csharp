// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing the SubResResource data model. </summary>
    public partial class SubResResourceData : SubResource<SubscriptionResourceIdentifier>
    {
        /// <summary> Initializes a new instance of SubResResourceData. </summary>
        public SubResResourceData()
        {
        }

        /// <summary> Initializes a new instance of SubResResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="new"></param>
        internal SubResResourceData(string id, string @new) : base(id)
        {
            New = @new;
        }

        public string New { get; set; }
    }
}
