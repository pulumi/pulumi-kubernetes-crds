// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingProtocolArgs : Pulumi.ResourceArgs
    {
        [Input("autoDetect")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingProtocolAutoDetectArgs>? AutoDetect { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingProtocolArgs()
        {
        }
    }
}
