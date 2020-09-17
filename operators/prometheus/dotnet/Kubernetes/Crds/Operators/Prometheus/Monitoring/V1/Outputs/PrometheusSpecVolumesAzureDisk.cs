// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class PrometheusSpecVolumesAzureDisk
    {
        /// <summary>
        /// Host Caching mode: None, Read Only, Read Write.
        /// </summary>
        public readonly string CachingMode;
        /// <summary>
        /// The Name of the data disk in the blob storage
        /// </summary>
        public readonly string DiskName;
        /// <summary>
        /// The URI the data disk in the blob storage
        /// </summary>
        public readonly string DiskURI;
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        public readonly bool ReadOnly;

        [OutputConstructor]
        private PrometheusSpecVolumesAzureDisk(
            string cachingMode,

            string diskName,

            string diskURI,

            string fsType,

            string kind,

            bool readOnly)
        {
            CachingMode = cachingMode;
            DiskName = diskName;
            DiskURI = diskURI;
            FsType = fsType;
            Kind = kind;
            ReadOnly = readOnly;
        }
    }
}
