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
    /// Configures listeners of Kafka brokers.
    /// </summary>
    public class KafkaSpecKafkaListenersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configures external listener on port 9094.
        /// </summary>
        [Input("external")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersExternalArgs>? External { get; set; }

        /// <summary>
        /// Configures plain listener on port 9092.
        /// </summary>
        [Input("plain")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersPlainArgs>? Plain { get; set; }

        /// <summary>
        /// Configures TLS listener on port 9093.
        /// </summary>
        [Input("tls")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersTlsArgs>? Tls { get; set; }

        public KafkaSpecKafkaListenersArgs()
        {
        }
    }
}