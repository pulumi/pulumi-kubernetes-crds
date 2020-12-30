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
    public sealed class ServiceMeshControlPlaneSpecAddonsKialiInstallService
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecAddonsKialiInstallServiceIngress Ingress;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecAddonsKialiInstallServiceMetadata Metadata;
        public readonly int NodePort;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecAddonsKialiInstallService(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecAddonsKialiInstallServiceIngress ingress,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecAddonsKialiInstallServiceMetadata metadata,

            int nodePort)
        {
            Ingress = ingress;
            Metadata = metadata;
            NodePort = nodePort;
        }
    }
}
