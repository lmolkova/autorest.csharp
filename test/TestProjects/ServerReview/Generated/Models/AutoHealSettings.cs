// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ServerReview.Models
{
    /// <summary> AutoHeal Settings ? On/Off ; other flags. </summary>
    public partial class AutoHealSettings
    {
        /// <summary> Initializes a new instance of AutoHealSettings. </summary>
        public AutoHealSettings()
        {
        }

        /// <summary> Initializes a new instance of AutoHealSettings. </summary>
        /// <param name="autoHealStatus"> Policy controlled toggle. </param>
        internal AutoHealSettings(AutoHealStatus? autoHealStatus)
        {
            AutoHealStatus = autoHealStatus;
        }

        /// <summary> Policy controlled toggle. </summary>
        public AutoHealStatus? AutoHealStatus { get; set; }
    }
}
