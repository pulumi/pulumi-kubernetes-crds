// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// Condition status for the Nexus deployment
    /// </summary>
    public class NexusStatusDeploymentStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.
        /// </summary>
        [Input("availableReplicas")]
        public Input<int>? AvailableReplicas { get; set; }

        /// <summary>
        /// Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.
        /// </summary>
        [Input("collisionCount")]
        public Input<int>? CollisionCount { get; set; }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusStatusDeploymentStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Represents the latest available observations of a deployment's current state.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusStatusDeploymentStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.NexusStatusDeploymentStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// The generation observed by the deployment controller.
        /// </summary>
        [Input("observedGeneration")]
        public Input<int>? ObservedGeneration { get; set; }

        /// <summary>
        /// Total number of ready pods targeted by this deployment.
        /// </summary>
        [Input("readyReplicas")]
        public Input<int>? ReadyReplicas { get; set; }

        /// <summary>
        /// Total number of non-terminated pods targeted by this deployment (their labels match the selector).
        /// </summary>
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        /// <summary>
        /// Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.
        /// </summary>
        [Input("unavailableReplicas")]
        public Input<int>? UnavailableReplicas { get; set; }

        /// <summary>
        /// Total number of non-terminated pods targeted by this deployment that have the desired template spec.
        /// </summary>
        [Input("updatedReplicas")]
        public Input<int>? UpdatedReplicas { get; set; }

        public NexusStatusDeploymentStatusArgs()
        {
        }
    }
}
