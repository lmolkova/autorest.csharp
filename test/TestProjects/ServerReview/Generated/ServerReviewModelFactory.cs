// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ServerReview.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class ServerReviewModelFactory
    {
        /// <summary> Initializes a new instance of RetentionTag. </summary>
        /// <param name="tagName"> Retention Tag Name to relate it to retention rule. </param>
        /// <param name="eTag"> Retention Tag version. </param>
        /// <param name="id"> Retention Tag version. </param>
        /// <returns> A new <see cref="Models.RetentionTag"/> instance for mocking. </returns>
        public static RetentionTag RetentionTag(string tagName = null, string eTag = null, string id = null)
        {
            return new RetentionTag(tagName, eTag, id);
        }

        /// <summary> Initializes a new instance of SyncResponse. </summary>
        /// <param name="id"> As passed in the URL?s operationId query parameter. </param>
        /// <param name="error"> Set the error when API is in failure path. </param>
        /// <returns> A new <see cref="Models.SyncResponse"/> instance for mocking. </returns>
        public static SyncResponse SyncResponse(string id = null, Error error = null)
        {
            return new SyncResponse(id, error);
        }
    }
}
