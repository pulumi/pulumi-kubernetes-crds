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
    public sealed class ScaledObjectSpecJobTargetRefTemplateSpecVolumesFlexVolume
    {
        /// <summary>
        /// Driver is the name of the driver to use for this volume.
        /// </summary>
        public readonly string Driver;
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// Optional: Extra command options if any.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Options;
        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// Optional: SecretRef is reference to the secret object containing sensitive information to pass to the plugin scripts. This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1.ScaledObjectSpecJobTargetRefTemplateSpecVolumesFlexVolumeSecretRef SecretRef;

        [OutputConstructor]
        private ScaledObjectSpecJobTargetRefTemplateSpecVolumesFlexVolume(
            string driver,

            string fsType,

            ImmutableDictionary<string, string> options,

            bool readOnly,

            Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1.ScaledObjectSpecJobTargetRefTemplateSpecVolumesFlexVolumeSecretRef secretRef)
        {
            Driver = driver;
            FsType = fsType;
            Options = options;
            ReadOnly = readOnly;
            SecretRef = secretRef;
        }
    }
}
