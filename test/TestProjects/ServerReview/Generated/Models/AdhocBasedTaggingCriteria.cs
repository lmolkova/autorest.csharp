// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ServerReview.Models
{
    /// <summary> Class for Adhoc backup Tagging Criteria. </summary>
    public partial class AdhocBasedTaggingCriteria
    {
        /// <summary> Initializes a new instance of AdhocBasedTaggingCriteria. </summary>
        public AdhocBasedTaggingCriteria()
        {
        }

        /// <summary> Initializes a new instance of AdhocBasedTaggingCriteria. </summary>
        /// <param name="tagInfo"> Retention tag information. </param>
        internal AdhocBasedTaggingCriteria(RetentionTag tagInfo)
        {
            TagInfo = tagInfo;
        }

        /// <summary> Retention tag information. </summary>
        public RetentionTag TagInfo { get; set; }
    }
}
