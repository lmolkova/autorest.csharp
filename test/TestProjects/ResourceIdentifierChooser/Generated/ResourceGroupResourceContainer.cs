// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing collection of ResourceGroupResource and their operations over a ResourceGroup. </summary>
    public partial class ResourceGroupResourceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, ResourceGroupResource, ResourceGroupResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceContainer"/> class for mocking. </summary>
        protected ResourceGroupResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of ResourceGroupResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ResourceGroupResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ResourceGroupResourcesRestOperations _restClient => new ResourceGroupResourcesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a ResourceGroupResource. Please note some properties can be set only during creation. </summary>
        /// <param name="resourceGroupResourcesName"> The String to use. </param>
        /// <param name="parameters"> The ResourceGroupResource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<ResourceGroupResource> CreateOrUpdate(string resourceGroupResourcesName, ResourceGroupResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (resourceGroupResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(resourceGroupResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(resourceGroupResourcesName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ResourceGroupResource. Please note some properties can be set only during creation. </summary>
        /// <param name="resourceGroupResourcesName"> The String to use. </param>
        /// <param name="parameters"> The ResourceGroupResource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<ResourceGroupResource>> CreateOrUpdateAsync(string resourceGroupResourcesName, ResourceGroupResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (resourceGroupResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(resourceGroupResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(resourceGroupResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ResourceGroupResource. Please note some properties can be set only during creation. </summary>
        /// <param name="resourceGroupResourcesName"> The String to use. </param>
        /// <param name="parameters"> The ResourceGroupResource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public ResourceGroupResourcesPutOperation StartCreateOrUpdate(string resourceGroupResourcesName, ResourceGroupResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (resourceGroupResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(resourceGroupResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(Id.ResourceGroupName, resourceGroupResourcesName, parameters, cancellationToken: cancellationToken);
                return new ResourceGroupResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ResourceGroupResource. Please note some properties can be set only during creation. </summary>
        /// <param name="resourceGroupResourcesName"> The String to use. </param>
        /// <param name="parameters"> The ResourceGroupResource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<ResourceGroupResourcesPutOperation> StartCreateOrUpdateAsync(string resourceGroupResourcesName, ResourceGroupResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (resourceGroupResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(resourceGroupResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(Id.ResourceGroupName, resourceGroupResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new ResourceGroupResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="resourceGroupResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public override Response<ResourceGroupResource> Get(string resourceGroupResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupResourceContainer.Get");
            scope.Start();
            try
            {
                if (resourceGroupResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(resourceGroupResourcesName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, resourceGroupResourcesName, cancellationToken: cancellationToken);
                return Response.FromValue(new ResourceGroupResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="resourceGroupResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async override Task<Response<ResourceGroupResource>> GetAsync(string resourceGroupResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupResourceContainer.Get");
            scope.Start();
            try
            {
                if (resourceGroupResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(resourceGroupResourcesName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, resourceGroupResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroupResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ResourceGroupResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceGroupResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ResourceGroupResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceGroupResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, ResourceGroupResource, ResourceGroupResourceData> Construct() { }
    }
}
