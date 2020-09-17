// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1
{

    /// <summary>
    /// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
    /// </summary>
    public class DatadogAgentSpecClusterAgentConfigVolumesPhotonPersistentDiskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// ID that identifies Photon Controller persistent disk
        /// </summary>
        [Input("pdID", required: true)]
        public Input<string> PdID { get; set; } = null!;

        public DatadogAgentSpecClusterAgentConfigVolumesPhotonPersistentDiskArgs()
        {
        }
    }
}
