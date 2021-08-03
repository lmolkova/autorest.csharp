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
using MgmtParamOrdering.Models;

namespace MgmtParamOrdering
{
    /// <summary> A class representing collection of DedicatedHostGroup and their operations over a ResourceGroup. </summary>
    public partial class DedicatedHostGroupContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="DedicatedHostGroupContainer"/> class for mocking. </summary>
        protected DedicatedHostGroupContainer()
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostGroupContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DedicatedHostGroupContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DedicatedHostGroupsRestOperations _restClient => new DedicatedHostGroupsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update a dedicated host group. For details of Dedicated Host and Dedicated Host Groups please see [Dedicated Host Documentation] (https://go.microsoft.com/fwlink/?linkid=2082596). </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<DedicatedHostGroup> CreateOrUpdate(string hostGroupName, DedicatedHostGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(hostGroupName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a dedicated host group. For details of Dedicated Host and Dedicated Host Groups please see [Dedicated Host Documentation] (https://go.microsoft.com/fwlink/?linkid=2082596). </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<DedicatedHostGroup>> CreateOrUpdateAsync(string hostGroupName, DedicatedHostGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(hostGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a dedicated host group. For details of Dedicated Host and Dedicated Host Groups please see [Dedicated Host Documentation] (https://go.microsoft.com/fwlink/?linkid=2082596). </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DedicatedHostGroupCreateOrUpdateOperation StartCreateOrUpdate(string hostGroupName, DedicatedHostGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, hostGroupName, parameters, cancellationToken);
                return new DedicatedHostGroupCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a dedicated host group. For details of Dedicated Host and Dedicated Host Groups please see [Dedicated Host Documentation] (https://go.microsoft.com/fwlink/?linkid=2082596). </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DedicatedHostGroupCreateOrUpdateOperation> StartCreateOrUpdateAsync(string hostGroupName, DedicatedHostGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, hostGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return new DedicatedHostGroupCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DedicatedHostGroup> Get(string hostGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.Get");
            scope.Start();
            try
            {
                if (hostGroupName == null)
                {
                    throw new ArgumentNullException(nameof(hostGroupName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, hostGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedHostGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DedicatedHostGroup>> GetAsync(string hostGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.Get");
            scope.Start();
            try
            {
                if (hostGroupName == null)
                {
                    throw new ArgumentNullException(nameof(hostGroupName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, hostGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DedicatedHostGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DedicatedHostGroup> GetIfExists(string hostGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                if (hostGroupName == null)
                {
                    throw new ArgumentNullException(nameof(hostGroupName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, hostGroupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DedicatedHostGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new DedicatedHostGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DedicatedHostGroup>> GetIfExistsAsync(string hostGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                if (hostGroupName == null)
                {
                    throw new ArgumentNullException(nameof(hostGroupName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, hostGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DedicatedHostGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new DedicatedHostGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string hostGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (hostGroupName == null)
                {
                    throw new ArgumentNullException(nameof(hostGroupName));
                }

                var response = GetIfExists(hostGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string hostGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (hostGroupName == null)
                {
                    throw new ArgumentNullException(nameof(hostGroupName));
                }

                var response = await GetIfExistsAsync(hostGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DedicatedHostGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DedicatedHostGroupOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DedicatedHostGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DedicatedHostGroupOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, DedicatedHostGroup, DedicatedHostGroupData> Construct() { }
    }
}
