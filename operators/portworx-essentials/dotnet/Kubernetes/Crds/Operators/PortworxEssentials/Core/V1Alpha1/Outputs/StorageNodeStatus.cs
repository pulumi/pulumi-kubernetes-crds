// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class StorageNodeStatus
    {
        /// <summary>
        /// Contains details for the current condition of this storage node.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageNodeStatusConditions> Conditions;
        /// <summary>
        /// Contains topology information for the storage node.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageNodeStatusGeography Geography;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageNodeStatusNetwork Network;
        /// <summary>
        /// Unique ID of the storage node.
        /// </summary>
        public readonly string NodeUid;
        /// <summary>
        /// Phase of the StorageNode is a simple, high-level summary of where the StorageNode is in its lifecycle. The condition array contains more detailed information about the state of the node.
        /// </summary>
        public readonly string Phase;

        [OutputConstructor]
        private StorageNodeStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageNodeStatusConditions> conditions,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageNodeStatusGeography geography,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageNodeStatusNetwork network,

            string nodeUid,

            string phase)
        {
            Conditions = conditions;
            Geography = geography;
            Network = network;
            NodeUid = nodeUid;
            Phase = phase;
        }
    }
}
