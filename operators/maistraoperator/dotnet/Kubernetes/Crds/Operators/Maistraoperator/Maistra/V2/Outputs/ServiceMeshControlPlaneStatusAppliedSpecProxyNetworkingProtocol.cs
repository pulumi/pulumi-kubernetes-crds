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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingProtocol
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingProtocolAutoDetect AutoDetect;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingProtocol(Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecProxyNetworkingProtocolAutoDetect autoDetect)
        {
            AutoDetect = autoDetect;
        }
    }
}
