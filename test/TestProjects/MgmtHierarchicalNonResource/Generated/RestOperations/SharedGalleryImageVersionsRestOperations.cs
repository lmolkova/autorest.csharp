// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using MgmtHierarchicalNonResource.Models;

namespace MgmtHierarchicalNonResource
{
    internal partial class SharedGalleryImageVersionsRestOperations
    {
        private readonly string _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SharedGalleryImageVersionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public SharedGalleryImageVersionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-06-01";
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Azure.ResourceManager.Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string location, string galleryUniqueName, string galleryImageName, SharedToValues? sharedTo)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/sharedGalleries/", false);
            uri.AppendPath(galleryUniqueName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (sharedTo != null)
            {
                uri.AppendQuery("sharedTo", sharedTo.Value.ToString(), true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> List shared gallery image versions by subscription id or tenant id. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="galleryUniqueName"/> or <paramref name="galleryImageName"/> is null. </exception>
        public async Task<Response<SharedGalleryImageVersionList>> ListAsync(string subscriptionId, string location, string galleryUniqueName, string galleryImageName, SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (galleryUniqueName == null)
            {
                throw new ArgumentNullException(nameof(galleryUniqueName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var message = CreateListRequest(subscriptionId, location, galleryUniqueName, galleryImageName, sharedTo);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedGalleryImageVersionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SharedGalleryImageVersionList.DeserializeSharedGalleryImageVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List shared gallery image versions by subscription id or tenant id. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="galleryUniqueName"/> or <paramref name="galleryImageName"/> is null. </exception>
        public Response<SharedGalleryImageVersionList> List(string subscriptionId, string location, string galleryUniqueName, string galleryImageName, SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (galleryUniqueName == null)
            {
                throw new ArgumentNullException(nameof(galleryUniqueName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var message = CreateListRequest(subscriptionId, location, galleryUniqueName, galleryImageName, sharedTo);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedGalleryImageVersionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SharedGalleryImageVersionList.DeserializeSharedGalleryImageVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string location, string galleryUniqueName, string galleryImageName, string galleryImageVersionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/sharedGalleries/", false);
            uri.AppendPath(galleryUniqueName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryImageVersionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Get a shared gallery image version by subscription id or tenant id. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="galleryUniqueName"/>, <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is null. </exception>
        public async Task<Response<SharedGalleryImageVersion>> GetAsync(string subscriptionId, string location, string galleryUniqueName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (galleryUniqueName == null)
            {
                throw new ArgumentNullException(nameof(galleryUniqueName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var message = CreateGetRequest(subscriptionId, location, galleryUniqueName, galleryImageName, galleryImageVersionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedGalleryImageVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SharedGalleryImageVersion.DeserializeSharedGalleryImageVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a shared gallery image version by subscription id or tenant id. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="galleryUniqueName"/>, <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is null. </exception>
        public Response<SharedGalleryImageVersion> Get(string subscriptionId, string location, string galleryUniqueName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (galleryUniqueName == null)
            {
                throw new ArgumentNullException(nameof(galleryUniqueName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var message = CreateGetRequest(subscriptionId, location, galleryUniqueName, galleryImageName, galleryImageVersionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedGalleryImageVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SharedGalleryImageVersion.DeserializeSharedGalleryImageVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string location, string galleryUniqueName, string galleryImageName, SharedToValues? sharedTo)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> List shared gallery image versions by subscription id or tenant id. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="galleryUniqueName"/> or <paramref name="galleryImageName"/> is null. </exception>
        public async Task<Response<SharedGalleryImageVersionList>> ListNextPageAsync(string nextLink, string subscriptionId, string location, string galleryUniqueName, string galleryImageName, SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (galleryUniqueName == null)
            {
                throw new ArgumentNullException(nameof(galleryUniqueName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, location, galleryUniqueName, galleryImageName, sharedTo);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedGalleryImageVersionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SharedGalleryImageVersionList.DeserializeSharedGalleryImageVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List shared gallery image versions by subscription id or tenant id. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="galleryUniqueName"/> or <paramref name="galleryImageName"/> is null. </exception>
        public Response<SharedGalleryImageVersionList> ListNextPage(string nextLink, string subscriptionId, string location, string galleryUniqueName, string galleryImageName, SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (galleryUniqueName == null)
            {
                throw new ArgumentNullException(nameof(galleryUniqueName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, location, galleryUniqueName, galleryImageName, sharedTo);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedGalleryImageVersionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SharedGalleryImageVersionList.DeserializeSharedGalleryImageVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
