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
    public sealed class KafkaSpecKafkaListenersExternalConfiguration
    {
        /// <summary>
        /// External bootstrap ingress configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBootstrap Bootstrap;
        /// <summary>
        /// Reference to the `Secret` which holds the certificate and private key pair. The certificate can optionally contain the whole chain.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBrokerCertChainAndKey BrokerCertChainAndKey;
        /// <summary>
        /// External broker ingress configuration.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBrokers> Brokers;

        [OutputConstructor]
        private KafkaSpecKafkaListenersExternalConfiguration(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBootstrap bootstrap,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBrokerCertChainAndKey brokerCertChainAndKey,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBrokers> brokers)
        {
            Bootstrap = bootstrap;
            BrokerCertChainAndKey = brokerCertChainAndKey;
            Brokers = brokers;
        }
    }
}
