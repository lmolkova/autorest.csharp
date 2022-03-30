// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ServerReview.Models
{
    /// <summary> Response body received from the Plugin Server for Sync APIs like cancellation, refreshTokens. </summary>
    public partial class SyncResponse
    {
        /// <summary> Initializes a new instance of SyncResponse. </summary>
        /// <param name="id"> As passed in the URL?s operationId query parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal SyncResponse(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of SyncResponse. </summary>
        /// <param name="id"> As passed in the URL?s operationId query parameter. </param>
        /// <param name="error"> Set the error when API is in failure path. </param>
        internal SyncResponse(string id, Error error)
        {
            Id = id;
            Error = error;
        }

        /// <summary> As passed in the URL?s operationId query parameter. </summary>
        public string Id { get; }
        /// <summary> Set the error when API is in failure path. </summary>
        public Error Error { get; }
    }
}
