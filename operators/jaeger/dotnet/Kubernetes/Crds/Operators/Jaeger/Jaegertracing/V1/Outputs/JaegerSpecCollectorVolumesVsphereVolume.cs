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
    public sealed class JaegerSpecCollectorVolumesVsphereVolume
    {
        public readonly string FsType;
        public readonly string StoragePolicyID;
        public readonly string StoragePolicyName;
        public readonly string VolumePath;

        [OutputConstructor]
        private JaegerSpecCollectorVolumesVsphereVolume(
            string fsType,

            string storagePolicyID,

            string storagePolicyName,

            string volumePath)
        {
            FsType = fsType;
            StoragePolicyID = storagePolicyID;
            StoragePolicyName = storagePolicyName;
            VolumePath = volumePath;
        }
    }
}
