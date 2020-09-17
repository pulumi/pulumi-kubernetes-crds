// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1
{

    /// <summary>
    /// Most recently observed status of the storage cluster. This data may not be up to date.
    /// </summary>
    public class StorageClusterStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the storage cluster.
        /// </summary>
        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        /// <summary>
        /// Unique ID of the storage cluster.
        /// </summary>
        [Input("clusterUid")]
        public Input<string>? ClusterUid { get; set; }

        /// <summary>
        /// Count of hash collisions for the StorageCluster. The StorageCluster controller uses this field as a collision avoidance mechanism when it needs to create the name of the newest ControllerRevision.
        /// </summary>
        [Input("collisionCount")]
        public Input<int>? CollisionCount { get; set; }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Contains details for the current condition of this cluster.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// Phase of the StorageCluster is a simple, high-level summary of where the StorageCluster is in its lifecycle. The condition array contains more detailed information about the state of the cluster.
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        /// <summary>
        /// Contains details of storage in the cluster.
        /// </summary>
        [Input("storage")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterStatusStorageArgs>? Storage { get; set; }

        public StorageClusterStatusArgs()
        {
        }
    }
}