// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1
{

    [OutputType]
    public sealed class LimitSpec
    {
        public readonly int MaxValue;
        public readonly Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.LimitSpecMetricRef MetricRef;
        public readonly string Period;

        [OutputConstructor]
        private LimitSpec(
            int maxValue,

            Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1.LimitSpecMetricRef metricRef,

            string period)
        {
            MaxValue = maxValue;
            MetricRef = metricRef;
            Period = period;
        }
    }
}