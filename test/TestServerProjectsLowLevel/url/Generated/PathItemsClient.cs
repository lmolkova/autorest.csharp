// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace url_LowLevel
{
    /// <summary> The PathItems service client. </summary>
    public partial class PathItemsClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private string globalStringPath;
        private Uri endpoint;
        private string globalStringQuery;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of PathItemsClient for mocking. </summary>
        protected PathItemsClient()
        {
        }

        /// <summary> Initializes a new instance of PathItemsClient. </summary>
        /// <param name="globalStringPath"> A string value &apos;globalItemStringPath&apos; that appears in the path. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="globalStringQuery"> should contain value null. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PathItemsClient(string globalStringPath, AzureKeyCredential credential, Uri endpoint = null, string globalStringQuery = null, AutoRestUrlTestServiceClientOptions options = null)
        {
            if (globalStringPath == null)
            {
                throw new ArgumentNullException(nameof(globalStringPath));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new AutoRestUrlTestServiceClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            var authPolicy = new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.globalStringPath = globalStringPath;
            this.endpoint = endpoint;
            this.globalStringQuery = globalStringQuery;
            apiVersion = options.Version;
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=&apos;globalStringQuery&apos;, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=&apos;localStringQuery&apos;. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetAllWithValuesAsync(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetAllWithValuesRequest(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, options);

            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetAllWithValues");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=&apos;globalStringQuery&apos;, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=&apos;localStringQuery&apos;. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetAllWithValues(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetAllWithValuesRequest(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, options);

            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetAllWithValues");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetAllWithValues"/> and <see cref="GetAllWithValuesAsync"/> operations. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetAllWithValuesRequest(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/pathitem/nullable/globalStringPath/", false);
            uri.AppendPath(globalStringPath, true);
            uri.AppendPath("/pathItemStringPath/", false);
            uri.AppendPath(pathItemStringPath, true);
            uri.AppendPath("/localStringPath/", false);
            uri.AppendPath(localStringPath, true);
            uri.AppendPath("/globalStringQuery/pathItemStringQuery/localStringQuery", false);
            if (pathItemStringQuery != null)
            {
                uri.AppendQuery("pathItemStringQuery", pathItemStringQuery, true);
            }
            if (globalStringQuery != null)
            {
                uri.AppendQuery("globalStringQuery", globalStringQuery, true);
            }
            if (localStringQuery != null)
            {
                uri.AppendQuery("localStringQuery", localStringQuery, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=null, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=&apos;localStringQuery&apos;. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetGlobalQueryNullAsync(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetGlobalQueryNullRequest(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, options);

            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetGlobalQueryNull");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=null, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=&apos;localStringQuery&apos;. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetGlobalQueryNull(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetGlobalQueryNullRequest(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, options);

            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetGlobalQueryNull");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetGlobalQueryNull"/> and <see cref="GetGlobalQueryNullAsync"/> operations. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain value &apos;localStringQuery&apos;. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetGlobalQueryNullRequest(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/pathitem/nullable/globalStringPath/", false);
            uri.AppendPath(globalStringPath, true);
            uri.AppendPath("/pathItemStringPath/", false);
            uri.AppendPath(pathItemStringPath, true);
            uri.AppendPath("/localStringPath/", false);
            uri.AppendPath(localStringPath, true);
            uri.AppendPath("/null/pathItemStringQuery/localStringQuery", false);
            if (pathItemStringQuery != null)
            {
                uri.AppendQuery("pathItemStringQuery", pathItemStringQuery, true);
            }
            if (globalStringQuery != null)
            {
                uri.AppendQuery("globalStringQuery", globalStringQuery, true);
            }
            if (localStringQuery != null)
            {
                uri.AppendQuery("localStringQuery", localStringQuery, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> send globalStringPath=globalStringPath, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=null, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=null. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain null value. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetGlobalAndLocalQueryNullAsync(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetGlobalAndLocalQueryNullRequest(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, options);

            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetGlobalAndLocalQueryNull");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=globalStringPath, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=null, pathItemStringQuery=&apos;pathItemStringQuery&apos;, localStringQuery=null. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain null value. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetGlobalAndLocalQueryNull(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetGlobalAndLocalQueryNullRequest(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, options);

            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetGlobalAndLocalQueryNull");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetGlobalAndLocalQueryNull"/> and <see cref="GetGlobalAndLocalQueryNullAsync"/> operations. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> A string value &apos;pathItemStringQuery&apos; that appears as a query parameter. </param>
        /// <param name="localStringQuery"> should contain null value. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetGlobalAndLocalQueryNullRequest(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/pathitem/nullable/globalStringPath/", false);
            uri.AppendPath(globalStringPath, true);
            uri.AppendPath("/pathItemStringPath/", false);
            uri.AppendPath(pathItemStringPath, true);
            uri.AppendPath("/localStringPath/", false);
            uri.AppendPath(localStringPath, true);
            uri.AppendPath("/null/pathItemStringQuery/null", false);
            if (pathItemStringQuery != null)
            {
                uri.AppendQuery("pathItemStringQuery", pathItemStringQuery, true);
            }
            if (globalStringQuery != null)
            {
                uri.AppendQuery("globalStringQuery", globalStringQuery, true);
            }
            if (localStringQuery != null)
            {
                uri.AppendQuery("localStringQuery", localStringQuery, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=&apos;globalStringQuery&apos;, pathItemStringQuery=null, localStringQuery=null. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> should contain value null. </param>
        /// <param name="localStringQuery"> should contain value null. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetLocalPathItemQueryNullAsync(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetLocalPathItemQueryNullRequest(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, options);

            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetLocalPathItemQueryNull");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> send globalStringPath=&apos;globalStringPath&apos;, pathItemStringPath=&apos;pathItemStringPath&apos;, localStringPath=&apos;localStringPath&apos;, globalStringQuery=&apos;globalStringQuery&apos;, pathItemStringQuery=null, localStringQuery=null. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> should contain value null. </param>
        /// <param name="localStringQuery"> should contain value null. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetLocalPathItemQueryNull(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetLocalPathItemQueryNullRequest(pathItemStringPath, localStringPath, pathItemStringQuery, localStringQuery, options);

            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PathItemsClient.GetLocalPathItemQueryNull");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetLocalPathItemQueryNull"/> and <see cref="GetLocalPathItemQueryNullAsync"/> operations. </summary>
        /// <param name="pathItemStringPath"> A string value &apos;pathItemStringPath&apos; that appears in the path. </param>
        /// <param name="localStringPath"> should contain value &apos;localStringPath&apos;. </param>
        /// <param name="pathItemStringQuery"> should contain value null. </param>
        /// <param name="localStringQuery"> should contain value null. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetLocalPathItemQueryNullRequest(string pathItemStringPath, string localStringPath, string pathItemStringQuery = null, string localStringQuery = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/pathitem/nullable/globalStringPath/", false);
            uri.AppendPath(globalStringPath, true);
            uri.AppendPath("/pathItemStringPath/", false);
            uri.AppendPath(pathItemStringPath, true);
            uri.AppendPath("/localStringPath/", false);
            uri.AppendPath(localStringPath, true);
            uri.AppendPath("/globalStringQuery/null/null", false);
            if (pathItemStringQuery != null)
            {
                uri.AppendQuery("pathItemStringQuery", pathItemStringQuery, true);
            }
            if (globalStringQuery != null)
            {
                uri.AppendQuery("globalStringQuery", globalStringQuery, true);
            }
            if (localStringQuery != null)
            {
                uri.AppendQuery("localStringQuery", localStringQuery, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
