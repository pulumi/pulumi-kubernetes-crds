// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
    /// </summary>
    public class ThanosRulerSpecAffinityPodAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("preferredDuringSchedulingIgnoredDuringExecution")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs>? _preferredDuringSchedulingIgnoredDuringExecution;

        /// <summary>
        /// The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs> PreferredDuringSchedulingIgnoredDuringExecution
        {
            get => _preferredDuringSchedulingIgnoredDuringExecution ?? (_preferredDuringSchedulingIgnoredDuringExecution = new InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs>());
            set => _preferredDuringSchedulingIgnoredDuringExecution = value;
        }

        [Input("requiredDuringSchedulingIgnoredDuringExecution")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs>? _requiredDuringSchedulingIgnoredDuringExecution;

        /// <summary>
        /// If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs> RequiredDuringSchedulingIgnoredDuringExecution
        {
            get => _requiredDuringSchedulingIgnoredDuringExecution ?? (_requiredDuringSchedulingIgnoredDuringExecution = new InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs>());
            set => _requiredDuringSchedulingIgnoredDuringExecution = value;
        }

        public ThanosRulerSpecAffinityPodAffinityArgs()
        {
        }
    }
}
