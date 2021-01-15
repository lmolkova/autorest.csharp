// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using lro.Models;

namespace lro
{
    internal partial class LRORetrysRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of LRORetrysRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public LRORetrysRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreatePut201CreatingSucceeded200Request(Product product)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/lro/retryerror/put/201/creating/succeeded/200", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (product != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(product);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Long running put request, service returns a 500, then a 201 to the initial request, with an entity that contains ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Put201CreatingSucceeded200Async(Product product = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePut201CreatingSucceeded200Request(product);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Long running put request, service returns a 500, then a 201 to the initial request, with an entity that contains ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put201CreatingSucceeded200(Product product = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePut201CreatingSucceeded200Request(product);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutAsyncRelativeRetrySucceededRequest(Product product)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/lro/retryerror/putasync/retry/succeeded", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (product != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(product);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Long running put request, service returns a 500, then a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<LRORetrysPutAsyncRelativeRetrySucceededHeaders>> PutAsyncRelativeRetrySucceededAsync(Product product = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutAsyncRelativeRetrySucceededRequest(product);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LRORetrysPutAsyncRelativeRetrySucceededHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Long running put request, service returns a 500, then a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<LRORetrysPutAsyncRelativeRetrySucceededHeaders> PutAsyncRelativeRetrySucceeded(Product product = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutAsyncRelativeRetrySucceededRequest(product);
            _pipeline.Send(message, cancellationToken);
            var headers = new LRORetrysPutAsyncRelativeRetrySucceededHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteProvisioning202Accepted200SucceededRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/lro/retryerror/delete/provisioning/202/accepted/200/succeeded", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Long running delete request, service returns a 500, then a  202 to the initial request, with an entity that contains ProvisioningState=’Accepted’.  Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<LRORetrysDeleteProvisioning202Accepted200SucceededHeaders>> DeleteProvisioning202Accepted200SucceededAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteProvisioning202Accepted200SucceededRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LRORetrysDeleteProvisioning202Accepted200SucceededHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Long running delete request, service returns a 500, then a  202 to the initial request, with an entity that contains ProvisioningState=’Accepted’.  Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<LRORetrysDeleteProvisioning202Accepted200SucceededHeaders> DeleteProvisioning202Accepted200Succeeded(CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteProvisioning202Accepted200SucceededRequest();
            _pipeline.Send(message, cancellationToken);
            var headers = new LRORetrysDeleteProvisioning202Accepted200SucceededHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDelete202Retry200Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/lro/retryerror/delete/202/retry/200", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Long running delete request, service returns a 500, then a 202 to the initial request. Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<LRORetrysDelete202Retry200Headers>> Delete202Retry200Async(CancellationToken cancellationToken = default)
        {
            using var message = CreateDelete202Retry200Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LRORetrysDelete202Retry200Headers(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Long running delete request, service returns a 500, then a 202 to the initial request. Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<LRORetrysDelete202Retry200Headers> Delete202Retry200(CancellationToken cancellationToken = default)
        {
            using var message = CreateDelete202Retry200Request();
            _pipeline.Send(message, cancellationToken);
            var headers = new LRORetrysDelete202Retry200Headers(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteAsyncRelativeRetrySucceededRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/lro/retryerror/deleteasync/retry/succeeded", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Long running delete request, service returns a 500, then a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<LRORetrysDeleteAsyncRelativeRetrySucceededHeaders>> DeleteAsyncRelativeRetrySucceededAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteAsyncRelativeRetrySucceededRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LRORetrysDeleteAsyncRelativeRetrySucceededHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Long running delete request, service returns a 500, then a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<LRORetrysDeleteAsyncRelativeRetrySucceededHeaders> DeleteAsyncRelativeRetrySucceeded(CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteAsyncRelativeRetrySucceededRequest();
            _pipeline.Send(message, cancellationToken);
            var headers = new LRORetrysDeleteAsyncRelativeRetrySucceededHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePost202Retry200Request(Product product)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/lro/retryerror/post/202/retry/200", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (product != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(product);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Long running post request, service returns a 500, then a 202 to the initial request, with &apos;Location&apos; and &apos;Retry-After&apos; headers, Polls return a 200 with a response body after success. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<LRORetrysPost202Retry200Headers>> Post202Retry200Async(Product product = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePost202Retry200Request(product);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LRORetrysPost202Retry200Headers(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Long running post request, service returns a 500, then a 202 to the initial request, with &apos;Location&apos; and &apos;Retry-After&apos; headers, Polls return a 200 with a response body after success. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<LRORetrysPost202Retry200Headers> Post202Retry200(Product product = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePost202Retry200Request(product);
            _pipeline.Send(message, cancellationToken);
            var headers = new LRORetrysPost202Retry200Headers(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostAsyncRelativeRetrySucceededRequest(Product product)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/lro/retryerror/postasync/retry/succeeded", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (product != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(product);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Long running post request, service returns a 500, then a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<LRORetrysPostAsyncRelativeRetrySucceededHeaders>> PostAsyncRelativeRetrySucceededAsync(Product product = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostAsyncRelativeRetrySucceededRequest(product);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LRORetrysPostAsyncRelativeRetrySucceededHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Long running post request, service returns a 500, then a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<LRORetrysPostAsyncRelativeRetrySucceededHeaders> PostAsyncRelativeRetrySucceeded(Product product = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostAsyncRelativeRetrySucceededRequest(product);
            _pipeline.Send(message, cancellationToken);
            var headers = new LRORetrysPostAsyncRelativeRetrySucceededHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
