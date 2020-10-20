// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    internal static class ContentType1Extensions
    {
        public static string ToSerialString(this ContentType1 value) => value switch
        {
            ContentType1.ApplicationPdf => "application/pdf",
            ContentType1.ImageBmp => "image/bmp",
            ContentType1.ImageJpeg => "image/jpeg",
            ContentType1.ImagePng => "image/png",
            ContentType1.ImageTiff => "image/tiff",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContentType1 value.")
        };

        public static ContentType1 ToContentType1(this string value)
        {
            if (string.Equals(value, "application/pdf", StringComparison.InvariantCultureIgnoreCase)) return ContentType1.ApplicationPdf;
            if (string.Equals(value, "image/bmp", StringComparison.InvariantCultureIgnoreCase)) return ContentType1.ImageBmp;
            if (string.Equals(value, "image/jpeg", StringComparison.InvariantCultureIgnoreCase)) return ContentType1.ImageJpeg;
            if (string.Equals(value, "image/png", StringComparison.InvariantCultureIgnoreCase)) return ContentType1.ImagePng;
            if (string.Equals(value, "image/tiff", StringComparison.InvariantCultureIgnoreCase)) return ContentType1.ImageTiff;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContentType1 value.");
        }
    }
}
