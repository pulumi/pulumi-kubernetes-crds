// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class LicenseMasterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
    {
        /// <summary>
        /// A list of node selector requirements by node's labels.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions> MatchExpressions;
        /// <summary>
        /// A list of node selector requirements by node's fields.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields> MatchFields;

        [OutputConstructor]
        private LicenseMasterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions> matchExpressions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields> matchFields)
        {
            MatchExpressions = matchExpressions;
            MatchFields = matchFields;
        }
    }
}
