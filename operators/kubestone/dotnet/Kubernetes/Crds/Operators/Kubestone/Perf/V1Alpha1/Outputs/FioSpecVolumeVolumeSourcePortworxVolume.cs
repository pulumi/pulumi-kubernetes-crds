// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class FioSpecVolumeVolumeSourcePortworxVolume
    {
        /// <summary>
        /// FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// VolumeID uniquely identifies a Portworx volume
        /// </summary>
        public readonly string VolumeID;

        [OutputConstructor]
        private FioSpecVolumeVolumeSourcePortworxVolume(
            string fsType,

            bool readOnly,

            string volumeID)
        {
            FsType = fsType;
            ReadOnly = readOnly;
            VolumeID = volumeID;
        }
    }
}
