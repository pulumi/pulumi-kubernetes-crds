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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimePodAffinityPodAntiAffinity
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimePodAffinityPodAntiAffinityPreferredDuringScheduling> PreferredDuringScheduling;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimePodAffinityPodAntiAffinityRequiredDuringScheduling> RequiredDuringScheduling;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimePodAffinityPodAntiAffinity(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimePodAffinityPodAntiAffinityPreferredDuringScheduling> preferredDuringScheduling,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimePodAffinityPodAntiAffinityRequiredDuringScheduling> requiredDuringScheduling)
        {
            PreferredDuringScheduling = preferredDuringScheduling;
            RequiredDuringScheduling = requiredDuringScheduling;
        }
    }
}
