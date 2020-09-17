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
    public sealed class DatadogAgentSpecClusterAgentConfigVolumesAwsElasticBlockStore
    {
        /// <summary>
        /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore TODO: how do we prevent errors in the filesystem from compromising the machine
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty).
        /// </summary>
        public readonly int Partition;
        /// <summary>
        /// Specify "true" to force and set the ReadOnly property in VolumeMounts to "true". If omitted, the default is "false". More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        public readonly string VolumeID;

        [OutputConstructor]
        private DatadogAgentSpecClusterAgentConfigVolumesAwsElasticBlockStore(
            string fsType,

            int partition,

            bool readOnly,

            string volumeID)
        {
            FsType = fsType;
            Partition = partition;
            ReadOnly = readOnly;
            VolumeID = volumeID;
        }
    }
}
