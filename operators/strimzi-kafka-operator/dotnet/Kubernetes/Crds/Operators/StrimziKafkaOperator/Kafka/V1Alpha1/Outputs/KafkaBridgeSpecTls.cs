// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaBridgeSpecTls
    {
        /// <summary>
        /// Trusted certificates for TLS connection.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecTlsTrustedCertificates> TrustedCertificates;

        [OutputConstructor]
        private KafkaBridgeSpecTls(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecTlsTrustedCertificates> trustedCertificates)
        {
            TrustedCertificates = trustedCertificates;
        }
    }
}
