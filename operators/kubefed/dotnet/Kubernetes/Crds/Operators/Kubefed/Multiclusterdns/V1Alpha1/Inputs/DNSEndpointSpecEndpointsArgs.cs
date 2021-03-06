// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1
{

    public class DNSEndpointSpecEndpointsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The FQDN of the DNS record.
        /// </summary>
        [Input("dnsName")]
        public Input<string>? DnsName { get; set; }

        [Input("labels")]
        private InputMap<object>? _labels;

        /// <summary>
        /// Labels stores labels defined for the Endpoint.
        /// </summary>
        public InputMap<object> Labels
        {
            get => _labels ?? (_labels = new InputMap<object>());
            set => _labels = value;
        }

        /// <summary>
        /// TTL for the record in seconds.
        /// </summary>
        [Input("recordTTL")]
        public Input<int>? RecordTTL { get; set; }

        /// <summary>
        /// RecordType type of record, e.g. CNAME, A, SRV, TXT etc.
        /// </summary>
        [Input("recordType")]
        public Input<string>? RecordType { get; set; }

        [Input("targets")]
        private InputList<string>? _targets;

        /// <summary>
        /// The targets that the DNS record points to.
        /// </summary>
        public InputList<string> Targets
        {
            get => _targets ?? (_targets = new InputList<string>());
            set => _targets = value;
        }

        public DNSEndpointSpecEndpointsArgs()
        {
        }
    }
}
