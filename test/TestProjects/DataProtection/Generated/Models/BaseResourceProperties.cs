// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtection.Models
{
    /// <summary> Properties which are specific to datasource/datasourcesets/backupinstanceref/backupsettings. </summary>
    public partial class BaseResourceProperties
    {
        /// <summary> Initializes a new instance of BaseResourceProperties. </summary>
        public BaseResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of BaseResourceProperties. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal BaseResourceProperties(string objectType)
        {
            ObjectType = objectType;
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}
