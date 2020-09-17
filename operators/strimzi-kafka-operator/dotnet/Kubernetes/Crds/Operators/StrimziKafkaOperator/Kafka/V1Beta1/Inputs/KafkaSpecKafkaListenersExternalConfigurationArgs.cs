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
    /// External listener configuration.
    /// </summary>
    public class KafkaSpecKafkaListenersExternalConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// External bootstrap ingress configuration.
        /// </summary>
        [Input("bootstrap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBootstrapArgs>? Bootstrap { get; set; }

        /// <summary>
        /// Reference to the `Secret` which holds the certificate and private key pair. The certificate can optionally contain the whole chain.
        /// </summary>
        [Input("brokerCertChainAndKey")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBrokerCertChainAndKeyArgs>? BrokerCertChainAndKey { get; set; }

        [Input("brokers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBrokersArgs>? _brokers;

        /// <summary>
        /// External broker ingress configuration.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBrokersArgs> Brokers
        {
            get => _brokers ?? (_brokers = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalConfigurationBrokersArgs>());
            set => _brokers = value;
        }

        public KafkaSpecKafkaListenersExternalConfigurationArgs()
        {
        }
    }
}
