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
    public sealed class TidbClusterSpecTikvConfigRocksdbTitan
    {
        public readonly string Dirname;
        public readonly bool Disable-gc;
        public readonly bool Enabled;
        public readonly int Max-background-gc;
        public readonly string Purge-obsolete-files-period;

        [OutputConstructor]
        private TidbClusterSpecTikvConfigRocksdbTitan(
            string dirname,

            bool disable-gc,

            bool enabled,

            int max-background-gc,

            string purge-obsolete-files-period)
        {
            Dirname = dirname;
            Disable-gc = disable-gc;
            Enabled = enabled;
            Max-background-gc = max-background-gc;
            Purge-obsolete-files-period = purge-obsolete-files-period;
        }
    }
}