// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Core;

namespace MgmtSingleton
{
    /// <summary> A class representing the operations that can be performed over a specific ParentResource. </summary>
    public partial class ParentResourceOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, ParentResource>
    {
        /// <summary> Initializes a new instance of the <see cref="ParentResourceOperations"/> class for mocking. </summary>
        protected ParentResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ParentResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ParentResourceOperations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
        }

        public static readonly ResourceType ResourceType = "Microsoft.Billing/parentResources";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public override Response<ParentResource> Get(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override Task<Response<ParentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of location that may take multiple service requests to iterate over. </returns>
        /// <exception cref="InvalidOperationException"> The default subscription id is null. </exception>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken);
        }

        #region Get SingletonResourceOperationss operation
        /// <summary> Gets an object representing a SingletonResourceOperations along with the instance operations that can be performed on it. </summary>
        /// <returns> Returns a <see cref="SingletonResourceOperations" /> object. </returns>
        public SingletonResourceOperations GetSingletonResourceOperationss()
        {
            return new SingletonResourceOperations(this);
        }
        #endregion

        #region Get SingletonResource2Operationss operation
        /// <summary> Gets an object representing a SingletonResource2Operations along with the instance operations that can be performed on it. </summary>
        /// <returns> Returns a <see cref="SingletonResource2Operations" /> object. </returns>
        public SingletonResource2Operations GetSingletonResource2Operationss()
        {
            return new SingletonResource2Operations(this);
        }
        #endregion
    }
}
