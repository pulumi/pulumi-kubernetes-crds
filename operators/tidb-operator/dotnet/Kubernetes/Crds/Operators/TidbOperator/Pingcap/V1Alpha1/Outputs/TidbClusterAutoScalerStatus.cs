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
    public sealed class TidbClusterAutoScalerStatus
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterAutoScalerStatusTidb Tidb;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterAutoScalerStatusTikv Tikv;

        [OutputConstructor]
        private TidbClusterAutoScalerStatus(
            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterAutoScalerStatusTidb tidb,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterAutoScalerStatusTikv tikv)
        {
            Tidb = tidb;
            Tikv = tikv;
        }
    }
}
