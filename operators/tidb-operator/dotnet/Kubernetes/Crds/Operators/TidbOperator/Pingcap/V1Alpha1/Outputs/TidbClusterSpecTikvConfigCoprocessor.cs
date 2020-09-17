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
    public sealed class TidbClusterSpecTikvConfigCoprocessor
    {
        public readonly int Batch-split-limit;
        public readonly int Region-max-keys;
        public readonly string Region-max-size;
        public readonly int Region-split-keys;
        public readonly string Region-split-size;
        public readonly bool Split-region-on-table;

        [OutputConstructor]
        private TidbClusterSpecTikvConfigCoprocessor(
            int batch-split-limit,

            int region-max-keys,

            string region-max-size,

            int region-split-keys,

            string region-split-size,

            bool split-region-on-table)
        {
            Batch-split-limit = batch-split-limit;
            Region-max-keys = region-max-keys;
            Region-max-size = region-max-size;
            Region-split-keys = region-split-keys;
            Region-split-size = region-split-size;
            Split-region-on-table = split-region-on-table;
        }
    }
}