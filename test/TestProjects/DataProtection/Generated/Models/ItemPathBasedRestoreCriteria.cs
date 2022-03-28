// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtection.Models
{
    /// <summary> Class to contain criteria for item path based restore. </summary>
    public partial class ItemPathBasedRestoreCriteria : ItemLevelRestoreCriteria
    {
        /// <summary> Initializes a new instance of ItemPathBasedRestoreCriteria. </summary>
        public ItemPathBasedRestoreCriteria()
        {
            ObjectType = "ItemPathBasedRestoreCriteria";
        }

        /// <summary> Initializes a new instance of ItemPathBasedRestoreCriteria. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="itemPath"> Path of the item to be restored. </param>
        /// <param name="isPathRelativeToBackupItem"> Flag to specify if the path is relative to Backup Item or full path. </param>
        internal ItemPathBasedRestoreCriteria(string objectType, string itemPath, bool? isPathRelativeToBackupItem) : base(objectType)
        {
            ItemPath = itemPath;
            IsPathRelativeToBackupItem = isPathRelativeToBackupItem;
            ObjectType = objectType ?? "ItemPathBasedRestoreCriteria";
        }

        /// <summary> Path of the item to be restored. </summary>
        public string ItemPath { get; set; }
        /// <summary> Flag to specify if the path is relative to Backup Item or full path. </summary>
        public bool? IsPathRelativeToBackupItem { get; set; }
    }
}
