// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Model summary. </summary>
    public partial class ModelSummary
    {
        /// <summary> Initializes a new instance of ModelSummary. </summary>
        /// <param name="modelId"> Unique model name. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the model was created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        internal ModelSummary(string modelId, DateTimeOffset createdDateTime)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            ModelId = modelId;
            CreatedDateTime = createdDateTime;
        }

        /// <summary> Initializes a new instance of ModelSummary. </summary>
        /// <param name="modelId"> Unique model name. </param>
        /// <param name="description"> Model description. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the model was created. </param>
        internal ModelSummary(string modelId, string description, DateTimeOffset createdDateTime)
        {
            ModelId = modelId;
            Description = description;
            CreatedDateTime = createdDateTime;
        }

        /// <summary> Unique model name. </summary>
        public string ModelId { get; }
        /// <summary> Model description. </summary>
        public string Description { get; }
        /// <summary> Date and time (UTC) when the model was created. </summary>
        public DateTimeOffset CreatedDateTime { get; }
    }
}
