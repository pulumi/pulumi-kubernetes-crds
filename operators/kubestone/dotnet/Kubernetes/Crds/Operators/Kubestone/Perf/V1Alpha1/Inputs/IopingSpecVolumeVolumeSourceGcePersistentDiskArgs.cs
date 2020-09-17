// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1
{

    /// <summary>
    /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
    /// </summary>
    public class IopingSpecVolumeVolumeSourceGcePersistentDiskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk TODO: how do we prevent errors in the filesystem from compromising the machine
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty). More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [Input("partition")]
        public Input<int>? Partition { get; set; }

        /// <summary>
        /// Unique name of the PD resource in GCE. Used to identify the disk in GCE. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [Input("pdName", required: true)]
        public Input<string> PdName { get; set; } = null!;

        /// <summary>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        public IopingSpecVolumeVolumeSourceGcePersistentDiskArgs()
        {
        }
    }
}
