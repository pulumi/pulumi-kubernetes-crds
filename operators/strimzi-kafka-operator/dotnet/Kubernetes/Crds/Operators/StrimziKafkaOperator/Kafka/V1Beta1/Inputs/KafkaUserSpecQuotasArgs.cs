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
    /// Quotas on requests to control the broker resources used by clients. Network bandwidth and request rate quotas can be enforced.Kafka documentation for Kafka User quotas can be found at http://kafka.apache.org/documentation/#design_quotas.
    /// </summary>
    public class KafkaUserSpecQuotasArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A quota on the maximum bytes per-second that each client group can fetch from a broker before the clients in the group are throttled. Defined on a per-broker basis.
        /// </summary>
        [Input("consumerByteRate")]
        public Input<int>? ConsumerByteRate { get; set; }

        /// <summary>
        /// A quota on the maximum bytes per-second that each client group can publish to a broker before the clients in the group are throttled. Defined on a per-broker basis.
        /// </summary>
        [Input("producerByteRate")]
        public Input<int>? ProducerByteRate { get; set; }

        /// <summary>
        /// A quota on the maximum CPU utilization of each client group as a percentage of network and I/O threads.
        /// </summary>
        [Input("requestPercentage")]
        public Input<int>? RequestPercentage { get; set; }

        public KafkaUserSpecQuotasArgs()
        {
        }
    }
}
