// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinityPodAntiAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("preferredDuringScheduling")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinityPodAntiAffinityPreferredDuringSchedulingArgs>? _preferredDuringScheduling;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinityPodAntiAffinityPreferredDuringSchedulingArgs> PreferredDuringScheduling
        {
            get => _preferredDuringScheduling ?? (_preferredDuringScheduling = new InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinityPodAntiAffinityPreferredDuringSchedulingArgs>());
            set => _preferredDuringScheduling = value;
        }

        [Input("requiredDuringScheduling")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinityPodAntiAffinityRequiredDuringSchedulingArgs>? _requiredDuringScheduling;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinityPodAntiAffinityRequiredDuringSchedulingArgs> RequiredDuringScheduling
        {
            get => _requiredDuringScheduling ?? (_requiredDuringScheduling = new InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinityPodAntiAffinityRequiredDuringSchedulingArgs>());
            set => _requiredDuringScheduling = value;
        }

        public ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodAffinityPodAntiAffinityArgs()
        {
        }
    }
}
