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
    /// External bootstrap service configuration.
    /// </summary>
    public class KafkaSpecKafkaListenersOneOf1ExternalOverridesBootstrapArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Additional address name for the bootstrap service. The address will be added to the list of subject alternative names of the TLS certificates.
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        [Input("dnsAnnotations")]
        private InputMap<object>? _dnsAnnotations;

        /// <summary>
        /// Annotations that will be added to the `Service` resource. You can use this field to configure DNS providers such as External DNS.
        /// </summary>
        public InputMap<object> DnsAnnotations
        {
            get => _dnsAnnotations ?? (_dnsAnnotations = new InputMap<object>());
            set => _dnsAnnotations = value;
        }

        /// <summary>
        /// Node port for the bootstrap service.
        /// </summary>
        [Input("nodePort")]
        public Input<int>? NodePort { get; set; }

        public KafkaSpecKafkaListenersOneOf1ExternalOverridesBootstrapArgs()
        {
        }
    }
}
