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
    public sealed class ServiceMeshControlPlaneSpecGatewaysIngressRuntime
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysIngressRuntimeContainer Container;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysIngressRuntimeDeployment Deployment;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysIngressRuntimePod Pod;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecGatewaysIngressRuntime(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysIngressRuntimeContainer container,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysIngressRuntimeDeployment deployment,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysIngressRuntimePod pod)
        {
            Container = container;
            Deployment = deployment;
            Pod = pod;
        }
    }
}
