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
    public sealed class TidbClusterSpecTikvConfigReadpoolUnified
    {
        public readonly int Max-tasks-per-worker;
        public readonly int Max-thread-count;
        public readonly int Min-thread-count;
        public readonly string Stack-size;

        [OutputConstructor]
        private TidbClusterSpecTikvConfigReadpoolUnified(
            int max-tasks-per-worker,

            int max-thread-count,

            int min-thread-count,

            string stack-size)
        {
            Max-tasks-per-worker = max-tasks-per-worker;
            Max-thread-count = max-thread-count;
            Min-thread-count = min-thread-count;
            Stack-size = stack-size;
        }
    }
}