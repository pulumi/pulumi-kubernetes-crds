// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    public class StorageAccountSpecNetworkRuleVirtualNetworkRulesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SubnetId - Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public StorageAccountSpecNetworkRuleVirtualNetworkRulesArgs()
        {
        }
    }
}
