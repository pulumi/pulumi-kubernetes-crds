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
    public sealed class ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayRuntime
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayRuntimeContainer Container;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayRuntimeDeployment Deployment;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayRuntimePod Pod;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayRuntime(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayRuntimeContainer container,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayRuntimeDeployment deployment,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayRuntimePod pod)
        {
            Container = container;
            Deployment = deployment;
            Pod = pod;
        }
    }
}
