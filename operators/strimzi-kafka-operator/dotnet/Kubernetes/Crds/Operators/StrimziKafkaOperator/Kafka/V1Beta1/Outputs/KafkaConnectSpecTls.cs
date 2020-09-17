// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaConnectSpecTls
    {
        /// <summary>
        /// Trusted certificates for TLS connection.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectSpecTlsTrustedCertificates> TrustedCertificates;

        [OutputConstructor]
        private KafkaConnectSpecTls(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectSpecTlsTrustedCertificates> trustedCertificates)
        {
            TrustedCertificates = trustedCertificates;
        }
    }
}