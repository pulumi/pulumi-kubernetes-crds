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
    /// RedisCacheFirewallRuleSpec defines the desired state of RedisCacheFirewallRule
    /// </summary>
    public class RedisCacheFirewallRuleSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// RedisCacheFirewallRuleProperties the parameters of the RedisCacheFirewallRule
        /// </summary>
        [Input("properties", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.RedisCacheFirewallRuleSpecPropertiesArgs> Properties { get; set; } = null!;

        [Input("redisCache", required: true)]
        public Input<string> RedisCache { get; set; } = null!;

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        public RedisCacheFirewallRuleSpecArgs()
        {
        }
    }
}
