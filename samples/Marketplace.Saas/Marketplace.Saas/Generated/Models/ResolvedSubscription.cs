// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Marketplace.Saas.Models
{
    /// <summary> Summary of the subscription. </summary>
    public partial class ResolvedSubscription
    {
        /// <summary> Initializes a new instance of ResolvedSubscription. </summary>
        internal ResolvedSubscription()
        {
        }

        /// <summary> Initializes a new instance of ResolvedSubscription. </summary>
        /// <param name="id"> . </param>
        /// <param name="subscriptionName"> . </param>
        /// <param name="offerId"> . </param>
        /// <param name="planId"> . </param>
        /// <param name="quantity"> . </param>
        /// <param name="subscription"> . </param>
        internal ResolvedSubscription(Guid? id, string subscriptionName, string offerId, string planId, long? quantity, Subscription subscription)
        {
            Id = id;
            SubscriptionName = subscriptionName;
            OfferId = offerId;
            PlanId = planId;
            Quantity = quantity;
            Subscription = subscription;
        }

        public Guid? Id { get; }
        public string SubscriptionName { get; }
        public string OfferId { get; }
        public string PlanId { get; }
        public long? Quantity { get; }
        public Subscription Subscription { get; }
    }
}
