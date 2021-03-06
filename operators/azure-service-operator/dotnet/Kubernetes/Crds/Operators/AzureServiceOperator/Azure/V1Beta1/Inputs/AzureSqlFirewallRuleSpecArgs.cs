// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Beta1
{

    /// <summary>
    /// AzureSqlFirewallRuleSpec defines the desired state of AzureSqlFirewallRule
    /// </summary>
    public class AzureSqlFirewallRuleSpecArgs : Pulumi.ResourceArgs
    {
        [Input("endIpAddress")]
        public Input<string>? EndIpAddress { get; set; }

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        [Input("server", required: true)]
        public Input<string> Server { get; set; } = null!;

        [Input("startIpAddress")]
        public Input<string>? StartIpAddress { get; set; }

        public AzureSqlFirewallRuleSpecArgs()
        {
        }
    }
}
