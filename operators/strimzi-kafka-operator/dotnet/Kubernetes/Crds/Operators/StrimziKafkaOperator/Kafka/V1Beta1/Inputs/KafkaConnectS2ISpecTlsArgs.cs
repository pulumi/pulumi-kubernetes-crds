// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    /// <summary>
    /// TLS configuration.
    /// </summary>
    public class KafkaConnectS2ISpecTlsArgs : Pulumi.ResourceArgs
    {
        [Input("trustedCertificates")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectS2ISpecTlsTrustedCertificatesArgs>? _trustedCertificates;

        /// <summary>
        /// Trusted certificates for TLS connection.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectS2ISpecTlsTrustedCertificatesArgs> TrustedCertificates
        {
            get => _trustedCertificates ?? (_trustedCertificates = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaConnectS2ISpecTlsTrustedCertificatesArgs>());
            set => _trustedCertificates = value;
        }

        public KafkaConnectS2ISpecTlsArgs()
        {
        }
    }
}
