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
    /// PodScheduling contains options to determine which node the pod should be scheduled on
    /// </summary>
    public class SysbenchSpecPodSchedulingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.SysbenchSpecPodSchedulingAffinityArgs>? Affinity { get; set; }

        /// <summary>
        /// NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.
        /// </summary>
        [Input("nodeName")]
        public Input<string>? NodeName { get; set; }

        [Input("nodeSelector")]
        private InputMap<string>? _nodeSelector;

        /// <summary>
        /// A node selector represents the union of the results of one or more label queries over a set of nodes; that is, it represents the OR of the selectors represented by the node selector terms.
        /// </summary>
        public InputMap<string> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<string>());
            set => _nodeSelector = value;
        }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.SysbenchSpecPodSchedulingTolerationsArgs>? _tolerations;

        /// <summary>
        /// If specified, the pod's tolerations.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.SysbenchSpecPodSchedulingTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.SysbenchSpecPodSchedulingTolerationsArgs>());
            set => _tolerations = value;
        }

        public SysbenchSpecPodSchedulingArgs()
        {
        }
    }
}
