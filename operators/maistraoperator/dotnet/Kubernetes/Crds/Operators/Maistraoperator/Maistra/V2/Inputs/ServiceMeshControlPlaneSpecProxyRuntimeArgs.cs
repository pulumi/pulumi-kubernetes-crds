// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneSpecProxyRuntimeArgs : Pulumi.ResourceArgs
    {
        [Input("container")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecProxyRuntimeContainerArgs>? Container { get; set; }

        [Input("readiness")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecProxyRuntimeReadinessArgs>? Readiness { get; set; }

        public ServiceMeshControlPlaneSpecProxyRuntimeArgs()
        {
        }
    }
}
