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
    public sealed class StorageClusterSpecDeleteStrategy
    {
        /// <summary>
        /// Type of storage cluster delete. Can be Uninstall or UninstallAndWipe. There is no default delete strategy. When no delete strategy only objects managed by the StorageCluster controller and owned by the StorageCluster object are deleted. The storage driver will be left in a state where it will not be managed by any object. Uninstall strategy ensures that the cluster is completely uninstalled even from the storage driver perspective. UninstallAndWipe strategy ensures that the cluster is completely uninstalled as well as the storage devices and metadata are wiped for reuse. This may result in data loss.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private StorageClusterSpecDeleteStrategy(string type)
        {
            Type = type;
        }
    }
}
