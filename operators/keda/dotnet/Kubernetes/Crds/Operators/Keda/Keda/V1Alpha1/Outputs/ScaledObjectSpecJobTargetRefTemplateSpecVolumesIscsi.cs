// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1
{

    [OutputType]
    public sealed class ScaledObjectSpecJobTargetRefTemplateSpecVolumesIscsi
    {
        /// <summary>
        /// whether support iSCSI Discovery CHAP authentication
        /// </summary>
        public readonly bool ChapAuthDiscovery;
        /// <summary>
        /// whether support iSCSI Session CHAP authentication
        /// </summary>
        public readonly bool ChapAuthSession;
        /// <summary>
        /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi TODO: how do we prevent errors in the filesystem from compromising the machine
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// Custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface &lt;target portal&gt;:&lt;volume name&gt; will be created for the connection.
        /// </summary>
        public readonly string InitiatorName;
        /// <summary>
        /// Target iSCSI Qualified Name.
        /// </summary>
        public readonly string Iqn;
        /// <summary>
        /// iSCSI Interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).
        /// </summary>
        public readonly string IscsiInterface;
        /// <summary>
        /// iSCSI Target Lun number.
        /// </summary>
        public readonly int Lun;
        /// <summary>
        /// iSCSI Target Portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
        /// </summary>
        public readonly ImmutableArray<string> Portals;
        /// <summary>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// CHAP Secret for iSCSI target and initiator authentication
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1.ScaledObjectSpecJobTargetRefTemplateSpecVolumesIscsiSecretRef SecretRef;
        /// <summary>
        /// iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
        /// </summary>
        public readonly string TargetPortal;

        [OutputConstructor]
        private ScaledObjectSpecJobTargetRefTemplateSpecVolumesIscsi(
            bool chapAuthDiscovery,

            bool chapAuthSession,

            string fsType,

            string initiatorName,

            string iqn,

            string iscsiInterface,

            int lun,

            ImmutableArray<string> portals,

            bool readOnly,

            Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1.ScaledObjectSpecJobTargetRefTemplateSpecVolumesIscsiSecretRef secretRef,

            string targetPortal)
        {
            ChapAuthDiscovery = chapAuthDiscovery;
            ChapAuthSession = chapAuthSession;
            FsType = fsType;
            InitiatorName = initiatorName;
            Iqn = iqn;
            IscsiInterface = iscsiInterface;
            Lun = lun;
            Portals = portals;
            ReadOnly = readOnly;
            SecretRef = secretRef;
            TargetPortal = targetPortal;
        }
    }
}
