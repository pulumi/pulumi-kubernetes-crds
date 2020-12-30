// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1
{

    [OutputType]
    public sealed class MigAnalyticStatusAnalytics
    {
        public readonly int Excludedk8sResourceTotal;
        public readonly int ImageCount;
        public readonly string ImageSizeTotal;
        public readonly int Incompatiblek8sResourceTotal;
        public readonly int K8sResourceTotal;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1.MigAnalyticStatusAnalyticsNamespaces> Namespaces;
        public readonly int PercentComplete;
        public readonly string Plan;
        public readonly string PvCapacity;
        public readonly int PvCount;

        [OutputConstructor]
        private MigAnalyticStatusAnalytics(
            int excludedk8sResourceTotal,

            int imageCount,

            string imageSizeTotal,

            int incompatiblek8sResourceTotal,

            int k8sResourceTotal,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1.MigAnalyticStatusAnalyticsNamespaces> namespaces,

            int percentComplete,

            string plan,

            string pvCapacity,

            int pvCount)
        {
            Excludedk8sResourceTotal = excludedk8sResourceTotal;
            ImageCount = imageCount;
            ImageSizeTotal = imageSizeTotal;
            Incompatiblek8sResourceTotal = incompatiblek8sResourceTotal;
            K8sResourceTotal = k8sResourceTotal;
            Namespaces = namespaces;
            PercentComplete = percentComplete;
            Plan = plan;
            PvCapacity = pvCapacity;
            PvCount = pvCount;
        }
    }
}
