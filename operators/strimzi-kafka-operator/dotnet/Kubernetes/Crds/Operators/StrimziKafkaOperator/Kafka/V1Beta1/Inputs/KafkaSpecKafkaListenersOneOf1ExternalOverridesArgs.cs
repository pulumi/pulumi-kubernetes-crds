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
    /// Overrides for external bootstrap and broker services and externally advertised addresses.
    /// </summary>
    public class KafkaSpecKafkaListenersOneOf1ExternalOverridesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// External bootstrap service configuration.
        /// </summary>
        [Input("bootstrap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf1ExternalOverridesBootstrapArgs>? Bootstrap { get; set; }

        [Input("brokers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf1ExternalOverridesBrokersArgs>? _brokers;

        /// <summary>
        /// External broker services configuration.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf1ExternalOverridesBrokersArgs> Brokers
        {
            get => _brokers ?? (_brokers = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf1ExternalOverridesBrokersArgs>());
            set => _brokers = value;
        }

        public KafkaSpecKafkaListenersOneOf1ExternalOverridesArgs()
        {
        }
    }
}
