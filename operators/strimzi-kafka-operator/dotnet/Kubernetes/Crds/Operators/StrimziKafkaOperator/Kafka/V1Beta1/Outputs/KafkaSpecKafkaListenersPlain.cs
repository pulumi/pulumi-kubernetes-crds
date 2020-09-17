// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecKafkaListenersPlain
    {
        /// <summary>
        /// Authentication configuration for this listener. Since this listener does not use TLS transport you cannot configure an authentication with `type: tls`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersPlainAuthentication Authentication;
        /// <summary>
        /// List of peers which should be able to connect to this listener. Peers in this list are combined using a logical OR operation. If this field is empty or missing, all connections will be allowed for this listener. If this field is present and contains at least one item, the listener only allows the traffic which matches at least one item in this list.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersPlainNetworkPolicyPeers> NetworkPolicyPeers;

        [OutputConstructor]
        private KafkaSpecKafkaListenersPlain(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersPlainAuthentication authentication,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersPlainNetworkPolicyPeers> networkPolicyPeers)
        {
            Authentication = authentication;
            NetworkPolicyPeers = networkPolicyPeers;
        }
    }
}