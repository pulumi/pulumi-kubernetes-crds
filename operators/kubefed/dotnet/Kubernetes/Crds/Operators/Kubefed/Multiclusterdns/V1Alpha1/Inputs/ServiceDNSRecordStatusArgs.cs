// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1
{

    public class ServiceDNSRecordStatusArgs : Pulumi.ResourceArgs
    {
        [Input("dns")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1.ServiceDNSRecordStatusDnsArgs>? _dns;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1.ServiceDNSRecordStatusDnsArgs> Dns
        {
            get => _dns ?? (_dns = new InputList<Pulumi.Kubernetes.Types.Inputs.Multiclusterdns.V1Alpha1.ServiceDNSRecordStatusDnsArgs>());
            set => _dns = value;
        }

        /// <summary>
        /// Domain is the DNS domain of the KubeFed control plane as in Domain API
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        public ServiceDNSRecordStatusArgs()
        {
        }
    }
}
