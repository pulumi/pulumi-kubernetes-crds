// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecAgentConfigVolumesCsi
    {
        /// <summary>
        /// Driver is the name of the CSI driver that handles this volume. Consult with your admin for the correct name as registered in the cluster.
        /// </summary>
        public readonly string Driver;
        /// <summary>
        /// Filesystem type to mount. Ex. "ext4", "xfs", "ntfs". If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply.
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// NodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and  may be empty if no secret is required. If the secret object contains more than one secret, all secret references are passed.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesCsiNodePublishSecretRef NodePublishSecretRef;
        /// <summary>
        /// Specifies a read-only configuration for the volume. Defaults to false (read/write).
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// VolumeAttributes stores driver-specific properties that are passed to the CSI driver. Consult your driver's documentation for supported values.
        /// </summary>
        public readonly ImmutableDictionary<string, string> VolumeAttributes;

        [OutputConstructor]
        private DatadogAgentSpecAgentConfigVolumesCsi(
            string driver,

            string fsType,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesCsiNodePublishSecretRef nodePublishSecretRef,

            bool readOnly,

            ImmutableDictionary<string, string> volumeAttributes)
        {
            Driver = driver;
            FsType = fsType;
            NodePublishSecretRef = nodePublishSecretRef;
            ReadOnly = readOnly;
            VolumeAttributes = volumeAttributes;
        }
    }
}
