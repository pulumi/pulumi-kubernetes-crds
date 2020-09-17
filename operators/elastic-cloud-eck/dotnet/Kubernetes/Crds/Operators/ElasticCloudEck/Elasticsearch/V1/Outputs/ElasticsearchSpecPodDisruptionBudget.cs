// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1
{

    [OutputType]
    public sealed class ElasticsearchSpecPodDisruptionBudget
    {
        /// <summary>
        /// ObjectMeta is the metadata of the PDB. The name and namespace provided here are managed by ECK and will be ignored.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Metadata;
        /// <summary>
        /// Spec is the specification of the PDB.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecPodDisruptionBudgetSpec Spec;

        [OutputConstructor]
        private ElasticsearchSpecPodDisruptionBudget(
            ImmutableDictionary<string, object> metadata,

            Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecPodDisruptionBudgetSpec spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}