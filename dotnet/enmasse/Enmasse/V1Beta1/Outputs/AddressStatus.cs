// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1
{

    [OutputType]
    public sealed class AddressStatus
    {
        /// <summary>
        /// The status of this address in brokers.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusBrokerStatuses> BrokerStatuses;
        /// <summary>
        /// Forwarder status for this address.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusForwarders> Forwarders;
        /// <summary>
        /// Whether address is ready to use or not.
        /// </summary>
        public readonly bool IsReady;
        /// <summary>
        /// Applied message TTL properties.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusMessageTtl MessageTtl;
        /// <summary>
        /// Status and error messages for address.
        /// </summary>
        public readonly ImmutableArray<string> Messages;
        /// <summary>
        /// Phase of address.
        /// </summary>
        public readonly string Phase;
        public readonly Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusPlanStatus PlanStatus;
        /// <summary>
        /// Applied properties for subscription type addresses.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusSubscription Subscription;

        [OutputConstructor]
        private AddressStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusBrokerStatuses> brokerStatuses,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusForwarders> forwarders,

            bool isReady,

            Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusMessageTtl messageTtl,

            ImmutableArray<string> messages,

            string phase,

            Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusPlanStatus planStatus,

            Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressStatusSubscription subscription)
        {
            BrokerStatuses = brokerStatuses;
            Forwarders = forwarders;
            IsReady = isReady;
            MessageTtl = messageTtl;
            Messages = messages;
            Phase = phase;
            PlanStatus = planStatus;
            Subscription = subscription;
        }
    }
}