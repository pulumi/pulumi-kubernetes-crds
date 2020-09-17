// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class LicenseMasterSpecVolumesFc
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. TODO: how do we prevent errors in the filesystem from compromising the machine
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// Optional: FC target lun number
        /// </summary>
        public readonly int Lun;
        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// Optional: FC target worldwide names (WWNs)
        /// </summary>
        public readonly ImmutableArray<string> TargetWWNs;
        /// <summary>
        /// Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.
        /// </summary>
        public readonly ImmutableArray<string> Wwids;

        [OutputConstructor]
        private LicenseMasterSpecVolumesFc(
            string fsType,

            int lun,

            bool readOnly,

            ImmutableArray<string> targetWWNs,

            ImmutableArray<string> wwids)
        {
            FsType = fsType;
            Lun = lun;
            ReadOnly = readOnly;
            TargetWWNs = targetWWNs;
            Wwids = wwids;
        }
    }
}
