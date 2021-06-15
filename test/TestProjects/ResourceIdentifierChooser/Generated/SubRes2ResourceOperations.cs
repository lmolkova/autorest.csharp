// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing the operations that can be performed over a specific SubRes2Resource. </summary>
    public partial class SubRes2ResourceOperations : ResourceOperationsBase<TenantResourceIdentifier, SubRes2Resource>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        internal SubRes2ResourcesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="SubRes2ResourceOperations"/> class for mocking. </summary>
        protected SubRes2ResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubRes2ResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal SubRes2ResourceOperations(ResourceOperationsBase options, TenantResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            Id.TryGetSubscriptionId(out var subscriptionId);
            RestClient = new SubRes2ResourcesRestOperations(_clientDiagnostics, Pipeline, subscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Compute/SubRes2Resources";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<SubRes2Resource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceOperations.Get");
            scope.Start();
            try
            {
                var response = await RestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SubRes2Resource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<SubRes2Resource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceOperations.Get");
            scope.Start();
            try
            {
                var response = RestClient.Get(Id.Name, cancellationToken);
                return Response.FromValue(new SubRes2Resource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }
    }
}