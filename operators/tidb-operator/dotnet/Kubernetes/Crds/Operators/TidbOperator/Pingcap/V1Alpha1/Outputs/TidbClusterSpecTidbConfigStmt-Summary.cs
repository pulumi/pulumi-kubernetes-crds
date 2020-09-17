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
    public sealed class TidbClusterSpecTidbConfigStmt-Summary
    {
        public readonly bool Enable;
        public readonly bool Enable-internal-query;
        public readonly int History-size;
        public readonly int Max-sql-length;
        public readonly int Max-stmt-count;
        public readonly int Refresh-interval;

        [OutputConstructor]
        private TidbClusterSpecTidbConfigStmt-Summary(
            bool enable,

            bool enable-internal-query,

            int history-size,

            int max-sql-length,

            int max-stmt-count,

            int refresh-interval)
        {
            Enable = enable;
            Enable-internal-query = enable-internal-query;
            History-size = history-size;
            Max-sql-length = max-sql-length;
            Max-stmt-count = max-stmt-count;
            Refresh-interval = refresh-interval;
        }
    }
}