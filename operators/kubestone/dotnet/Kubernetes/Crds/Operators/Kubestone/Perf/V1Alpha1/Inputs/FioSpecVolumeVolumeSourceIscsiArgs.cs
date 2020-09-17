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
    /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md
    /// </summary>
    public class FioSpecVolumeVolumeSourceIscsiArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// whether support iSCSI Discovery CHAP authentication
        /// </summary>
        [Input("chapAuthDiscovery")]
        public Input<bool>? ChapAuthDiscovery { get; set; }

        /// <summary>
        /// whether support iSCSI Session CHAP authentication
        /// </summary>
        [Input("chapAuthSession")]
        public Input<bool>? ChapAuthSession { get; set; }

        /// <summary>
        /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi TODO: how do we prevent errors in the filesystem from compromising the machine
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// Custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface &lt;target portal&gt;:&lt;volume name&gt; will be created for the connection.
        /// </summary>
        [Input("initiatorName")]
        public Input<string>? InitiatorName { get; set; }

        /// <summary>
        /// Target iSCSI Qualified Name.
        /// </summary>
        [Input("iqn", required: true)]
        public Input<string> Iqn { get; set; } = null!;

        /// <summary>
        /// iSCSI Interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).
        /// </summary>
        [Input("iscsiInterface")]
        public Input<string>? IscsiInterface { get; set; }

        /// <summary>
        /// iSCSI Target Lun number.
        /// </summary>
        [Input("lun", required: true)]
        public Input<int> Lun { get; set; } = null!;

        [Input("portals")]
        private InputList<string>? _portals;

        /// <summary>
        /// iSCSI Target Portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
        /// </summary>
        public InputList<string> Portals
        {
            get => _portals ?? (_portals = new InputList<string>());
            set => _portals = value;
        }

        /// <summary>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// CHAP Secret for iSCSI target and initiator authentication
        /// </summary>
        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceIscsiSecretRefArgs>? SecretRef { get; set; }

        /// <summary>
        /// iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
        /// </summary>
        [Input("targetPortal", required: true)]
        public Input<string> TargetPortal { get; set; } = null!;

        public FioSpecVolumeVolumeSourceIscsiArgs()
        {
        }
    }
}
