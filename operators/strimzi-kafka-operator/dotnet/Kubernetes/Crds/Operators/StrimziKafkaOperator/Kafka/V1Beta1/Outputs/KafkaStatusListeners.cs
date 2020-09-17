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
    public sealed class KafkaStatusListeners
    {
        /// <summary>
        /// A list of the addresses for this listener.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaStatusListenersAddresses> Addresses;
        /// <summary>
        /// A comma-separated list of `host:port` pairs for connecting to the Kafka cluster using this listener.
        /// </summary>
        public readonly string BootstrapServers;
        /// <summary>
        /// A list of TLS certificates which can be used to verify the identity of the server when connecting to the given listener. Set only for `tls` and `external` listeners.
        /// </summary>
        public readonly ImmutableArray<string> Certificates;
        /// <summary>
        /// The type of the listener. Can be one of the following three types: `plain`, `tls`, and `external`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KafkaStatusListeners(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaStatusListenersAddresses> addresses,

            string bootstrapServers,

            ImmutableArray<string> certificates,

            string type)
        {
            Addresses = addresses;
            BootstrapServers = bootstrapServers;
            Certificates = certificates;
            Type = type;
        }
    }
}
