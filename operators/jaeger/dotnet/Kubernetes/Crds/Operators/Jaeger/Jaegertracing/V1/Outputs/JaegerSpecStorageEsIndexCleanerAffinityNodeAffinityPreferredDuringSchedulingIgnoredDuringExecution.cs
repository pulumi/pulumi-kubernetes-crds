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
    public sealed class JaegerSpecStorageEsIndexCleanerAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageEsIndexCleanerAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference;
        public readonly int Weight;

        [OutputConstructor]
        private JaegerSpecStorageEsIndexCleanerAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageEsIndexCleanerAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference preference,

            int weight)
        {
            Preference = preference;
            Weight = weight;
        }
    }
}