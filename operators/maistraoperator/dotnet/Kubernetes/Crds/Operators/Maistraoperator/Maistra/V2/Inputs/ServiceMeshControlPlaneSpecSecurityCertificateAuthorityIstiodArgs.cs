// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneSpecSecurityCertificateAuthorityIstiodArgs : Pulumi.ResourceArgs
    {
        [Input("privateKey")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecSecurityCertificateAuthorityIstiodPrivateKeyArgs>? PrivateKey { get; set; }

        [Input("selfSigned")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecSecurityCertificateAuthorityIstiodSelfSignedArgs>? SelfSigned { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("workloadCertTTLDefault")]
        public Input<string>? WorkloadCertTTLDefault { get; set; }

        [Input("workloadCertTTLMax")]
        public Input<string>? WorkloadCertTTLMax { get; set; }

        public ServiceMeshControlPlaneSpecSecurityCertificateAuthorityIstiodArgs()
        {
        }
    }
}
