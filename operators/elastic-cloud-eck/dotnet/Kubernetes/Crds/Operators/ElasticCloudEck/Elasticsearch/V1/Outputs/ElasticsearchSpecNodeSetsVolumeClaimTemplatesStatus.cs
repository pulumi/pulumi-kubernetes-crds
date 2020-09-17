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
    public sealed class ElasticsearchSpecNodeSetsVolumeClaimTemplatesStatus
    {
        /// <summary>
        /// AccessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
        /// </summary>
        public readonly ImmutableArray<string> AccessModes;
        /// <summary>
        /// Represents the actual resources of the underlying volume.
        /// </summary>
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecNodeSetsVolumeClaimTemplatesStatusCapacity> Capacity;
        /// <summary>
        /// Current Condition of persistent volume claim. If underlying persistent volume is being resized then the Condition will be set to 'ResizeStarted'.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecNodeSetsVolumeClaimTemplatesStatusConditions> Conditions;
        /// <summary>
        /// Phase represents the current phase of PersistentVolumeClaim.
        /// </summary>
        public readonly string Phase;

        [OutputConstructor]
        private ElasticsearchSpecNodeSetsVolumeClaimTemplatesStatus(
            ImmutableArray<string> accessModes,

            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecNodeSetsVolumeClaimTemplatesStatusCapacity> capacity,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecNodeSetsVolumeClaimTemplatesStatusConditions> conditions,

            string phase)
        {
            AccessModes = accessModes;
            Capacity = capacity;
            Conditions = conditions;
            Phase = phase;
        }
    }
}
