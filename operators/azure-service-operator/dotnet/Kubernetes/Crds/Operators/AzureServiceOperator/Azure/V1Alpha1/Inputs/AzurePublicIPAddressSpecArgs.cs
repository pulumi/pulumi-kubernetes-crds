// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    /// <summary>
    /// AzurePublicIPAddressSpec defines the desired state of AzurePublicIPAddress
    /// </summary>
    public class AzurePublicIPAddressSpecArgs : Pulumi.ResourceArgs
    {
        [Input("idleTimeoutInMinutes", required: true)]
        public Input<int> IdleTimeoutInMinutes { get; set; } = null!;

        [Input("ipTags")]
        private InputMap<string>? _ipTags;
        public InputMap<string> IpTags
        {
            get => _ipTags ?? (_ipTags = new InputMap<string>());
            set => _ipTags = value;
        }

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("publicIPAddressVersion", required: true)]
        public Input<string> PublicIPAddressVersion { get; set; } = null!;

        [Input("publicIPAllocationMethod", required: true)]
        public Input<string> PublicIPAllocationMethod { get; set; } = null!;

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        [Input("skuName", required: true)]
        public Input<string> SkuName { get; set; } = null!;

        public AzurePublicIPAddressSpecArgs()
        {
        }
    }
}
