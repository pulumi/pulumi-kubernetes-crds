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
    /// Cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
    /// </summary>
    public class SearchHeadClusterSpecVolumesCinderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// Optional: points to a secret object containing parameters used to connect to OpenStack.
        /// </summary>
        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SearchHeadClusterSpecVolumesCinderSecretRefArgs>? SecretRef { get; set; }

        /// <summary>
        /// volume id used to identify the volume in cinder. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        [Input("volumeID", required: true)]
        public Input<string> VolumeID { get; set; } = null!;

        public SearchHeadClusterSpecVolumesCinderArgs()
        {
        }
    }
}
