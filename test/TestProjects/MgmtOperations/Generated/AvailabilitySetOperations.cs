// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using MgmtOperations.Models;

namespace MgmtOperations
{
    /// <summary> A class representing the operations that can be performed over a specific AvailabilitySet. </summary>
    public partial class AvailabilitySetOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, AvailabilitySet>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private AvailabilitySetsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetOperations"/> class for mocking. </summary>
        protected AvailabilitySetOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal AvailabilitySetOperations(OperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new AvailabilitySetsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/availabilitySets";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<AvailabilitySet>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<AvailabilitySet> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an availability set. </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AvailabilitySet>> GetAsync(string expand, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an availability set. </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AvailabilitySet> Get(string expand, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<Location>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public IEnumerable<Location> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Delete an availability set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an availability set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an availability set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<AvailabilitySetsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new AvailabilitySetsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an availability set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public AvailabilitySetsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new AvailabilitySetsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async Task<Response<AvailabilitySet>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySet(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public Response<AvailabilitySet> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new AvailabilitySet(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async Task<Response<AvailabilitySet>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.SetTags");
            scope.Start();
            try
            {
                await TagResourceOperations.DeleteAsync(cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySet(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public Response<AvailabilitySet> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.SetTags");
            scope.Start();
            try
            {
                TagResourceOperations.Delete(cancellationToken);
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new AvailabilitySet(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async Task<Response<AvailabilitySet>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySet(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public Response<AvailabilitySet> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new AvailabilitySet(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Lists all availability sets in a resource group. </summary>
        /// <param name="requiredParam"> The expand expression to apply on the operation. </param>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredParam"/> is null. </exception>
        public virtual async Task<Response<IReadOnlyList<AvailabilitySet>>> TestMethodAsync(string requiredParam, string optionalParam = null, CancellationToken cancellationToken = default)
        {
            if (requiredParam == null)
            {
                throw new ArgumentNullException(nameof(requiredParam));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.TestMethod");
            scope.Start();
            try
            {
                var response = await _restClient.TestMethodAsync(Id.ResourceGroupName, requiredParam, optionalParam, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new AvailabilitySet(this, data)).ToArray() as IReadOnlyList<AvailabilitySet>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all availability sets in a resource group. </summary>
        /// <param name="requiredParam"> The expand expression to apply on the operation. </param>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredParam"/> is null. </exception>
        public virtual Response<IReadOnlyList<AvailabilitySet>> TestMethod(string requiredParam, string optionalParam = null, CancellationToken cancellationToken = default)
        {
            if (requiredParam == null)
            {
                throw new ArgumentNullException(nameof(requiredParam));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.TestMethod");
            scope.Start();
            try
            {
                var response = _restClient.TestMethod(Id.ResourceGroupName, requiredParam, optionalParam, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new AvailabilitySet(this, data)).ToArray() as IReadOnlyList<AvailabilitySet>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Testing description. </summary>
        /// <param name="parameters"> Parameters supplied to the Begin Set Virtual Network Gateway connection Shared key operation throughNetwork resource provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<Response<ConnectionSharedKey>> TestSetSharedKeyAsync(ConnectionSharedKey parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.TestSetSharedKey");
            scope.Start();
            try
            {
                var operation = await StartTestSetSharedKeyAsync(parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Testing description. </summary>
        /// <param name="parameters"> Parameters supplied to the Begin Set Virtual Network Gateway connection Shared key operation throughNetwork resource provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public Response<ConnectionSharedKey> TestSetSharedKey(ConnectionSharedKey parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.TestSetSharedKey");
            scope.Start();
            try
            {
                var operation = StartTestSetSharedKey(parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Testing description. </summary>
        /// <param name="parameters"> Parameters supplied to the Begin Set Virtual Network Gateway connection Shared key operation throughNetwork resource provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<AvailabilitySetsTestSetSharedKeyOperation> StartTestSetSharedKeyAsync(ConnectionSharedKey parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartTestSetSharedKey");
            scope.Start();
            try
            {
                var response = await _restClient.TestSetSharedKeyAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return new AvailabilitySetsTestSetSharedKeyOperation(_clientDiagnostics, Pipeline, _restClient.CreateTestSetSharedKeyRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Testing description. </summary>
        /// <param name="parameters"> Parameters supplied to the Begin Set Virtual Network Gateway connection Shared key operation throughNetwork resource provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public AvailabilitySetsTestSetSharedKeyOperation StartTestSetSharedKey(ConnectionSharedKey parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartTestSetSharedKey");
            scope.Start();
            try
            {
                var response = _restClient.TestSetSharedKey(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return new AvailabilitySetsTestSetSharedKeyOperation(_clientDiagnostics, Pipeline, _restClient.CreateTestSetSharedKeyRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an availability set. </summary>
        /// <param name="parameters"> Parameters supplied to the Update Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<Response<TestAvailabilitySet>> TestLROMethodAsync(AvailabilitySetUpdate parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.TestLROMethod");
            scope.Start();
            try
            {
                var operation = await StartTestLROMethodAsync(parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an availability set. </summary>
        /// <param name="parameters"> Parameters supplied to the Update Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public Response<TestAvailabilitySet> TestLROMethod(AvailabilitySetUpdate parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.TestLROMethod");
            scope.Start();
            try
            {
                var operation = StartTestLROMethod(parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an availability set. </summary>
        /// <param name="parameters"> Parameters supplied to the Update Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<AvailabilitySetsTestLROMethodOperation> StartTestLROMethodAsync(AvailabilitySetUpdate parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartTestLROMethod");
            scope.Start();
            try
            {
                var response = await _restClient.TestLROMethodAsync(Id.ResourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return new AvailabilitySetsTestLROMethodOperation(_clientDiagnostics, Pipeline, _restClient.CreateTestLROMethodRequest(Id.ResourceGroupName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an availability set. </summary>
        /// <param name="parameters"> Parameters supplied to the Update Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public AvailabilitySetsTestLROMethodOperation StartTestLROMethod(AvailabilitySetUpdate parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartTestLROMethod");
            scope.Start();
            try
            {
                var response = _restClient.TestLROMethod(Id.ResourceGroupName, parameters, cancellationToken);
                return new AvailabilitySetsTestLROMethodOperation(_clientDiagnostics, Pipeline, _restClient.CreateTestLROMethodRequest(Id.ResourceGroupName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of AvailabilitySetChildren in the AvailabilitySet. </summary>
        /// <returns> An object representing collection of AvailabilitySetChildren and their operations over a AvailabilitySet. </returns>
        public AvailabilitySetChildContainer GetAvailabilitySetChildren()
        {
            return new AvailabilitySetChildContainer(this);
        }
    }
}
