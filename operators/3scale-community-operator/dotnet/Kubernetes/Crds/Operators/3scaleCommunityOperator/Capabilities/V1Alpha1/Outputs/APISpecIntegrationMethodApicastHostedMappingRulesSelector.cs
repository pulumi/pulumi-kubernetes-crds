// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1
{

    [OutputType]
    public sealed class APISpecIntegrationMethodApicastHostedMappingRulesSelector
    {
        public readonly ImmutableArray<object> MatchExpressions;
        public readonly ImmutableDictionary<string, object> MatchLabels;

        [OutputConstructor]
        private APISpecIntegrationMethodApicastHostedMappingRulesSelector(
            ImmutableArray<object> matchExpressions,

            ImmutableDictionary<string, object> matchLabels)
        {
            MatchExpressions = matchExpressions;
            MatchLabels = matchLabels;
        }
    }
}
