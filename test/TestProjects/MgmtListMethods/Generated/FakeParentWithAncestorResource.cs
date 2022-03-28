// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace MgmtListMethods
{
    /// <summary>
    /// A Class representing a FakeParentWithAncestor along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="FakeParentWithAncestorResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetFakeParentWithAncestorResource method.
    /// Otherwise you can get one from its parent resource <see cref="FakeResource" /> using the GetFakeParentWithAncestor method.
    /// </summary>
    public partial class FakeParentWithAncestorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FakeParentWithAncestorResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string fakeName, string fakeParentWithAncestorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _fakeParentWithAncestorClientDiagnostics;
        private readonly FakeParentWithAncestorsRestOperations _fakeParentWithAncestorRestClient;
        private readonly FakeParentWithAncestorData _data;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorResource"/> class for mocking. </summary>
        protected FakeParentWithAncestorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FakeParentWithAncestorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FakeParentWithAncestorResource(ArmClient client, FakeParentWithAncestorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FakeParentWithAncestorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fakeParentWithAncestorClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string fakeParentWithAncestorApiVersion);
            _fakeParentWithAncestorRestClient = new FakeParentWithAncestorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fakeParentWithAncestorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Fake/fakes/fakeParentWithAncestors";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FakeParentWithAncestorData Data
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
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}
        /// Operation Id: FakeParentWithAncestors_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FakeParentWithAncestorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _fakeParentWithAncestorClientDiagnostics.CreateScope("FakeParentWithAncestorResource.Get");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}
        /// Operation Id: FakeParentWithAncestors_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FakeParentWithAncestorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _fakeParentWithAncestorClientDiagnostics.CreateScope("FakeParentWithAncestorResource.Get");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}
        /// Operation Id: FakeParentWithAncestors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _fakeParentWithAncestorClientDiagnostics.CreateScope("FakeParentWithAncestorResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _fakeParentWithAncestorRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}
        /// Operation Id: FakeParentWithAncestors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _fakeParentWithAncestorClientDiagnostics.CreateScope("FakeParentWithAncestorResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _fakeParentWithAncestorRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new FakeParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}
        /// Operation Id: FakeParentWithAncestors_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _fakeParentWithAncestorClientDiagnostics.CreateScope("FakeParentWithAncestorResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _fakeParentWithAncestorRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}
        /// Operation Id: FakeParentWithAncestors_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _fakeParentWithAncestorClientDiagnostics.CreateScope("FakeParentWithAncestorResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _fakeParentWithAncestorRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new FakeParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}
        /// Operation Id: FakeParentWithAncestors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _fakeParentWithAncestorClientDiagnostics.CreateScope("FakeParentWithAncestorResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _fakeParentWithAncestorRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestors/{fakeParentWithAncestorName}
        /// Operation Id: FakeParentWithAncestors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _fakeParentWithAncestorClientDiagnostics.CreateScope("FakeParentWithAncestorResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _fakeParentWithAncestorRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new FakeParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
