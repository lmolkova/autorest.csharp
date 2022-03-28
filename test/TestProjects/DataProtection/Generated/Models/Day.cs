// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtection.Models
{
    /// <summary> Day of the Month. </summary>
    public partial class Day
    {
        /// <summary> Initializes a new instance of Day. </summary>
        public Day()
        {
        }

        /// <summary> Initializes a new instance of Day. </summary>
        /// <param name="date"> Date of the month. </param>
        /// <param name="isLast"> Whether Date is last date of month. </param>
        internal Day(int? date, bool? isLast)
        {
            Date = date;
            IsLast = isLast;
        }

        /// <summary> Date of the month. </summary>
        public int? Date { get; set; }
        /// <summary> Whether Date is last date of month. </summary>
        public bool? IsLast { get; set; }
    }
}
