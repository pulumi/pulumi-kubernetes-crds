// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Scheduling.V1Alpha1
{

    public class ReplicaSchedulingPreferenceSpecArgs : Pulumi.ResourceArgs
    {
        [Input("clusters")]
        private InputMap<object>? _clusters;

        /// <summary>
        /// A mapping between cluster names and preferences regarding a local workload object (dep, rs, .. ) in these clusters. "*" (if provided) applies to all clusters if an explicit mapping is not provided. If omitted, clusters without explicit preferences should not have any replicas scheduled.
        /// </summary>
        public InputMap<object> Clusters
        {
            get => _clusters ?? (_clusters = new InputMap<object>());
            set => _clusters = value;
        }

        /// <summary>
        /// If set to true then already scheduled and running replicas may be moved to other clusters in order to match current state to the specified preferences. Otherwise, if set to false, up and running replicas will not be moved.
        /// </summary>
        [Input("rebalance")]
        public Input<bool>? Rebalance { get; set; }

        /// <summary>
        /// TODO (@irfanurrehman); upgrade this to label selector only if need be. The idea of this API is to have a a set of preferences which can be used for a target FederatedDeployment or FederatedReplicaset. Although the set of preferences in question can be applied to multiple target objects using label selectors, but there are no clear advantages of doing that as of now. To keep the implementation and usage simple, matching ns/name of RSP resource to the target resource is sufficient and only additional information needed in RSP resource is a target kind (FederatedDeployment or FederatedReplicaset).
        /// </summary>
        [Input("targetKind", required: true)]
        public Input<string> TargetKind { get; set; } = null!;

        /// <summary>
        /// Total number of pods desired across federated clusters. Replicas specified in the spec for target deployment template or replicaset template will be discarded/overridden when scheduling preferences are specified.
        /// </summary>
        [Input("totalReplicas", required: true)]
        public Input<int> TotalReplicas { get; set; } = null!;

        public ReplicaSchedulingPreferenceSpecArgs()
        {
        }
    }
}
