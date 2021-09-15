// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Model info. </summary>
    public partial class DocumentModelInfo : ModelSummary
    {
        /// <summary> Initializes a new instance of DocumentModelInfo. </summary>
        /// <param name="modelId"> Unique model name. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the model was created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        internal DocumentModelInfo(string modelId, DateTimeOffset createdDateTime) : base(modelId, createdDateTime)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            DocTypes = new ChangeTrackingDictionary<string, DocTypeInfo>();
        }

        /// <summary> Initializes a new instance of DocumentModelInfo. </summary>
        /// <param name="modelId"> Unique model name. </param>
        /// <param name="description"> Model description. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="docTypes"> Supported document types. </param>
        internal DocumentModelInfo(string modelId, string description, DateTimeOffset createdDateTime, IReadOnlyDictionary<string, DocTypeInfo> docTypes) : base(modelId, description, createdDateTime)
        {
            DocTypes = docTypes;
        }

        /// <summary> Supported document types. </summary>
        public IReadOnlyDictionary<string, DocTypeInfo> DocTypes { get; }
    }
}
