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
    public sealed class KafkaSpecKafkaListenersExternalConfigurationBrokerCertChainAndKey
    {
        /// <summary>
        /// The name of the file certificate in the Secret.
        /// </summary>
        public readonly string Certificate;
        /// <summary>
        /// The name of the private key in the Secret.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// The name of the Secret containing the certificate.
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private KafkaSpecKafkaListenersExternalConfigurationBrokerCertChainAndKey(
            string certificate,

            string key,

            string secretName)
        {
            Certificate = certificate;
            Key = key;
            SecretName = secretName;
        }
    }
}
