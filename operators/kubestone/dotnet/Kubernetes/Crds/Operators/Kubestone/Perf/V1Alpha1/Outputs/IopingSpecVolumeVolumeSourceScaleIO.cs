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
    public sealed class IopingSpecVolumeVolumeSourceScaleIO
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs".
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// The host address of the ScaleIO API Gateway.
        /// </summary>
        public readonly string Gateway;
        /// <summary>
        /// The name of the ScaleIO Protection Domain for the configured storage.
        /// </summary>
        public readonly string ProtectionDomain;
        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.IopingSpecVolumeVolumeSourceScaleIOSecretRef SecretRef;
        /// <summary>
        /// Flag to enable/disable SSL communication with Gateway, default false
        /// </summary>
        public readonly bool SslEnabled;
        /// <summary>
        /// Indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.
        /// </summary>
        public readonly string StorageMode;
        /// <summary>
        /// The ScaleIO Storage Pool associated with the protection domain.
        /// </summary>
        public readonly string StoragePool;
        /// <summary>
        /// The name of the storage system as configured in ScaleIO.
        /// </summary>
        public readonly string System;
        /// <summary>
        /// The name of a volume already created in the ScaleIO system that is associated with this volume source.
        /// </summary>
        public readonly string VolumeName;

        [OutputConstructor]
        private IopingSpecVolumeVolumeSourceScaleIO(
            string fsType,

            string gateway,

            string protectionDomain,

            bool readOnly,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.IopingSpecVolumeVolumeSourceScaleIOSecretRef secretRef,

            bool sslEnabled,

            string storageMode,

            string storagePool,

            string system,

            string volumeName)
        {
            FsType = fsType;
            Gateway = gateway;
            ProtectionDomain = protectionDomain;
            ReadOnly = readOnly;
            SecretRef = secretRef;
            SslEnabled = sslEnabled;
            StorageMode = storageMode;
            StoragePool = storagePool;
            System = system;
            VolumeName = volumeName;
        }
    }
}
