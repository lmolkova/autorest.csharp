// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> General information regarding the current resource. </summary>
    public partial class GetInfoResponse
    {
        /// <summary> Initializes a new instance of GetInfoResponse. </summary>
        /// <param name="customDocumentModels"> Info regarding custom document models. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDocumentModels"/> is null. </exception>
        internal GetInfoResponse(CustomDocumentModelsInfo customDocumentModels)
        {
            if (customDocumentModels == null)
            {
                throw new ArgumentNullException(nameof(customDocumentModels));
            }

            CustomDocumentModels = customDocumentModels;
        }

        /// <summary> Info regarding custom document models. </summary>
        public CustomDocumentModelsInfo CustomDocumentModels { get; }
    }
}
