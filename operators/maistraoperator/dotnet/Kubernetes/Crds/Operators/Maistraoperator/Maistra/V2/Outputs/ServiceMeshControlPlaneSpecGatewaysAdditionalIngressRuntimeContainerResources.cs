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
    public sealed class ServiceMeshControlPlaneSpecGatewaysAdditionalIngressRuntimeContainerResources
    {
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalIngressRuntimeContainerResourcesLimits> Limits;
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalIngressRuntimeContainerResourcesRequests> Requests;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecGatewaysAdditionalIngressRuntimeContainerResources(
            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalIngressRuntimeContainerResourcesLimits> limits,

            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalIngressRuntimeContainerResourcesRequests> requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
