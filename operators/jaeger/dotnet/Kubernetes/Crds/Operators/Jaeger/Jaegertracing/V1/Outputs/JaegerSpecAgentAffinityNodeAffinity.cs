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
    public sealed class JaegerSpecAgentAffinityNodeAffinity
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution> PreferredDuringSchedulingIgnoredDuringExecution;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution RequiredDuringSchedulingIgnoredDuringExecution;

        [OutputConstructor]
        private JaegerSpecAgentAffinityNodeAffinity(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution> preferredDuringSchedulingIgnoredDuringExecution,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution requiredDuringSchedulingIgnoredDuringExecution)
        {
            PreferredDuringSchedulingIgnoredDuringExecution = preferredDuringSchedulingIgnoredDuringExecution;
            RequiredDuringSchedulingIgnoredDuringExecution = requiredDuringSchedulingIgnoredDuringExecution;
        }
    }
}