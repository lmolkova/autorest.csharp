// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using DataProtection.Models;

namespace DataProtection
{
    /// <summary> The Lro service client. </summary>
    public partial class LroClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LroRestClient RestClient { get; }

        /// <summary> Initializes a new instance of LroClient for mocking. </summary>
        protected LroClient()
        {
        }

        /// <summary> Initializes a new instance of LroClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        internal LroClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2022-03-01")
        {
            RestClient = new LroRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the status of an LRO. </summary>
        /// <param name="operationId"> Unique id of the LRO. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> Unique id of the resource. </param>
        /// <param name="taskId"> Unique id of the current task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Models.Response>> GetAsync(string operationId, string subscriptionId, string resourceId, string taskId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LroClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(operationId, subscriptionId, resourceId, taskId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the status of an LRO. </summary>
        /// <param name="operationId"> Unique id of the LRO. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> Unique id of the resource. </param>
        /// <param name="taskId"> Unique id of the current task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Models.Response> Get(string operationId, string subscriptionId, string resourceId, string taskId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LroClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(operationId, subscriptionId, resourceId, taskId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the LRO. </summary>
        /// <param name="operationId"> Unique id of the LRO. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> Unique id of the resource. </param>
        /// <param name="taskId"> Unique id of the current task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Azure.Response> DeleteAsync(string operationId, string subscriptionId, string resourceId, string taskId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LroClient.Delete");
            scope.Start();
            try
            {
                return (await RestClient.DeleteAsync(operationId, subscriptionId, resourceId, taskId, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the LRO. </summary>
        /// <param name="operationId"> Unique id of the LRO. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> Unique id of the resource. </param>
        /// <param name="taskId"> Unique id of the current task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Azure.Response Delete(string operationId, string subscriptionId, string resourceId, string taskId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LroClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(operationId, subscriptionId, resourceId, taskId, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel the operation. Poll the LRO to get the final status. </summary>
        /// <param name="operationId"> operationId of the original request. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> unique id of the resource. </param>
        /// <param name="taskId"> unique id of the current task. </param>
        /// <param name="parameters"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SyncResponse>> CancelAsync(string operationId, string subscriptionId, string resourceId, string taskId, CancelRequest parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LroClient.Cancel");
            scope.Start();
            try
            {
                return await RestClient.CancelAsync(operationId, subscriptionId, resourceId, taskId, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel the operation. Poll the LRO to get the final status. </summary>
        /// <param name="operationId"> operationId of the original request. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> unique id of the resource. </param>
        /// <param name="taskId"> unique id of the current task. </param>
        /// <param name="parameters"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SyncResponse> Cancel(string operationId, string subscriptionId, string resourceId, string taskId, CancelRequest parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LroClient.Cancel");
            scope.Start();
            try
            {
                return RestClient.Cancel(operationId, subscriptionId, resourceId, taskId, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Refresh tokens for a given operation. </summary>
        /// <param name="operationId"> operationId of the original request. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> unique id of the resource. </param>
        /// <param name="taskId"> unique id of the current task. </param>
        /// <param name="parameters"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SyncResponse>> RefreshTokensAsync(string operationId, string subscriptionId, string resourceId, string taskId, RefreshTokensRequest parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LroClient.RefreshTokens");
            scope.Start();
            try
            {
                return await RestClient.RefreshTokensAsync(operationId, subscriptionId, resourceId, taskId, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Refresh tokens for a given operation. </summary>
        /// <param name="operationId"> operationId of the original request. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> unique id of the resource. </param>
        /// <param name="taskId"> unique id of the current task. </param>
        /// <param name="parameters"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SyncResponse> RefreshTokens(string operationId, string subscriptionId, string resourceId, string taskId, RefreshTokensRequest parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LroClient.RefreshTokens");
            scope.Start();
            try
            {
                return RestClient.RefreshTokens(operationId, subscriptionId, resourceId, taskId, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
