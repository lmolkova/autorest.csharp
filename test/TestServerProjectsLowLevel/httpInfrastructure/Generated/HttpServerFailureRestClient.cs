// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace httpInfrastructure_LowLevel
{
    /// <summary> The HttpServerFailureRest service client. </summary>
    internal partial class HttpServerFailureRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of HttpServerFailureRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public HttpServerFailureRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("http://localhost:3000");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateHead501Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/failure/server/501", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Return 501 status code - should be represented in the client as an error. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> Head501Async(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateHead501Request();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Return 501 status code - should be represented in the client as an error. </summary>
        /// <param name="options"> The request options. </param>
        public Response Head501(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateHead501Request();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreateGet501Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/failure/server/501", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Return 501 status code - should be represented in the client as an error. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> Get501Async(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGet501Request();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Return 501 status code - should be represented in the client as an error. </summary>
        /// <param name="options"> The request options. </param>
        public Response Get501(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGet501Request();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreatePost505Request(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/failure/server/505", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Return 505 status code - should be represented in the client as an error. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public async Task<Response> Post505Async(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreatePost505Request(content);
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Return 505 status code - should be represented in the client as an error. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public Response Post505(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreatePost505Request(content);
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreateDelete505Request(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/failure/server/505", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Return 505 status code - should be represented in the client as an error. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public async Task<Response> Delete505Async(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateDelete505Request(content);
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Return 505 status code - should be represented in the client as an error. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public Response Delete505(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateDelete505Request(content);
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }
    }
}