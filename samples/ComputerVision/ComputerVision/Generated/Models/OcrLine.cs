// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ComputerVision.Models
{
    /// <summary> An object describing a single recognized line of text. </summary>
    public partial class OcrLine
    {
        /// <summary> Initializes a new instance of OcrLine. </summary>
        internal OcrLine()
        {
            Words = new ChangeTrackingList<OcrWord>();
        }

        /// <summary> Initializes a new instance of OcrLine. </summary>
        /// <param name="boundingBox"> Bounding box of a recognized line. The four integers represent the x-coordinate of the left edge, the y-coordinate of the top edge, width, and height of the bounding box, in the coordinate system of the input image, after it has been rotated around its center according to the detected text angle (see textAngle property), with the origin at the top-left corner, and the y-axis pointing down. </param>
        /// <param name="words"> An array of objects, where each object represents a recognized word. </param>
        internal OcrLine(string boundingBox, IReadOnlyList<OcrWord> words)
        {
            BoundingBox = boundingBox;
            Words = words;
        }

        /// <summary> Bounding box of a recognized line. The four integers represent the x-coordinate of the left edge, the y-coordinate of the top edge, width, and height of the bounding box, in the coordinate system of the input image, after it has been rotated around its center according to the detected text angle (see textAngle property), with the origin at the top-left corner, and the y-axis pointing down. </summary>
        public string BoundingBox { get; }
        /// <summary> An array of objects, where each object represents a recognized word. </summary>
        public IReadOnlyList<OcrWord> Words { get; }
    }
}
