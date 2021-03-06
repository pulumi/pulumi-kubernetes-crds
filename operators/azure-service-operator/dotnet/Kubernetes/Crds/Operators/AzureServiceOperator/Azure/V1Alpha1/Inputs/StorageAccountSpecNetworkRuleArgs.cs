// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    public class StorageAccountSpecNetworkRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bypass - Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics. Possible values include: 'None', 'Logging', 'Metrics', 'AzureServices'
        /// </summary>
        [Input("bypass")]
        public Input<string>? Bypass { get; set; }

        /// <summary>
        /// DefaultAction - Specifies the default action of allow or deny when no other rules match. Possible values include: 'DefaultActionAllow', 'DefaultActionDeny'
        /// </summary>
        [Input("defaultAction")]
        public Input<string>? DefaultAction { get; set; }

        [Input("ipRules")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.StorageAccountSpecNetworkRuleIpRulesArgs>? _ipRules;

        /// <summary>
        /// IPRules - Sets the IP ACL rules
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.StorageAccountSpecNetworkRuleIpRulesArgs> IpRules
        {
            get => _ipRules ?? (_ipRules = new InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.StorageAccountSpecNetworkRuleIpRulesArgs>());
            set => _ipRules = value;
        }

        [Input("virtualNetworkRules")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.StorageAccountSpecNetworkRuleVirtualNetworkRulesArgs>? _virtualNetworkRules;

        /// <summary>
        /// VirtualNetworkRules - Sets the virtual network rules
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.StorageAccountSpecNetworkRuleVirtualNetworkRulesArgs> VirtualNetworkRules
        {
            get => _virtualNetworkRules ?? (_virtualNetworkRules = new InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.StorageAccountSpecNetworkRuleVirtualNetworkRulesArgs>());
            set => _virtualNetworkRules = value;
        }

        public StorageAccountSpecNetworkRuleArgs()
        {
        }
    }
}
