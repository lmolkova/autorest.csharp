// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace MgmtOperations
{
    /// <summary> A Class representing a AvailabilitySetChild along with the instance operations that can be performed on it. </summary>
    public class AvailabilitySetChild : AvailabilitySetChildOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "AvailabilitySetChild"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal AvailabilitySetChild(ResourceOperationsBase options, AvailabilitySetChildData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the AvailabilitySetChildData. </summary>
        public AvailabilitySetChildData Data { get; private set; }

        /// <inheritdoc />
        protected override AvailabilitySetChild GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<AvailabilitySetChild> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
