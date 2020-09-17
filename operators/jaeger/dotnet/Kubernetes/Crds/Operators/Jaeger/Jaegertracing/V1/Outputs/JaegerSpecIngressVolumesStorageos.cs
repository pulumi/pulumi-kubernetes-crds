// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1
{

    [OutputType]
    public sealed class JaegerSpecIngressVolumesStorageos
    {
        public readonly string FsType;
        public readonly bool ReadOnly;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecIngressVolumesStorageosSecretRef SecretRef;
        public readonly string VolumeName;
        public readonly string VolumeNamespace;

        [OutputConstructor]
        private JaegerSpecIngressVolumesStorageos(
            string fsType,

            bool readOnly,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecIngressVolumesStorageosSecretRef secretRef,

            string volumeName,

            string volumeNamespace)
        {
            FsType = fsType;
            ReadOnly = readOnly;
            SecretRef = secretRef;
            VolumeName = volumeName;
            VolumeNamespace = volumeNamespace;
        }
    }
}
