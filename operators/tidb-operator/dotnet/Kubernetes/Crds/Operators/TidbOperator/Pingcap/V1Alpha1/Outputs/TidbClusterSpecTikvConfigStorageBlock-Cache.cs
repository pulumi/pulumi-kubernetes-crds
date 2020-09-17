// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class TidbClusterSpecTikvConfigStorageBlock-Cache
    {
        public readonly string Capacity;
        public readonly double High-pri-pool-ratio;
        public readonly string Memory-allocator;
        public readonly int Num-shard-bits;
        public readonly bool Shared;
        public readonly bool Strict-capacity-limit;

        [OutputConstructor]
        private TidbClusterSpecTikvConfigStorageBlock-Cache(
            string capacity,

            double high-pri-pool-ratio,

            string memory-allocator,

            int num-shard-bits,

            bool shared,

            bool strict-capacity-limit)
        {
            Capacity = capacity;
            High-pri-pool-ratio = high-pri-pool-ratio;
            Memory-allocator = memory-allocator;
            Num-shard-bits = num-shard-bits;
            Shared = shared;
            Strict-capacity-limit = strict-capacity-limit;
        }
    }
}
