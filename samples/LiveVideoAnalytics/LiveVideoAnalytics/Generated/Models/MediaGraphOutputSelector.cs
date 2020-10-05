// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using LiveVideoAnalytics.Models;

namespace LiveVideoAnalytics
{
    /// <summary> Allows for the selection of particular streams from another node. </summary>
    public partial class MediaGraphOutputSelector
    {
        /// <summary> Initializes a new instance of MediaGraphOutputSelector. </summary>
        public MediaGraphOutputSelector()
        {
            Property = "mediaType";
        }

        /// <summary> Initializes a new instance of MediaGraphOutputSelector. </summary>
        /// <param name="property"> The stream property to compare with. </param>
        /// <param name="operator"> The operator to compare streams by. </param>
        /// <param name="value"> Value to compare against. </param>
        internal MediaGraphOutputSelector(string property, MediaGraphOutputSelectorOperator? @operator, string value)
        {
            Property = property;
            Operator = @operator;
            Value = value;
        }

        /// <summary> The stream property to compare with. </summary>
        public string Property { get; set; }
        /// <summary> The operator to compare streams by. </summary>
        public MediaGraphOutputSelectorOperator? Operator { get; set; }
        /// <summary> Value to compare against. </summary>
        public string Value { get; set; }
    }
}
