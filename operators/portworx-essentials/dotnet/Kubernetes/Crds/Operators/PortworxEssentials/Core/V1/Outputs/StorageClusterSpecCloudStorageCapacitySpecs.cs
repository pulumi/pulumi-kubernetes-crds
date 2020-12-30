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
    public sealed class StorageClusterSpecCloudStorageCapacitySpecs
    {
        /// <summary>
        /// Maximum capacity for this storage cluster. The total capacity of devices created by this capacity spec should not be greater than this number for the entire cluster.
        /// </summary>
        public readonly int MaxCapacityInGiB;
        /// <summary>
        /// Minimum capacity for this storage cluster. The total capacity of devices created by this capacity spec should not be less than this number for the entire cluster.
        /// </summary>
        public readonly int MinCapacityInGiB;
        /// <summary>
        /// Minimum IOPS expected from the cloud drive.
        /// </summary>
        public readonly int MinIOPS;
        /// <summary>
        /// Additional options required to provision the drive in cloud.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Options;

        [OutputConstructor]
        private StorageClusterSpecCloudStorageCapacitySpecs(
            int maxCapacityInGiB,

            int minCapacityInGiB,

            int minIOPS,

            ImmutableDictionary<string, object> options)
        {
            MaxCapacityInGiB = maxCapacityInGiB;
            MinCapacityInGiB = minCapacityInGiB;
            MinIOPS = minIOPS;
            Options = options;
        }
    }
}