// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace LiveVideoAnalytics
{
    /// <summary> An endpoint that the media graph can connect to, with no encryption in transit. </summary>
    public partial class MediaGraphUnsecuredEndpoint : MediaGraphEndpoint
    {
        /// <summary> Initializes a new instance of MediaGraphUnsecuredEndpoint. </summary>
        /// <param name="url"> Url for the endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public MediaGraphUnsecuredEndpoint(string url) : base(url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            Type = "#Microsoft.Media.MediaGraphUnsecuredEndpoint";
        }

        /// <summary> Initializes a new instance of MediaGraphUnsecuredEndpoint. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="credentials"> Polymorphic credentials to be presented to the endpoint. </param>
        /// <param name="url"> Url for the endpoint. </param>
        internal MediaGraphUnsecuredEndpoint(string type, MediaGraphCredentials credentials, string url) : base(type, credentials, url)
        {
            Type = type ?? "#Microsoft.Media.MediaGraphUnsecuredEndpoint";
        }
    }
}
