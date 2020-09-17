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
    /// JMX Options for Kafka brokers.
    /// </summary>
    public class KafkaSpecKafkaJmxOptionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Authentication configuration for connecting to the Kafka JMX port.
        /// </summary>
        [Input("authentication")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaJmxOptionsAuthenticationArgs>? Authentication { get; set; }

        public KafkaSpecKafkaJmxOptionsArgs()
        {
        }
    }
}
