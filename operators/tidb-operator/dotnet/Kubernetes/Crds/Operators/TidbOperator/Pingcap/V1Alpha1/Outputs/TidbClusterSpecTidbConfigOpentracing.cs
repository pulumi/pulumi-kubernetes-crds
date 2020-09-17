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
    public sealed class TidbClusterSpecTidbConfigOpentracing
    {
        public readonly bool Enable;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigOpentracingReporter Reporter;
        public readonly bool Rpc-metrics;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigOpentracingSampler Sampler;

        [OutputConstructor]
        private TidbClusterSpecTidbConfigOpentracing(
            bool enable,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigOpentracingReporter reporter,

            bool rpc-metrics,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfigOpentracingSampler sampler)
        {
            Enable = enable;
            Reporter = reporter;
            Rpc-metrics = rpc-metrics;
            Sampler = sampler;
        }
    }
}
