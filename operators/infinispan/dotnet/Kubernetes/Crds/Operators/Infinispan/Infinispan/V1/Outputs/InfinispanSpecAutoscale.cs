// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Infinispan.V1
{

    [OutputType]
    public sealed class InfinispanSpecAutoscale
    {
        public readonly bool Disabled;
        public readonly int MaxMemUsagePercent;
        public readonly int MaxReplicas;
        public readonly int MinMemUsagePercent;
        public readonly int MinReplicas;

        [OutputConstructor]
        private InfinispanSpecAutoscale(
            bool disabled,

            int maxMemUsagePercent,

            int maxReplicas,

            int minMemUsagePercent,

            int minReplicas)
        {
            Disabled = disabled;
            MaxMemUsagePercent = maxMemUsagePercent;
            MaxReplicas = maxReplicas;
            MinMemUsagePercent = minMemUsagePercent;
            MinReplicas = minReplicas;
        }
    }
}
