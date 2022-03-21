// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace MgmtScopeResource
{
    /// <summary> A Class representing a ResourceLink along with the instance operations that can be performed on it. </summary>
    public partial class ResourceLink : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceLink"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string linkId)
        {
            var resourceId = $"{linkId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceLinkClientDiagnostics;
        private readonly ResourceLinksRestOperations _resourceLinkRestClient;
        private readonly ResourceLinkData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceLink"/> class for mocking. </summary>
        protected ResourceLink()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceLink"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceLink(ArmClient client, ResourceLinkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceLink"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceLink(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceLinkClientDiagnostics = new ClientDiagnostics("MgmtScopeResource", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceLinkApiVersion);
            _resourceLinkRestClient = new ResourceLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/links";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceLinkData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceLink>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceLinkClientDiagnostics.CreateScope("ResourceLink.Get");
            scope.Start();
            try
            {
                var response = await _resourceLinkRestClient.GetAsync(Id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceLink> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceLinkClientDiagnostics.CreateScope("ResourceLink.Get");
            scope.Start();
            try
            {
                var response = _resourceLinkRestClient.Get(Id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceLinkClientDiagnostics.CreateScope("ResourceLink.Delete");
            scope.Start();
            try
            {
                var response = await _resourceLinkRestClient.DeleteAsync(Id, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtScopeResourceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceLinkClientDiagnostics.CreateScope("ResourceLink.Delete");
            scope.Start();
            try
            {
                var response = _resourceLinkRestClient.Delete(Id, cancellationToken);
                var operation = new MgmtScopeResourceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
