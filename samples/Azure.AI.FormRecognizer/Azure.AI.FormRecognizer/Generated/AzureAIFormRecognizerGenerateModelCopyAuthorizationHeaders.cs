// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.FormRecognizer
{
    internal class AzureAIFormRecognizerGenerateModelCopyAuthorizationHeaders
    {
        private readonly Response _response;
        public AzureAIFormRecognizerGenerateModelCopyAuthorizationHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Location and ID of the model being copied. The status of model copy is specified in the status property at the model location. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}
