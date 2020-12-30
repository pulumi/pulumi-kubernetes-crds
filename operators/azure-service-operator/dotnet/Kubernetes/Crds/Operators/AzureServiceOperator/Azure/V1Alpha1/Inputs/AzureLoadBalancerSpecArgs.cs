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
    /// AzureLoadBalancerSpec defines the desired state of AzureLoadBalancer
    /// </summary>
    public class AzureLoadBalancerSpecArgs : Pulumi.ResourceArgs
    {
        [Input("backendAddressPoolName", required: true)]
        public Input<string> BackendAddressPoolName { get; set; } = null!;

        [Input("backendPort", required: true)]
        public Input<int> BackendPort { get; set; } = null!;

        [Input("frontendPortRangeEnd", required: true)]
        public Input<int> FrontendPortRangeEnd { get; set; } = null!;

        [Input("frontendPortRangeStart", required: true)]
        public Input<int> FrontendPortRangeStart { get; set; } = null!;

        [Input("inboundNatPoolName", required: true)]
        public Input<string> InboundNatPoolName { get; set; } = null!;

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("publicIPAddressName", required: true)]
        public Input<string> PublicIPAddressName { get; set; } = null!;

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        public AzureLoadBalancerSpecArgs()
        {
        }
    }
}