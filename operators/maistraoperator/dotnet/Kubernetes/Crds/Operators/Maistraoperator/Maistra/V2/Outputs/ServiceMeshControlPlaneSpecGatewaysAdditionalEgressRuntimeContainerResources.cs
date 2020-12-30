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
    public sealed class ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResources
    {
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesLimits> Limits;
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesRequests> Requests;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResources(
            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesLimits> limits,

            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesRequests> requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
