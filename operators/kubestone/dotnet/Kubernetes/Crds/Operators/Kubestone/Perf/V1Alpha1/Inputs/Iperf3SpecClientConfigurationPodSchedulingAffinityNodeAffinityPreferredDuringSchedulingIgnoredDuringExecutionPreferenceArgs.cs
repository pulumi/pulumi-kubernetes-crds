// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1
{

    /// <summary>
    /// A node selector term, associated with the corresponding weight.
    /// </summary>
    public class Iperf3SpecClientConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs : Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.Iperf3SpecClientConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionsArgs>? _matchExpressions;

        /// <summary>
        /// A list of node selector requirements by node's labels.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.Iperf3SpecClientConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.Iperf3SpecClientConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchFields")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.Iperf3SpecClientConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldsArgs>? _matchFields;

        /// <summary>
        /// A list of node selector requirements by node's fields.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.Iperf3SpecClientConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldsArgs> MatchFields
        {
            get => _matchFields ?? (_matchFields = new InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.Iperf3SpecClientConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldsArgs>());
            set => _matchFields = value;
        }

        public Iperf3SpecClientConfigurationPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs()
        {
        }
    }
}
