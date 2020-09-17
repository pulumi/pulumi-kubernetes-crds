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
    public sealed class KafkaUserSpecQuotas
    {
        /// <summary>
        /// A quota on the maximum bytes per-second that each client group can fetch from a broker before the clients in the group are throttled. Defined on a per-broker basis.
        /// </summary>
        public readonly int ConsumerByteRate;
        /// <summary>
        /// A quota on the maximum bytes per-second that each client group can publish to a broker before the clients in the group are throttled. Defined on a per-broker basis.
        /// </summary>
        public readonly int ProducerByteRate;
        /// <summary>
        /// A quota on the maximum CPU utilization of each client group as a percentage of network and I/O threads.
        /// </summary>
        public readonly int RequestPercentage;

        [OutputConstructor]
        private KafkaUserSpecQuotas(
            int consumerByteRate,

            int producerByteRate,

            int requestPercentage)
        {
            ConsumerByteRate = consumerByteRate;
            ProducerByteRate = producerByteRate;
            RequestPercentage = requestPercentage;
        }
    }
}