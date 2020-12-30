// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1
{

    /// <summary>
    /// Conditions is exported type in Ratelimiting Spec
    /// </summary>
    public class RateLimitingSpecConditionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// HeaderCondition is exported type in Ratelimiting Spec
        /// </summary>
        [Input("headerCondition", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1.RateLimitingSpecConditionsHeaderConditionArgs> HeaderCondition { get; set; } = null!;

        /// <summary>
        /// IPCondition is exported type in Ratelimiting Spec
        /// </summary>
        [Input("ipCondition", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1.RateLimitingSpecConditionsIpConditionArgs> IpCondition { get; set; } = null!;

        public RateLimitingSpecConditionsArgs()
        {
        }
    }
}
