// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ComputerVision.Models
{
    /// <summary> An object providing additional metadata describing color attributes. </summary>
    public partial class ColorInfo
    {
        /// <summary> Initializes a new instance of ColorInfo. </summary>
        internal ColorInfo()
        {
            DominantColors = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ColorInfo. </summary>
        /// <param name="dominantColorForeground"> Possible dominant foreground color. </param>
        /// <param name="dominantColorBackground"> Possible dominant background color. </param>
        /// <param name="dominantColors"> An array of possible dominant colors. </param>
        /// <param name="accentColor"> Possible accent color. </param>
        /// <param name="isBWImg"> A value indicating if the image is black and white. </param>
        internal ColorInfo(string dominantColorForeground, string dominantColorBackground, IReadOnlyList<string> dominantColors, string accentColor, bool? isBWImg)
        {
            DominantColorForeground = dominantColorForeground;
            DominantColorBackground = dominantColorBackground;
            DominantColors = dominantColors;
            AccentColor = accentColor;
            IsBWImg = isBWImg;
        }

        /// <summary> Possible dominant foreground color. </summary>
        public string DominantColorForeground { get; }
        /// <summary> Possible dominant background color. </summary>
        public string DominantColorBackground { get; }
        /// <summary> An array of possible dominant colors. </summary>
        public IReadOnlyList<string> DominantColors { get; }
        /// <summary> Possible accent color. </summary>
        public string AccentColor { get; }
        /// <summary> A value indicating if the image is black and white. </summary>
        public bool? IsBWImg { get; }
    }
}
