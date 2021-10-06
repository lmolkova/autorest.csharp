// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace HeadAsBooleanTrue_LowLevel
{
    /// <summary> The HttpSuccess service client. </summary>
    public partial class HttpSuccessClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of HttpSuccessClient for mocking. </summary>
        protected HttpSuccessClient()
        {
        }

        /// <summary> Initializes a new instance of HttpSuccessClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public HttpSuccessClient(AzureKeyCredential credential, Uri endpoint = null, HeadAsBooleanTrueClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new HeadAsBooleanTrueClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Return 200 status code if successful. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response<bool>> Head200Async(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head200");
            scope.Start();
            try
            {
                using HttpMessage message = CreateHead200Request();
                return await _pipeline.ProcessHeadAsBoolMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 200 status code if successful. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response<bool> Head200(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head200");
            scope.Start();
            try
            {
                using HttpMessage message = CreateHead200Request();
                return _pipeline.ProcessHeadAsBoolMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 204 status code if successful. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response<bool>> Head204Async(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head204");
            scope.Start();
            try
            {
                using HttpMessage message = CreateHead204Request();
                return await _pipeline.ProcessHeadAsBoolMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 204 status code if successful. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response<bool> Head204(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head204");
            scope.Start();
            try
            {
                using HttpMessage message = CreateHead204Request();
                return _pipeline.ProcessHeadAsBoolMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 404 status code if successful. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response<bool>> Head404Async(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head404");
            scope.Start();
            try
            {
                using HttpMessage message = CreateHead404Request();
                return await _pipeline.ProcessHeadAsBoolMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return 404 status code if successful. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response<bool> Head404(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("HttpSuccessClient.Head404");
            scope.Start();
            try
            {
                using HttpMessage message = CreateHead404Request();
                return _pipeline.ProcessHeadAsBoolMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateHead200Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/http/success/200", false);
            request.Uri = uri;
            message.ResponseClassifier = ResponseClassifier200To300400To500.Instance;
            return message;
        }

        internal HttpMessage CreateHead204Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/http/success/204", false);
            request.Uri = uri;
            message.ResponseClassifier = ResponseClassifier200To300400To500.Instance;
            return message;
        }

        internal HttpMessage CreateHead404Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/http/success/404", false);
            request.Uri = uri;
            message.ResponseClassifier = ResponseClassifier200To300400To500.Instance;
            return message;
        }

        private sealed class ResponseClassifier200To300400To500 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200To300400To500();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    >= 200 and < 300 => false,
                    >= 400 and < 500 => false,
                    _ => true
                };
            }
        }
    }
}
