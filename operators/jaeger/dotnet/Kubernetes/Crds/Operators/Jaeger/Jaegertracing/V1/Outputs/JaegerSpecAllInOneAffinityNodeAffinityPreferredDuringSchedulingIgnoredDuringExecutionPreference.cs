// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1
{

    [OutputType]
    public sealed class JaegerSpecAllInOneAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions> MatchExpressions;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields> MatchFields;

        [OutputConstructor]
        private JaegerSpecAllInOneAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions> matchExpressions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields> matchFields)
        {
            MatchExpressions = matchExpressions;
            MatchFields = matchFields;
        }
    }
}