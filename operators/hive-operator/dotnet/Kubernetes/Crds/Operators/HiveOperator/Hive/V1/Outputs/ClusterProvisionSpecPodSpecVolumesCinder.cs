// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterProvisionSpecPodSpecVolumesCinder
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// Optional: points to a secret object containing parameters used to connect to OpenStack.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecVolumesCinderSecretRef SecretRef;
        /// <summary>
        /// volume id used to identify the volume in cinder. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        public readonly string VolumeID;

        [OutputConstructor]
        private ClusterProvisionSpecPodSpecVolumesCinder(
            string fsType,

            bool readOnly,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecVolumesCinderSecretRef secretRef,

            string volumeID)
        {
            FsType = fsType;
            ReadOnly = readOnly;
            SecretRef = secretRef;
            VolumeID = volumeID;
        }
    }
}
