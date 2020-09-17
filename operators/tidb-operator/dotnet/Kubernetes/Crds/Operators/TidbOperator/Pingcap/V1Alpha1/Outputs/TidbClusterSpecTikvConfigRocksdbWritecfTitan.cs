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
    public sealed class TidbClusterSpecTikvConfigRocksdbWritecfTitan
    {
        public readonly string Blob-cache-size;
        public readonly string Blob-file-compression;
        public readonly string Blob-run-mode;
        public readonly double Discardable-ratio;
        public readonly bool Gc-merge-rewrite;
        public readonly bool Level_merge;
        public readonly string Max-gc-batch-size;
        public readonly string Merge-small-file-threshold;
        public readonly string Min-blob-size;
        public readonly string Min-gc-batch-size;
        public readonly double Sample-ratio;

        [OutputConstructor]
        private TidbClusterSpecTikvConfigRocksdbWritecfTitan(
            string blob-cache-size,

            string blob-file-compression,

            string blob-run-mode,

            double discardable-ratio,

            bool gc-merge-rewrite,

            bool level_merge,

            string max-gc-batch-size,

            string merge-small-file-threshold,

            string min-blob-size,

            string min-gc-batch-size,

            double sample-ratio)
        {
            Blob-cache-size = blob-cache-size;
            Blob-file-compression = blob-file-compression;
            Blob-run-mode = blob-run-mode;
            Discardable-ratio = discardable-ratio;
            Gc-merge-rewrite = gc-merge-rewrite;
            Level_merge = level_merge;
            Max-gc-batch-size = max-gc-batch-size;
            Merge-small-file-threshold = merge-small-file-threshold;
            Min-blob-size = min-blob-size;
            Min-gc-batch-size = min-gc-batch-size;
            Sample-ratio = sample-ratio;
        }
    }
}
