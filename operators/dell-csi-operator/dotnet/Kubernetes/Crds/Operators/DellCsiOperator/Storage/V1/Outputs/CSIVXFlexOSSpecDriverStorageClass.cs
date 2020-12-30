// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIVXFlexOSSpecDriverStorageClass
    {
        /// <summary>
        /// AllowVolumeExpansion is a boolean flag which indicates if volumes can be expanded
        /// </summary>
        public readonly bool AllowVolumeExpansion;
        /// <summary>
        /// Restrict the node topologies where volumes can be dynamically provisioned.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIVXFlexOSSpecDriverStorageClassAllowedTopologies> AllowedTopologies;
        /// <summary>
        /// DefaultSc is a boolean flag to indicate if the storage class is going to be marked as default
        /// </summary>
        public readonly bool Default;
        /// <summary>
        /// Name is the name of the StorageClass
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Parameters is a map of driver specific storage class
        /// </summary>
        public readonly ImmutableDictionary<string, string> Parameters;
        /// <summary>
        /// ReclaimPolicy is the reclaim policy for the storage class
        /// </summary>
        public readonly string ReclaimPolicy;

        [OutputConstructor]
        private CSIVXFlexOSSpecDriverStorageClass(
            bool allowVolumeExpansion,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIVXFlexOSSpecDriverStorageClassAllowedTopologies> allowedTopologies,

            bool @default,

            string name,

            ImmutableDictionary<string, string> parameters,

            string reclaimPolicy)
        {
            AllowVolumeExpansion = allowVolumeExpansion;
            AllowedTopologies = allowedTopologies;
            Default = @default;
            Name = name;
            Parameters = parameters;
            ReclaimPolicy = reclaimPolicy;
        }
    }
}
