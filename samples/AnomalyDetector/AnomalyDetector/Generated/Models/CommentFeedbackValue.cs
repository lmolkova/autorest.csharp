// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace AnomalyDetector.Models
{
    /// <summary> The CommentFeedbackValue. </summary>
    internal partial class CommentFeedbackValue
    {
        /// <summary> Initializes a new instance of CommentFeedbackValue. </summary>
        /// <param name="commentValue"> the comment string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commentValue"/> is null. </exception>
        internal CommentFeedbackValue(string commentValue)
        {
            if (commentValue == null)
            {
                throw new ArgumentNullException(nameof(commentValue));
            }

            CommentValue = commentValue;
        }

        /// <summary> the comment string. </summary>
        public string CommentValue { get; }
    }
}
