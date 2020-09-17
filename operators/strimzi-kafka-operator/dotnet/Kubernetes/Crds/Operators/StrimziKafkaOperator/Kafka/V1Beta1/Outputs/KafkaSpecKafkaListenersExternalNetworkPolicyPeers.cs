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
    public sealed class KafkaSpecKafkaListenersExternalNetworkPolicyPeers
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalNetworkPolicyPeersIpBlock IpBlock;
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalNetworkPolicyPeersNamespaceSelector NamespaceSelector;
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalNetworkPolicyPeersPodSelector PodSelector;

        [OutputConstructor]
        private KafkaSpecKafkaListenersExternalNetworkPolicyPeers(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalNetworkPolicyPeersIpBlock ipBlock,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalNetworkPolicyPeersNamespaceSelector namespaceSelector,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalNetworkPolicyPeersPodSelector podSelector)
        {
            IpBlock = ipBlock;
            NamespaceSelector = namespaceSelector;
            PodSelector = podSelector;
        }
    }
}