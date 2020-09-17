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
    public sealed class PrometheusSpecVolumesRbd
    {
        /// <summary>
        /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd TODO: how do we prevent errors in the filesystem from compromising the machine
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// The rados image name. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        public readonly string Keyring;
        /// <summary>
        /// A collection of Ceph monitors. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        public readonly ImmutableArray<string> Monitors;
        /// <summary>
        /// The rados pool name. Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        public readonly string Pool;
        /// <summary>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesRbdSecretRef SecretRef;
        /// <summary>
        /// The rados user name. Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        public readonly string User;

        [OutputConstructor]
        private PrometheusSpecVolumesRbd(
            string fsType,

            string image,

            string keyring,

            ImmutableArray<string> monitors,

            string pool,

            bool readOnly,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesRbdSecretRef secretRef,

            string user)
        {
            FsType = fsType;
            Image = image;
            Keyring = keyring;
            Monitors = monitors;
            Pool = pool;
            ReadOnly = readOnly;
            SecretRef = secretRef;
            User = user;
        }
    }
}
