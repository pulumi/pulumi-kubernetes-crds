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
    public sealed class JaegerSpecVolumesCsi
    {
        public readonly string Driver;
        public readonly string FsType;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecVolumesCsiNodePublishSecretRef NodePublishSecretRef;
        public readonly bool ReadOnly;
        public readonly ImmutableDictionary<string, string> VolumeAttributes;

        [OutputConstructor]
        private JaegerSpecVolumesCsi(
            string driver,

            string fsType,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecVolumesCsiNodePublishSecretRef nodePublishSecretRef,

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
