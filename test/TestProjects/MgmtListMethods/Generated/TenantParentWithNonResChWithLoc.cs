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
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A Class representing a TenantParentWithNonResChWithLoc along with the instance operations that can be performed on it. </summary>
    public partial class TenantParentWithNonResChWithLoc : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantParentWithNonResChWithLoc"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string tenantTestName, string tenantParentWithNonResChWithLocName)
        {
            var resourceId = $"/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantParentWithNonResChWithLocClientDiagnostics;
        private readonly TenantParentWithNonResChWithLocsRestOperations _tenantParentWithNonResChWithLocRestClient;
        private readonly TenantParentWithNonResChWithLocData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantParentWithNonResChWithLoc"/> class for mocking. </summary>
        protected TenantParentWithNonResChWithLoc()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantParentWithNonResChWithLoc"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantParentWithNonResChWithLoc(ArmClient client, TenantParentWithNonResChWithLocData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantParentWithNonResChWithLoc"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantParentWithNonResChWithLoc(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantParentWithNonResChWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantParentWithNonResChWithLocApiVersion);
            _tenantParentWithNonResChWithLocRestClient = new TenantParentWithNonResChWithLocsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantParentWithNonResChWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Tenant/tenantTests/tenantParentWithNonResChWithLocs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TenantParentWithNonResChWithLocData Data
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
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantParentWithNonResChWithLoc>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.Get");
            scope.Start();
            try
            {
                var response = await _tenantParentWithNonResChWithLocRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantParentWithNonResChWithLoc> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.Get");
            scope.Start();
            try
            {
                var response = _tenantParentWithNonResChWithLocRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}/nonResourceChild
        /// Operation Id: TenantParentWithNonResChWithLocs_ListNonResourceChild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NonResourceChild" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NonResourceChild> GetNonResourceChildAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NonResourceChild>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.GetNonResourceChild");
                scope.Start();
                try
                {
                    var response = await _tenantParentWithNonResChWithLocRestClient.ListNonResourceChildAsync(Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}/nonResourceChild
        /// Operation Id: TenantParentWithNonResChWithLocs_ListNonResourceChild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NonResourceChild" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NonResourceChild> GetNonResourceChild(CancellationToken cancellationToken = default)
        {
            Page<NonResourceChild> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.GetNonResourceChild");
                scope.Start();
                try
                {
                    var response = _tenantParentWithNonResChWithLocRestClient.ListNonResourceChild(Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<TenantParentWithNonResChWithLoc>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _tenantParentWithNonResChWithLocRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<TenantParentWithNonResChWithLoc> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _tenantParentWithNonResChWithLocRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<TenantParentWithNonResChWithLoc>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.SetTags");
            scope.Start();
            try
            {
                await TagHelper.DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _tenantParentWithNonResChWithLocRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<TenantParentWithNonResChWithLoc> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.SetTags");
            scope.Start();
            try
            {
                TagHelper.Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _tenantParentWithNonResChWithLocRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<TenantParentWithNonResChWithLoc>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _tenantParentWithNonResChWithLocRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<TenantParentWithNonResChWithLoc> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _tenantParentWithNonResChWithLocClientDiagnostics.CreateScope("TenantParentWithNonResChWithLoc.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _tenantParentWithNonResChWithLocRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
