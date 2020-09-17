// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kibana.V1
{

    /// <summary>
    /// SelfSignedCertificate allows configuring the self-signed certificate generated by the operator.
    /// </summary>
    public class KibanaSpecHttpTlsSelfSignedCertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Disabled indicates that the provisioning of the self-signed certifcate should be disabled.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        [Input("subjectAltNames")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kibana.V1.KibanaSpecHttpTlsSelfSignedCertificateSubjectAltNamesArgs>? _subjectAltNames;

        /// <summary>
        /// SubjectAlternativeNames is a list of SANs to include in the generated HTTP TLS certificate.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kibana.V1.KibanaSpecHttpTlsSelfSignedCertificateSubjectAltNamesArgs> SubjectAltNames
        {
            get => _subjectAltNames ?? (_subjectAltNames = new InputList<Pulumi.Kubernetes.Types.Inputs.Kibana.V1.KibanaSpecHttpTlsSelfSignedCertificateSubjectAltNamesArgs>());
            set => _subjectAltNames = value;
        }

        public KibanaSpecHttpTlsSelfSignedCertificateArgs()
        {
        }
    }
}
