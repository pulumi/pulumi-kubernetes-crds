// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeArgs : Pulumi.ResourceArgs
    {
        [Input("container")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerArgs>? Container { get; set; }

        [Input("deployment")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeDeploymentArgs>? Deployment { get; set; }

        [Input("pod")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimePodArgs>? Pod { get; set; }

        public ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeArgs()
        {
        }
    }
}
