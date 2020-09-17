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
    public sealed class KafkaConnectSpecTlsTrustedCertificates
    {
        /// <summary>
        /// The name of the file certificate in the Secret.
        /// </summary>
        public readonly string Certificate;
        /// <summary>
        /// The name of the Secret containing the certificate.
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private KafkaConnectSpecTlsTrustedCertificates(
            string certificate,

            string secretName)
        {
            Certificate = certificate;
            SecretName = secretName;
        }
    }
}
