// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1
{

    [OutputType]
    public sealed class KubeFedClusterSpec
    {
        /// <summary>
        /// The API endpoint of the member cluster. This can be a hostname, hostname:port, IP or IP:port.
        /// </summary>
        public readonly string ApiEndpoint;
        /// <summary>
        /// CABundle contains the certificate authority information.
        /// </summary>
        public readonly string CaBundle;
        /// <summary>
        /// DisabledTLSValidations defines a list of checks to ignore when validating the TLS connection to the member cluster.  This can be any of *, SubjectName, or ValidityPeriod. If * is specified, it is expected to be the only option in list.
        /// </summary>
        public readonly ImmutableArray<string> DisabledTLSValidations;
        /// <summary>
        /// Name of the secret containing the token required to access the member cluster. The secret needs to exist in the same namespace as the control plane and should have a "token" key.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedClusterSpecSecretRef SecretRef;

        [OutputConstructor]
        private KubeFedClusterSpec(
            string apiEndpoint,

            string caBundle,

            ImmutableArray<string> disabledTLSValidations,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedClusterSpecSecretRef secretRef)
        {
            ApiEndpoint = apiEndpoint;
            CaBundle = caBundle;
            DisabledTLSValidations = disabledTLSValidations;
            SecretRef = secretRef;
        }
    }
}
