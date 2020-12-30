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
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecSecurityCertificateAuthorityIstiod
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecSecurityCertificateAuthorityIstiodPrivateKey PrivateKey;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecSecurityCertificateAuthorityIstiodSelfSigned SelfSigned;
        public readonly string Type;
        public readonly string WorkloadCertTTLDefault;
        public readonly string WorkloadCertTTLMax;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecSecurityCertificateAuthorityIstiod(
            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecSecurityCertificateAuthorityIstiodPrivateKey privateKey,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecSecurityCertificateAuthorityIstiodSelfSigned selfSigned,

            string type,

            string workloadCertTTLDefault,

            string workloadCertTTLMax)
        {
            PrivateKey = privateKey;
            SelfSigned = selfSigned;
            Type = type;
            WorkloadCertTTLDefault = workloadCertTTLDefault;
            WorkloadCertTTLMax = workloadCertTTLMax;
        }
    }
}
