// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace OperationGroupMappings
{
    /// <summary> The Resource model definition. </summary>
    public partial class Resource : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        internal Resource(string location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal Resource(ResourceGroupResourceIdentifier id, string name, ResourceType type, string location, IReadOnlyDictionary<string, string> tags) : base(id, name, type)
        {
            Location = location;
            Tags = tags;
        }

        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
