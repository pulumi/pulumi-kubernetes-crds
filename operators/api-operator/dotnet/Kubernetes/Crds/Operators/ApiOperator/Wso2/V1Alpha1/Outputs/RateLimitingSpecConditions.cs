// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1
{

    [OutputType]
    public sealed class RateLimitingSpecConditions
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.RateLimitingSpecConditionsHeaderCondition HeaderCondition;
        public readonly Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.RateLimitingSpecConditionsIpCondition IpCondition;

        [OutputConstructor]
        private RateLimitingSpecConditions(
            Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.RateLimitingSpecConditionsHeaderCondition headerCondition,

            Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.RateLimitingSpecConditionsIpCondition ipCondition)
        {
            HeaderCondition = headerCondition;
            IpCondition = ipCondition;
        }
    }
}
