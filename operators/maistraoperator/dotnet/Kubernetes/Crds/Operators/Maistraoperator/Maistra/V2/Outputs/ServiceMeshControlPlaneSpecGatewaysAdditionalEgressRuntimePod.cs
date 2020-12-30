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
    public sealed class ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePod
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinity Affinity;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodMetadata Metadata;
        public readonly ImmutableDictionary<string, string> NodeSelector;
        public readonly string PriorityClassName;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodTolerations> Tolerations;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePod(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinity affinity,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodMetadata metadata,

            ImmutableDictionary<string, string> nodeSelector,

            string priorityClassName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodTolerations> tolerations)
        {
            Affinity = affinity;
            Metadata = metadata;
            NodeSelector = nodeSelector;
            PriorityClassName = priorityClassName;
            Tolerations = tolerations;
        }
    }
}
