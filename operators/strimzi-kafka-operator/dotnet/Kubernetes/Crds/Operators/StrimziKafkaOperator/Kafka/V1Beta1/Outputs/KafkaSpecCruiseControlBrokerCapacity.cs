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
    public sealed class KafkaSpecCruiseControlBrokerCapacity
    {
        /// <summary>
        /// Broker capacity for CPU resource utilization as a percentage (0 - 100).
        /// </summary>
        public readonly int CpuUtilization;
        /// <summary>
        /// Broker capacity for disk in bytes, for example, 100Gi.
        /// </summary>
        public readonly string Disk;
        /// <summary>
        /// Broker capacity for inbound network throughput in bytes per second, for example, 10000KB/s.
        /// </summary>
        public readonly string InboundNetwork;
        /// <summary>
        /// Broker capacity for outbound network throughput in bytes per second, for example 10000KB/s.
        /// </summary>
        public readonly string OutboundNetwork;

        [OutputConstructor]
        private KafkaSpecCruiseControlBrokerCapacity(
            int cpuUtilization,

            string disk,

            string inboundNetwork,

            string outboundNetwork)
        {
            CpuUtilization = cpuUtilization;
            Disk = disk;
            InboundNetwork = inboundNetwork;
            OutboundNetwork = outboundNetwork;
        }
    }
}
