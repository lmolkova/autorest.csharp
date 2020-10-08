// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace LiveVideoAnalytics.Models
{
    /// <summary> Username/password credential pair. </summary>
    public partial class MediaGraphUsernamePasswordCredentials : MediaGraphCredentials
    {
        /// <summary> Initializes a new instance of MediaGraphUsernamePasswordCredentials. </summary>
        /// <param name="username"> Username for a username/password pair. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> is null. </exception>
        public MediaGraphUsernamePasswordCredentials(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            Username = username;
            Type = "#Microsoft.Media.MediaGraphUsernamePasswordCredentials";
        }

        /// <summary> Username for a username/password pair. </summary>
        public string Username { get; }
        /// <summary> Password for a username/password pair. </summary>
        public string Password { get; set; }
    }
}
