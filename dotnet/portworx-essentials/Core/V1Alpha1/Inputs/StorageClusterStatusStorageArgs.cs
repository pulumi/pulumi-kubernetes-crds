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
    /// Contains details of storage in the cluster.
    /// </summary>
    public class StorageClusterStatusStorageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of storage nodes per zone in the cluster.
        /// </summary>
        [Input("storageNodesPerZone")]
        public Input<int>? StorageNodesPerZone { get; set; }

        public StorageClusterStatusStorageArgs()
        {
        }
    }
}
