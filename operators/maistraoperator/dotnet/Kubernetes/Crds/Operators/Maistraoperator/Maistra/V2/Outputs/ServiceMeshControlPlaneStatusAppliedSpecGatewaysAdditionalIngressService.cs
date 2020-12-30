// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Maistra.V2
{

    [OutputType]
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalIngressService
    {
        public readonly string ClusterIP;
        public readonly ImmutableArray<string> ExternalIPs;
        public readonly string ExternalName;
        public readonly string ExternalTrafficPolicy;
        public readonly int HealthCheckNodePort;
        public readonly string IpFamily;
        public readonly string LoadBalancerIP;
        public readonly ImmutableArray<string> LoadBalancerSourceRanges;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalIngressServiceMetadata Metadata;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalIngressServicePorts> Ports;
        public readonly bool PublishNotReadyAddresses;
        public readonly ImmutableDictionary<string, string> Selector;
        public readonly string SessionAffinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalIngressServiceSessionAffinityConfig SessionAffinityConfig;
        public readonly ImmutableArray<string> TopologyKeys;
        public readonly string Type;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalIngressService(
            string clusterIP,

            ImmutableArray<string> externalIPs,

            string externalName,

            string externalTrafficPolicy,

            int healthCheckNodePort,

            string ipFamily,

            string loadBalancerIP,

            ImmutableArray<string> loadBalancerSourceRanges,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalIngressServiceMetadata metadata,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalIngressServicePorts> ports,

            bool publishNotReadyAddresses,

            ImmutableDictionary<string, string> selector,

            string sessionAffinity,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalIngressServiceSessionAffinityConfig sessionAffinityConfig,

            ImmutableArray<string> topologyKeys,

            string type)
        {
            ClusterIP = clusterIP;
            ExternalIPs = externalIPs;
            ExternalName = externalName;
            ExternalTrafficPolicy = externalTrafficPolicy;
            HealthCheckNodePort = healthCheckNodePort;
            IpFamily = ipFamily;
            LoadBalancerIP = loadBalancerIP;
            LoadBalancerSourceRanges = loadBalancerSourceRanges;
            Metadata = metadata;
            Ports = ports;
            PublishNotReadyAddresses = publishNotReadyAddresses;
            Selector = selector;
            SessionAffinity = sessionAffinity;
            SessionAffinityConfig = sessionAffinityConfig;
            TopologyKeys = topologyKeys;
            Type = type;
        }
    }
}
