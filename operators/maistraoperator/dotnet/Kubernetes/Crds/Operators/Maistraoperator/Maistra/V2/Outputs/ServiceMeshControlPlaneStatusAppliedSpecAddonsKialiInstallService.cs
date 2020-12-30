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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstallService
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstallServiceIngress Ingress;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstallServiceMetadata Metadata;
        public readonly int NodePort;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstallService(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstallServiceIngress ingress,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstallServiceMetadata metadata,

            int nodePort)
        {
            Ingress = ingress;
            Metadata = metadata;
            NodePort = nodePort;
        }
    }
}
