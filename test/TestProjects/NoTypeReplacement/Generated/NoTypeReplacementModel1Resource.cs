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
using Azure.ResourceManager.Resources;

namespace NoTypeReplacement
{
    /// <summary>
    /// A Class representing a NoTypeReplacementModel1 along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NoTypeReplacementModel1Resource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNoTypeReplacementModel1Resource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetNoTypeReplacementModel1 method.
    /// </summary>
    public partial class NoTypeReplacementModel1Resource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NoTypeReplacementModel1Resource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string noTypeReplacementModel1SName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel1s/{noTypeReplacementModel1SName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _noTypeReplacementModel1ClientDiagnostics;
        private readonly NoTypeReplacementModel1SRestOperations _noTypeReplacementModel1RestClient;
        private readonly NoTypeReplacementModel1Data _data;

        /// <summary> Initializes a new instance of the <see cref="NoTypeReplacementModel1Resource"/> class for mocking. </summary>
        protected NoTypeReplacementModel1Resource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NoTypeReplacementModel1Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NoTypeReplacementModel1Resource(ArmClient client, NoTypeReplacementModel1Data data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NoTypeReplacementModel1Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NoTypeReplacementModel1Resource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _noTypeReplacementModel1ClientDiagnostics = new ClientDiagnostics("NoTypeReplacement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string noTypeReplacementModel1ApiVersion);
            _noTypeReplacementModel1RestClient = new NoTypeReplacementModel1SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, noTypeReplacementModel1ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/noTypeReplacementModel1s";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NoTypeReplacementModel1Data Data
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel1s/{noTypeReplacementModel1sName}
        /// Operation Id: NoTypeReplacementModel1s_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NoTypeReplacementModel1Resource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _noTypeReplacementModel1ClientDiagnostics.CreateScope("NoTypeReplacementModel1Resource.Get");
            scope.Start();
            try
            {
                var response = await _noTypeReplacementModel1RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NoTypeReplacementModel1Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel1s/{noTypeReplacementModel1sName}
        /// Operation Id: NoTypeReplacementModel1s_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NoTypeReplacementModel1Resource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _noTypeReplacementModel1ClientDiagnostics.CreateScope("NoTypeReplacementModel1Resource.Get");
            scope.Start();
            try
            {
                var response = _noTypeReplacementModel1RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NoTypeReplacementModel1Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
