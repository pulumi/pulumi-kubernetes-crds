// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimePodAffinityPodAntiAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("preferredDuringScheduling")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimePodAffinityPodAntiAffinityPreferredDuringSchedulingArgs>? _preferredDuringScheduling;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimePodAffinityPodAntiAffinityPreferredDuringSchedulingArgs> PreferredDuringScheduling
        {
            get => _preferredDuringScheduling ?? (_preferredDuringScheduling = new InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimePodAffinityPodAntiAffinityPreferredDuringSchedulingArgs>());
            set => _preferredDuringScheduling = value;
        }

        [Input("requiredDuringScheduling")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimePodAffinityPodAntiAffinityRequiredDuringSchedulingArgs>? _requiredDuringScheduling;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimePodAffinityPodAntiAffinityRequiredDuringSchedulingArgs> RequiredDuringScheduling
        {
            get => _requiredDuringScheduling ?? (_requiredDuringScheduling = new InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimePodAffinityPodAntiAffinityRequiredDuringSchedulingArgs>());
            set => _requiredDuringScheduling = value;
        }

        public ServiceMeshControlPlaneStatusAppliedSpecClusterMeshExpansionIlbGatewayRuntimePodAffinityPodAntiAffinityArgs()
        {
        }
    }
}
