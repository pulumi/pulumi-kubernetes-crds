// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class Iperf3SpecServerConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
    {
        /// <summary>
        /// A node selector term, associated with the corresponding weight.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.Iperf3SpecServerConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference;
        /// <summary>
        /// Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private Iperf3SpecServerConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution(
            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.Iperf3SpecServerConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference preference,

            int weight)
        {
            Preference = preference;
            Weight = weight;
        }
    }
}
