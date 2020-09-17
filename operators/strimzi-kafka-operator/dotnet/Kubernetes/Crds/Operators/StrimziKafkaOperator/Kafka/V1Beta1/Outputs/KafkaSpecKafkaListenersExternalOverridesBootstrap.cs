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
    public sealed class KafkaSpecKafkaListenersExternalOverridesBootstrap
    {
        /// <summary>
        /// Additional address name for the bootstrap service. The address will be added to the list of subject alternative names of the TLS certificates.
        /// </summary>
        public readonly string Address;
        /// <summary>
        /// Annotations that will be added to the `Service` resource. You can use this field to configure DNS providers such as External DNS.
        /// </summary>
        public readonly ImmutableDictionary<string, object> DnsAnnotations;
        /// <summary>
        /// Node port for the bootstrap service.
        /// </summary>
        public readonly int NodePort;

        [OutputConstructor]
        private KafkaSpecKafkaListenersExternalOverridesBootstrap(
            string address,

            ImmutableDictionary<string, object> dnsAnnotations,

            int nodePort)
        {
            Address = address;
            DnsAnnotations = dnsAnnotations;
            NodePort = nodePort;
        }
    }
}
