// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ServerReview.Models
{
    /// <summary> Retention Tag information. </summary>
    public partial class RetentionTag
    {
        /// <summary> Initializes a new instance of RetentionTag. </summary>
        /// <param name="tagName"> Retention Tag Name to relate it to retention rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tagName"/> is null. </exception>
        public RetentionTag(string tagName)
        {
            if (tagName == null)
            {
                throw new ArgumentNullException(nameof(tagName));
            }

            TagName = tagName;
        }

        /// <summary> Initializes a new instance of RetentionTag. </summary>
        /// <param name="tagName"> Retention Tag Name to relate it to retention rule. </param>
        /// <param name="eTag"> Retention Tag version. </param>
        /// <param name="id"> Retention Tag version. </param>
        internal RetentionTag(string tagName, string eTag, string id)
        {
            TagName = tagName;
            ETag = eTag;
            Id = id;
        }

        /// <summary> Retention Tag Name to relate it to retention rule. </summary>
        public string TagName { get; set; }
        /// <summary> Retention Tag version. </summary>
        public string ETag { get; }
        /// <summary> Retention Tag version. </summary>
        public string Id { get; }
    }
}
