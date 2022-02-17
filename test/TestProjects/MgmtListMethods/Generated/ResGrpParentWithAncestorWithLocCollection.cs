// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of ResGrpParentWithAncestorWithLoc and their operations over its parent. </summary>
    public partial class ResGrpParentWithAncestorWithLocCollection : ArmCollection, IEnumerable<ResGrpParentWithAncestorWithLoc>, IAsyncEnumerable<ResGrpParentWithAncestorWithLoc>
    {
        private readonly ClientDiagnostics _resGrpParentWithAncestorWithLocClientDiagnostics;
        private readonly ResGrpParentWithAncestorWithLocsRestOperations _resGrpParentWithAncestorWithLocRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentWithAncestorWithLocCollection"/> class for mocking. </summary>
        protected ResGrpParentWithAncestorWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentWithAncestorWithLocCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResGrpParentWithAncestorWithLocCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resGrpParentWithAncestorWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResGrpParentWithAncestorWithLoc.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResGrpParentWithAncestorWithLoc.ResourceType, out string resGrpParentWithAncestorWithLocApiVersion);
            _resGrpParentWithAncestorWithLocRestClient = new ResGrpParentWithAncestorWithLocsRestOperations(_resGrpParentWithAncestorWithLocClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, resGrpParentWithAncestorWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}
        /// Operation Id: ResGrpParentWithAncestorWithLocs_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ResGrpParentWithAncestorWithLoc>> CreateOrUpdateAsync(bool waitForCompletion, string resGrpParentWithAncestorWithLocName, ResGrpParentWithAncestorWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resGrpParentWithAncestorWithLocRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<ResGrpParentWithAncestorWithLoc>(Response.FromValue(new ResGrpParentWithAncestorWithLoc(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}
        /// Operation Id: ResGrpParentWithAncestorWithLocs_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ResGrpParentWithAncestorWithLoc> CreateOrUpdate(bool waitForCompletion, string resGrpParentWithAncestorWithLocName, ResGrpParentWithAncestorWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resGrpParentWithAncestorWithLocRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, parameters, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<ResGrpParentWithAncestorWithLoc>(Response.FromValue(new ResGrpParentWithAncestorWithLoc(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}
        /// Operation Id: ResGrpParentWithAncestorWithLocs_Get
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public async virtual Task<Response<ResGrpParentWithAncestorWithLoc>> GetAsync(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _resGrpParentWithAncestorWithLocRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _resGrpParentWithAncestorWithLocClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResGrpParentWithAncestorWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}
        /// Operation Id: ResGrpParentWithAncestorWithLocs_Get
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual Response<ResGrpParentWithAncestorWithLoc> Get(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _resGrpParentWithAncestorWithLocRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _resGrpParentWithAncestorWithLocClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs
        /// Operation Id: ResGrpParentWithAncestorWithLocs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResGrpParentWithAncestorWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResGrpParentWithAncestorWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResGrpParentWithAncestorWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resGrpParentWithAncestorWithLocRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResGrpParentWithAncestorWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResGrpParentWithAncestorWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resGrpParentWithAncestorWithLocRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResGrpParentWithAncestorWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs
        /// Operation Id: ResGrpParentWithAncestorWithLocs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResGrpParentWithAncestorWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResGrpParentWithAncestorWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ResGrpParentWithAncestorWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resGrpParentWithAncestorWithLocRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResGrpParentWithAncestorWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResGrpParentWithAncestorWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resGrpParentWithAncestorWithLocRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResGrpParentWithAncestorWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}
        /// Operation Id: ResGrpParentWithAncestorWithLocs_Get
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resGrpParentWithAncestorWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}
        /// Operation Id: ResGrpParentWithAncestorWithLocs_Get
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resGrpParentWithAncestorWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}
        /// Operation Id: ResGrpParentWithAncestorWithLocs_Get
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public async virtual Task<Response<ResGrpParentWithAncestorWithLoc>> GetIfExistsAsync(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resGrpParentWithAncestorWithLocRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ResGrpParentWithAncestorWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}
        /// Operation Id: ResGrpParentWithAncestorWithLocs_Get
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual Response<ResGrpParentWithAncestorWithLoc> GetIfExists(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resGrpParentWithAncestorWithLocRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ResGrpParentWithAncestorWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResGrpParentWithAncestorWithLoc> IEnumerable<ResGrpParentWithAncestorWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResGrpParentWithAncestorWithLoc> IAsyncEnumerable<ResGrpParentWithAncestorWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
