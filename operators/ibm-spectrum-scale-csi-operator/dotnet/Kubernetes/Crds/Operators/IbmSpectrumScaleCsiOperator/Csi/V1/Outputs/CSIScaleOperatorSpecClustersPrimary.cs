// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Csi.V1
{

    [OutputType]
    public sealed class CSIScaleOperatorSpecClustersPrimary
    {
        /// <summary>
        /// Inode limit for Primary Fileset.
        /// </summary>
        public readonly string InodeLimit;
        /// <summary>
        /// The name of the primary filesystem.
        /// </summary>
        public readonly string PrimaryFs;
        /// <summary>
        /// The name of the primary fileset, created in primaryFs.
        /// </summary>
        public readonly string PrimaryFset;
        /// <summary>
        /// Remote cluster ID.
        /// </summary>
        public readonly string RemoteCluster;

        [OutputConstructor]
        private CSIScaleOperatorSpecClustersPrimary(
            string inodeLimit,

            string primaryFs,

            string primaryFset,

            string remoteCluster)
        {
            InodeLimit = inodeLimit;
            PrimaryFs = primaryFs;
            PrimaryFset = primaryFset;
            RemoteCluster = remoteCluster;
        }
    }
}
