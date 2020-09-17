// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md
    /// </summary>
    public class PrometheusSpecVolumesRbdArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd TODO: how do we prevent errors in the filesystem from compromising the machine
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// The rados image name. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        /// <summary>
        /// Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [Input("keyring")]
        public Input<string>? Keyring { get; set; }

        [Input("monitors", required: true)]
        private InputList<string>? _monitors;

        /// <summary>
        /// A collection of Ceph monitors. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        public InputList<string> Monitors
        {
            get => _monitors ?? (_monitors = new InputList<string>());
            set => _monitors = value;
        }

        /// <summary>
        /// The rados pool name. Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [Input("pool")]
        public Input<string>? Pool { get; set; }

        /// <summary>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecVolumesRbdSecretRefArgs>? SecretRef { get; set; }

        /// <summary>
        /// The rados user name. Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public PrometheusSpecVolumesRbdArgs()
        {
        }
    }
}
