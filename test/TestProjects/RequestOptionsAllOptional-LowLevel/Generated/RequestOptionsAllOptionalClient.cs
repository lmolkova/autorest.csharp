// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace RequestOptionsAllOptional_LowLevel
{
    /// <summary> The RequestOptionsAllOptional service client. </summary>
    public partial class RequestOptionsAllOptionalClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of RequestOptionsAllOptionalClient for mocking. </summary>
        protected RequestOptionsAllOptionalClient()
        {
        }

        /// <summary> Initializes a new instance of RequestOptionsAllOptionalClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public RequestOptionsAllOptionalClient(AzureKeyCredential credential, Uri endpoint = null, RequestOptionsAllOptionalClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new RequestOptionsAllOptionalClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> No RequestBody and ResponseBody. </summary>
        /// <param name="id"> Query parameter Id. </param>
        /// <param name="top"> Query parameter top. </param>
        /// <param name="skip"> Query parameter skip. </param>
        /// <param name="status"> Query parameter status. </param>
        /// <param name="context"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> NoRequestBodyResponseBodyAsync(int id, int? top = null, int skip = 12, string status = "start", RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.NoRequestBodyResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateNoRequestBodyResponseBodyRequest(id, top, skip, status);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> No RequestBody and ResponseBody. </summary>
        /// <param name="id"> Query parameter Id. </param>
        /// <param name="top"> Query parameter top. </param>
        /// <param name="skip"> Query parameter skip. </param>
        /// <param name="status"> Query parameter status. </param>
        /// <param name="context"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response NoRequestBodyResponseBody(int id, int? top = null, int skip = 12, string status = "start", RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.NoRequestBodyResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateNoRequestBodyResponseBodyRequest(id, top, skip, status);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> RequestBody and ResponseBody. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   Code: string,
        ///   Status: string
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   Code: string,
        ///   Status: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> RequestBodyResponseBodyAsync(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.RequestBodyResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateRequestBodyResponseBodyRequest(content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> RequestBody and ResponseBody. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   Code: string,
        ///   Status: string
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   Code: string,
        ///   Status: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response RequestBodyResponseBody(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.RequestBodyResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateRequestBodyResponseBodyRequest(content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete. </summary>
        /// <param name="resourceName"> name. </param>
        /// <param name="context"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteNoRequestBodyResponseBodyAsync(string resourceName, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.DeleteNoRequestBodyResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteNoRequestBodyResponseBodyRequest(resourceName);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete. </summary>
        /// <param name="resourceName"> name. </param>
        /// <param name="context"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
#pragma warning disable AZC0002
        public virtual Response DeleteNoRequestBodyResponseBody(string resourceName, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.DeleteNoRequestBodyResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteNoRequestBodyResponseBodyRequest(resourceName);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> No RequestBody and No ResponseBody. </summary>
        /// <param name="context"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> NoRequestBodyNoResponseBodyAsync(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.NoRequestBodyNoResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateNoRequestBodyNoResponseBodyRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> No RequestBody and No ResponseBody. </summary>
        /// <param name="context"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response NoRequestBodyNoResponseBody(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.NoRequestBodyNoResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateNoRequestBodyNoResponseBodyRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> RequestBody and No ResponseBody. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> RequestBodyNoResponseBodyAsync(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.RequestBodyNoResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateRequestBodyNoResponseBodyRequest(content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> RequestBody and No ResponseBody. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response RequestBodyNoResponseBody(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestOptionsAllOptionalClient.RequestBodyNoResponseBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateRequestBodyNoResponseBodyRequest(content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateNoRequestBodyResponseBodyRequest(int id, int? top, int skip, string status)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/test1", false);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            uri.AppendQuery("id", id, true);
            uri.AppendQuery("skip", skip, true);
            if (status != null)
            {
                uri.AppendQuery("status", status, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateRequestBodyResponseBodyRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/test1", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateDeleteNoRequestBodyResponseBodyRequest(string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/test1", false);
            uri.AppendQuery("resourceName", resourceName, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateNoRequestBodyNoResponseBodyRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/test2", false);
            request.Uri = uri;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateRequestBodyNoResponseBodyRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/test2", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}
