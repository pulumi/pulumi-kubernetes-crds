// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apm.V1
{

    /// <summary>
    /// TLS defines options for configuring TLS for HTTP.
    /// </summary>
    public class ApmServerSpecHttpTlsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Certificate is a reference to a Kubernetes secret that contains the certificate and private key for enabling TLS. The referenced secret should contain the following: 
        ///  - `ca.crt`: The certificate authority (optional). - `tls.crt`: The certificate (or a chain). - `tls.key`: The private key to the first certificate in the certificate chain.
        /// </summary>
        [Input("certificate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apm.V1.ApmServerSpecHttpTlsCertificateArgs>? Certificate { get; set; }

        /// <summary>
        /// SelfSignedCertificate allows configuring the self-signed certificate generated by the operator.
        /// </summary>
        [Input("selfSignedCertificate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apm.V1.ApmServerSpecHttpTlsSelfSignedCertificateArgs>? SelfSignedCertificate { get; set; }

        public ApmServerSpecHttpTlsArgs()
        {
        }
    }
}
