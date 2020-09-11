// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class StorageClusterSpecPlacement
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the storage cluster pods. This is exactly the same object as Kubernetes node affinity for pods.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecPlacementNodeAffinity NodeAffinity;
        /// <summary>
        /// Tolerations for all the pods deployed by the StorageCluster controller. The pod with this toleration attached will tolerate any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecPlacementTolerations> Tolerations;

        [OutputConstructor]
        private StorageClusterSpecPlacement(
            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecPlacementNodeAffinity nodeAffinity,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecPlacementTolerations> tolerations)
        {
            NodeAffinity = nodeAffinity;
            Tolerations = tolerations;
        }
    }
}
