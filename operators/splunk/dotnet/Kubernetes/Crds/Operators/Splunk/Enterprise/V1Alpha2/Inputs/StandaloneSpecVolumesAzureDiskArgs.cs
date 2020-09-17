// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2
{

    /// <summary>
    /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
    /// </summary>
    public class StandaloneSpecVolumesAzureDiskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Host Caching mode: None, Read Only, Read Write.
        /// </summary>
        [Input("cachingMode")]
        public Input<string>? CachingMode { get; set; }

        /// <summary>
        /// The Name of the data disk in the blob storage
        /// </summary>
        [Input("diskName", required: true)]
        public Input<string> DiskName { get; set; } = null!;

        /// <summary>
        /// The URI the data disk in the blob storage
        /// </summary>
        [Input("diskURI", required: true)]
        public Input<string> DiskURI { get; set; } = null!;

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        public StandaloneSpecVolumesAzureDiskArgs()
        {
        }
    }
}
