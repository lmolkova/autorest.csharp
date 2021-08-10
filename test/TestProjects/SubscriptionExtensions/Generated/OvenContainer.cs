// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using SubscriptionExtensions.Models;

namespace SubscriptionExtensions
{
    /// <summary> A class representing collection of Oven and their operations over a ResourceGroup. </summary>
    public partial class OvenContainer : ResourceContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly OvensRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="OvenContainer"/> class for mocking. </summary>
        protected OvenContainer()
        {
        }

        /// <summary> Initializes a new instance of OvenContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal OvenContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new OvensRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<Oven> CreateOrUpdate(string vmName, OvenData parameters, CancellationToken cancellationToken = default)
        {
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(vmName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<Oven>> CreateOrUpdateAsync(string vmName, OvenData parameters, CancellationToken cancellationToken = default)
        {
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(vmName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual OvenCreateOrUpdateOperation StartCreateOrUpdate(string vmName, OvenData parameters, CancellationToken cancellationToken = default)
        {
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, vmName, parameters, cancellationToken);
                return new OvenCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, vmName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<OvenCreateOrUpdateOperation> StartCreateOrUpdateAsync(string vmName, OvenData parameters, CancellationToken cancellationToken = default)
        {
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, vmName, parameters, cancellationToken).ConfigureAwait(false);
                return new OvenCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, vmName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Oven> Get(string vmName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenContainer.Get");
            scope.Start();
            try
            {
                if (vmName == null)
                {
                    throw new ArgumentNullException(nameof(vmName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, vmName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Oven(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Oven>> GetAsync(string vmName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenContainer.Get");
            scope.Start();
            try
            {
                if (vmName == null)
                {
                    throw new ArgumentNullException(nameof(vmName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, vmName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Oven(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Oven> GetIfExists(string vmName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenContainer.GetIfExists");
            scope.Start();
            try
            {
                if (vmName == null)
                {
                    throw new ArgumentNullException(nameof(vmName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, vmName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Oven>(null, response.GetRawResponse())
                    : Response.FromValue(new Oven(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Oven>> GetIfExistsAsync(string vmName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenContainer.GetIfExists");
            scope.Start();
            try
            {
                if (vmName == null)
                {
                    throw new ArgumentNullException(nameof(vmName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, vmName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Oven>(null, response.GetRawResponse())
                    : Response.FromValue(new Oven(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string vmName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (vmName == null)
                {
                    throw new ArgumentNullException(nameof(vmName));
                }

                var response = GetIfExists(vmName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string vmName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (vmName == null)
                {
                    throw new ArgumentNullException(nameof(vmName));
                }

                var response = await GetIfExistsAsync(vmName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Oven" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Oven.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Oven" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Oven.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, Oven, OvenData> Construct() { }
    }
}
