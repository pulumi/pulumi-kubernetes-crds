// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kibana.V1
{

    [OutputType]
    public sealed class KibanaSpecHttpTlsSelfSignedCertificate
    {
        /// <summary>
        /// Disabled indicates that the provisioning of the self-signed certifcate should be disabled.
        /// </summary>
        public readonly bool Disabled;
        /// <summary>
        /// SubjectAlternativeNames is a list of SANs to include in the generated HTTP TLS certificate.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kibana.V1.KibanaSpecHttpTlsSelfSignedCertificateSubjectAltNames> SubjectAltNames;

        [OutputConstructor]
        private KibanaSpecHttpTlsSelfSignedCertificate(
            bool disabled,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kibana.V1.KibanaSpecHttpTlsSelfSignedCertificateSubjectAltNames> subjectAltNames)
        {
            Disabled = disabled;
            SubjectAltNames = subjectAltNames;
        }
    }
}
