// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaMirrorMaker2SpecTemplatePodDisruptionBudget
    {
        /// <summary>
        /// Maximum number of unavailable pods to allow automatic Pod eviction. A Pod eviction is allowed when the `maxUnavailable` number of pods or fewer are unavailable after the eviction. Setting this value to 0 prevents all voluntary evictions, so the pods must be evicted manually. Defaults to 1.
        /// </summary>
        public readonly int MaxUnavailable;
        /// <summary>
        /// Metadata to apply to the `PodDistruptionBugetTemplate` resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodDisruptionBudgetMetadata Metadata;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecTemplatePodDisruptionBudget(
            int maxUnavailable,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecTemplatePodDisruptionBudgetMetadata metadata)
        {
            MaxUnavailable = maxUnavailable;
            Metadata = metadata;
        }
    }
}
