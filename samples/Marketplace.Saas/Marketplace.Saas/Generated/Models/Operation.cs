// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Marketplace.Saas.Models
{
    /// <summary> The Operation. </summary>
    public partial class Operation
    {
        /// <summary> Initializes a new instance of Operation. </summary>
        internal Operation()
        {
        }

        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="id"> . </param>
        /// <param name="activityId"> . </param>
        /// <param name="subscriptionId"> . </param>
        /// <param name="offerId"> . </param>
        /// <param name="publisherId"> . </param>
        /// <param name="planId"> . </param>
        /// <param name="quantity"> . </param>
        /// <param name="action"> . </param>
        /// <param name="timeStamp"> . </param>
        /// <param name="status"> . </param>
        internal Operation(Guid? id, Guid? activityId, Guid? subscriptionId, string offerId, string publisherId, string planId, int? quantity, OperationActionEnum? action, DateTimeOffset? timeStamp, OperationStatusEnum? status)
        {
            Id = id;
            ActivityId = activityId;
            SubscriptionId = subscriptionId;
            OfferId = offerId;
            PublisherId = publisherId;
            PlanId = planId;
            Quantity = quantity;
            Action = action;
            TimeStamp = timeStamp;
            Status = status;
        }

        public Guid? Id { get; }
        public Guid? ActivityId { get; }
        public Guid? SubscriptionId { get; }
        public string OfferId { get; }
        public string PublisherId { get; }
        public string PlanId { get; }
        public int? Quantity { get; }
        public OperationActionEnum? Action { get; }
        public DateTimeOffset? TimeStamp { get; }
        public OperationStatusEnum? Status { get; }
    }
}
