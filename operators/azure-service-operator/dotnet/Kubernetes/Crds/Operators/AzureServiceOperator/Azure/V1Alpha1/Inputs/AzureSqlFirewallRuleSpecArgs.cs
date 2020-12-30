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
    /// AzureSqlFirewallRuleSpec defines the desired state of AzureSqlFirewallRule
    /// </summary>
    public class AzureSqlFirewallRuleSpecArgs : Pulumi.ResourceArgs
    {
        [Input("endipaddress")]
        public Input<string>? Endipaddress { get; set; }

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("resourcegroup", required: true)]
        public Input<string> Resourcegroup { get; set; } = null!;

        [Input("server", required: true)]
        public Input<string> Server { get; set; } = null!;

        [Input("startipaddress")]
        public Input<string>? Startipaddress { get; set; }

        public AzureSqlFirewallRuleSpecArgs()
        {
        }
    }
}