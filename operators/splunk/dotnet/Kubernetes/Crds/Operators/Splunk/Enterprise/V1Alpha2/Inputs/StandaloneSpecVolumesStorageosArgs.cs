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
    /// StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
    /// </summary>
    public class StandaloneSpecVolumesStorageosArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.
        /// </summary>
        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecVolumesStorageosSecretRefArgs>? SecretRef { get; set; }

        /// <summary>
        /// VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.
        /// </summary>
        [Input("volumeName")]
        public Input<string>? VolumeName { get; set; }

        /// <summary>
        /// VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to "default" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.
        /// </summary>
        [Input("volumeNamespace")]
        public Input<string>? VolumeNamespace { get; set; }

        public StandaloneSpecVolumesStorageosArgs()
        {
        }
    }
}
