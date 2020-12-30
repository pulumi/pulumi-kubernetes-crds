// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    [OutputType]
    public sealed class StorageClusterSpecNodesNetwork
    {
        /// <summary>
        /// Name of the network interface used by the storage driver for data traffic.
        /// </summary>
        public readonly string DataInterface;
        /// <summary>
        /// Name of the network interface used by the storage driver for management traffic.
        /// </summary>
        public readonly string MgmtInterface;

        [OutputConstructor]
        private StorageClusterSpecNodesNetwork(
            string dataInterface,

            string mgmtInterface)
        {
            DataInterface = dataInterface;
            MgmtInterface = mgmtInterface;
        }
    }
}
