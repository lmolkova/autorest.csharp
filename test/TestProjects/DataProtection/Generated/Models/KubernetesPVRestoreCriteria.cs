// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtection.Models
{
    /// <summary> Class used for Kubernetes PV Restore Criteria. </summary>
    public partial class KubernetesPVRestoreCriteria : ItemLevelRestoreCriteria
    {
        /// <summary> Initializes a new instance of KubernetesPVRestoreCriteria. </summary>
        public KubernetesPVRestoreCriteria()
        {
            ObjectType = "KubernetesPVRestoreCriteria";
        }

        /// <summary> Initializes a new instance of KubernetesPVRestoreCriteria. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="name"> name of the kubernetes resource. </param>
        /// <param name="storageClassName"> storage class name. </param>
        internal KubernetesPVRestoreCriteria(string objectType, string name, string storageClassName) : base(objectType)
        {
            Name = name;
            StorageClassName = storageClassName;
            ObjectType = objectType ?? "KubernetesPVRestoreCriteria";
        }

        /// <summary> name of the kubernetes resource. </summary>
        public string Name { get; set; }
        /// <summary> storage class name. </summary>
        public string StorageClassName { get; set; }
    }
}
