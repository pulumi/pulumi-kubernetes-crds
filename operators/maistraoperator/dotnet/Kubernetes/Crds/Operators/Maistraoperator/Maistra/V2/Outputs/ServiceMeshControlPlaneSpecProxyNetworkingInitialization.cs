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
    public sealed class ServiceMeshControlPlaneSpecProxyNetworkingInitialization
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecProxyNetworkingInitializationInitContainer InitContainer;
        public readonly string Type;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecProxyNetworkingInitialization(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecProxyNetworkingInitializationInitContainer initContainer,

            string type)
        {
            InitContainer = initContainer;
            Type = type;
        }
    }
}
