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

namespace Azure.AI.FormRecognizer
{
    /// <summary> Extract field text and semantic values from a given ID document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos;, &apos;image/tiff&apos; or &apos;image/bmp&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri) of the document to be analyzed. </summary>
    public partial class FormRecognizerAnalyzeIdDocumentAsyncOperation : Operation
    {
        private readonly OperationInternals _operation;

        /// <summary> Initializes a new instance of FormRecognizerAnalyzeIdDocumentAsyncOperation for mocking. </summary>
        protected FormRecognizerAnalyzeIdDocumentAsyncOperation()
        {
        }

        internal FormRecognizerAnalyzeIdDocumentAsyncOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals(clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "FormRecognizerAnalyzeIdDocumentAsyncOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}
