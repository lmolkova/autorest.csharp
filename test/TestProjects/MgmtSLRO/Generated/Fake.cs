// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtSLRO
{
    /// <summary> A Class representing a Fake along with the instance operations that can be performed on it. </summary>
    public class Fake : FakeOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "Fake"/> class for mocking. </summary>
        protected Fake() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "Fake"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal Fake(ResourceOperations options, FakeData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the FakeData. </summary>
        public virtual FakeData Data { get; private set; }
    }
}
