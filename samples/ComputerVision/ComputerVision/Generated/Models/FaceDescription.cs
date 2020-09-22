// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ComputerVision.Models
{
    /// <summary> An object describing a face identified in the image. </summary>
    public partial class FaceDescription
    {
        /// <summary> Initializes a new instance of FaceDescription. </summary>
        internal FaceDescription()
        {
        }

        /// <summary> Initializes a new instance of FaceDescription. </summary>
        /// <param name="age"> Possible age of the face. </param>
        /// <param name="gender"> Possible gender of the face. </param>
        /// <param name="faceRectangle"> Rectangle in the image containing the identified face. </param>
        internal FaceDescription(int? age, Gender? gender, FaceRectangle faceRectangle)
        {
            Age = age;
            Gender = gender;
            FaceRectangle = faceRectangle;
        }

        /// <summary> Possible age of the face. </summary>
        public int? Age { get; }
        /// <summary> Possible gender of the face. </summary>
        public Gender? Gender { get; }
        /// <summary> Rectangle in the image containing the identified face. </summary>
        public FaceRectangle FaceRectangle { get; }
    }
}
