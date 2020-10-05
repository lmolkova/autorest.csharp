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

namespace LiveVideoAnalytics
{
    internal partial class LiveVideoAnalyticsRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of LiveVideoAnalyticsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public LiveVideoAnalyticsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGraphTopologyListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphTopology", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves a list of graph topologies that have been added to the Live Video Analytics IoT Edge module. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<MediaGraphTopologyCollection>> GraphTopologyListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGraphTopologyListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaGraphTopologyCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaGraphTopologyCollection.DeserializeMediaGraphTopologyCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves a list of graph topologies that have been added to the Live Video Analytics IoT Edge module. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<MediaGraphTopologyCollection> GraphTopologyList(CancellationToken cancellationToken = default)
        {
            using var message = CreateGraphTopologyListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaGraphTopologyCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaGraphTopologyCollection.DeserializeMediaGraphTopologyCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphTopologySetRequest(MediaGraphTopology topology)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphTopology", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(topology);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new topology or updates an existing one, with the given name. A topology is a blueprint defining what nodes are in a graph, and how they are interconnected. </summary>
        /// <param name="topology"> The MediaGraphTopology to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topology"/> is null. </exception>
        public async Task<Response<MediaGraphTopology>> GraphTopologySetAsync(MediaGraphTopology topology, CancellationToken cancellationToken = default)
        {
            if (topology == null)
            {
                throw new ArgumentNullException(nameof(topology));
            }

            using var message = CreateGraphTopologySetRequest(topology);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        MediaGraphTopology value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaGraphTopology.DeserializeMediaGraphTopology(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new topology or updates an existing one, with the given name. A topology is a blueprint defining what nodes are in a graph, and how they are interconnected. </summary>
        /// <param name="topology"> The MediaGraphTopology to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topology"/> is null. </exception>
        public Response<MediaGraphTopology> GraphTopologySet(MediaGraphTopology topology, CancellationToken cancellationToken = default)
        {
            if (topology == null)
            {
                throw new ArgumentNullException(nameof(topology));
            }

            using var message = CreateGraphTopologySetRequest(topology);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        MediaGraphTopology value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaGraphTopology.DeserializeMediaGraphTopology(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphTopologyGetRequest(string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphTopology/", false);
            uri.AppendPath(name, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves a graph topology by name. If a topology with that name has been previously set, then the call will return the JSON representation of that topology. </summary>
        /// <param name="name"> Name of the graph topology to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async Task<Response<MediaGraphTopology>> GraphTopologyGetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphTopologyGetRequest(name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaGraphTopology value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaGraphTopology.DeserializeMediaGraphTopology(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue<MediaGraphTopology>(null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves a graph topology by name. If a topology with that name has been previously set, then the call will return the JSON representation of that topology. </summary>
        /// <param name="name"> Name of the graph topology to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Response<MediaGraphTopology> GraphTopologyGet(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphTopologyGetRequest(name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaGraphTopology value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaGraphTopology.DeserializeMediaGraphTopology(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue<MediaGraphTopology>(null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphTopologyDeleteRequest(string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphTopology/", false);
            uri.AppendPath(name, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes a graph topology with the given name. This method should be called after all instances of the topology have been stopped and deleted. </summary>
        /// <param name="name"> Name of the graph topology to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async Task<Response> GraphTopologyDeleteAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphTopologyDeleteRequest(name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a graph topology with the given name. This method should be called after all instances of the topology have been stopped and deleted. </summary>
        /// <param name="name"> Name of the graph topology to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Response GraphTopologyDelete(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphTopologyDeleteRequest(name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphInstanceListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphInstance", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves a list of graph instances, if any, that have been created in the Live Video Analytics IoT Edge module. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<MediaGraphInstanceCollection>> GraphInstanceListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGraphInstanceListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaGraphInstanceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaGraphInstanceCollection.DeserializeMediaGraphInstanceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves a list of graph instances, if any, that have been created in the Live Video Analytics IoT Edge module. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<MediaGraphInstanceCollection> GraphInstanceList(CancellationToken cancellationToken = default)
        {
            using var message = CreateGraphInstanceListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaGraphInstanceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaGraphInstanceCollection.DeserializeMediaGraphInstanceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphInstanceSetRequest(MediaGraphInstance instance)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphInstance", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(instance);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a graph instance. </summary>
        /// <param name="instance"> The MediaGraphInstance to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        public async Task<Response<MediaGraphInstance>> GraphInstanceSetAsync(MediaGraphInstance instance, CancellationToken cancellationToken = default)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            using var message = CreateGraphInstanceSetRequest(instance);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        MediaGraphInstance value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaGraphInstance.DeserializeMediaGraphInstance(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a graph instance. </summary>
        /// <param name="instance"> The MediaGraphInstance to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        public Response<MediaGraphInstance> GraphInstanceSet(MediaGraphInstance instance, CancellationToken cancellationToken = default)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            using var message = CreateGraphInstanceSetRequest(instance);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        MediaGraphInstance value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaGraphInstance.DeserializeMediaGraphInstance(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphInstanceGetRequest(string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphInstance/", false);
            uri.AppendPath(name, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves a  graph instance by name. If a graph instance with that name has been previously created, then the direct method call will return the JSON representation of that instance. </summary>
        /// <param name="name"> Name of the graph instance to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async Task<Response<MediaGraphInstance>> GraphInstanceGetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphInstanceGetRequest(name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaGraphInstance value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaGraphInstance.DeserializeMediaGraphInstance(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue<MediaGraphInstance>(null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves a  graph instance by name. If a graph instance with that name has been previously created, then the direct method call will return the JSON representation of that instance. </summary>
        /// <param name="name"> Name of the graph instance to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Response<MediaGraphInstance> GraphInstanceGet(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphInstanceGetRequest(name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaGraphInstance value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaGraphInstance.DeserializeMediaGraphInstance(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue<MediaGraphInstance>(null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphInstanceDeleteRequest(string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphInstance/", false);
            uri.AppendPath(name, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes a graph instance. </summary>
        /// <param name="name"> Name of the graph instance to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async Task<Response> GraphInstanceDeleteAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphInstanceDeleteRequest(name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a graph instance. </summary>
        /// <param name="name"> Name of the graph instance to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Response GraphInstanceDelete(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphInstanceDeleteRequest(name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphInstanceActivateRequest(string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphInstance/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/activate", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Activates a graph instance with the name provided, if it exists. </summary>
        /// <param name="name"> Name of the graph instance to be activated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async Task<Response> GraphInstanceActivateAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphInstanceActivateRequest(name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Activates a graph instance with the name provided, if it exists. </summary>
        /// <param name="name"> Name of the graph instance to be activated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Response GraphInstanceActivate(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphInstanceActivateRequest(name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGraphInstanceDeactivateRequest(string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/GraphInstance/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/deactivate", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deactivates a graph instance with the name provided, if it is active. </summary>
        /// <param name="name"> Name of the graph instance to be deactivated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async Task<Response> GraphInstanceDeactivateAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphInstanceDeactivateRequest(name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deactivates a graph instance with the name provided, if it is active. </summary>
        /// <param name="name"> Name of the graph instance to be deactivated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Response GraphInstanceDeactivate(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGraphInstanceDeactivateRequest(name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
