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
    public sealed class TidbClusterSpecTikvConfigReadpoolStorage
    {
        public readonly int High-concurrency;
        public readonly int Low-concurrency;
        public readonly int Max-tasks-per-worker-high;
        public readonly int Max-tasks-per-worker-low;
        public readonly int Max-tasks-per-worker-normal;
        public readonly int Normal-concurrency;
        public readonly string Stack-size;
        public readonly bool Use-unified-pool;

        [OutputConstructor]
        private TidbClusterSpecTikvConfigReadpoolStorage(
            int high-concurrency,

            int low-concurrency,

            int max-tasks-per-worker-high,

            int max-tasks-per-worker-low,

            int max-tasks-per-worker-normal,

            int normal-concurrency,

            string stack-size,

            bool use-unified-pool)
        {
            High-concurrency = high-concurrency;
            Low-concurrency = low-concurrency;
            Max-tasks-per-worker-high = max-tasks-per-worker-high;
            Max-tasks-per-worker-low = max-tasks-per-worker-low;
            Max-tasks-per-worker-normal = max-tasks-per-worker-normal;
            Normal-concurrency = normal-concurrency;
            Stack-size = stack-size;
            Use-unified-pool = use-unified-pool;
        }
    }
}