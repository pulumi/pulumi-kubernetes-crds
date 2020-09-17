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
    public sealed class JaegerSpecStorageDependenciesVolumesGcePersistentDisk
    {
        public readonly string FsType;
        public readonly int Partition;
        public readonly string PdName;
        public readonly bool ReadOnly;

        [OutputConstructor]
        private JaegerSpecStorageDependenciesVolumesGcePersistentDisk(
            string fsType,

            int partition,

            string pdName,

            bool readOnly)
        {
            FsType = fsType;
            Partition = partition;
            PdName = pdName;
            ReadOnly = readOnly;
        }
    }
}
