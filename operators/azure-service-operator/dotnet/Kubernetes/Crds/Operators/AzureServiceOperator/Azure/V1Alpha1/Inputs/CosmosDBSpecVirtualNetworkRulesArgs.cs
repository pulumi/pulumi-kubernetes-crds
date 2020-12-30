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
    /// CosmosDBVirtualNetworkRule virtual Network ACL Rule object
    /// </summary>
    public class CosmosDBSpecVirtualNetworkRulesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// IgnoreMissingVNetServiceEndpoint - Create firewall rule before the virtual network has vnet service endpoint enabled.
        /// </summary>
        [Input("ignoreMissingVNetServiceEndpoint")]
        public Input<bool>? IgnoreMissingVNetServiceEndpoint { get; set; }

        /// <summary>
        /// ID - Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
        /// </summary>
        [Input("subnetID")]
        public Input<string>? SubnetID { get; set; }

        public CosmosDBSpecVirtualNetworkRulesArgs()
        {
        }
    }
}
