// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace LiveVideoAnalytics
{
    /// <summary> Http header service credentials. </summary>
    public partial class MediaGraphHttpHeaderCredentials : MediaGraphCredentials
    {
        /// <summary> Initializes a new instance of MediaGraphHttpHeaderCredentials. </summary>
        /// <param name="headerName"> HTTP header name. </param>
        /// <param name="headerValue"> HTTP header value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headerName"/> or <paramref name="headerValue"/> is null. </exception>
        public MediaGraphHttpHeaderCredentials(string headerName, string headerValue)
        {
            if (headerName == null)
            {
                throw new ArgumentNullException(nameof(headerName));
            }
            if (headerValue == null)
            {
                throw new ArgumentNullException(nameof(headerValue));
            }

            HeaderName = headerName;
            HeaderValue = headerValue;
            Type = "#Microsoft.Media.MediaGraphHttpHeaderCredentials";
        }

        /// <summary> Initializes a new instance of MediaGraphHttpHeaderCredentials. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="headerName"> HTTP header name. </param>
        /// <param name="headerValue"> HTTP header value. </param>
        internal MediaGraphHttpHeaderCredentials(string type, string headerName, string headerValue) : base(type)
        {
            HeaderName = headerName;
            HeaderValue = headerValue;
            Type = type ?? "#Microsoft.Media.MediaGraphHttpHeaderCredentials";
        }

        /// <summary> HTTP header name. </summary>
        public string HeaderName { get; set; }
        /// <summary> HTTP header value. </summary>
        public string HeaderValue { get; set; }
    }
}
