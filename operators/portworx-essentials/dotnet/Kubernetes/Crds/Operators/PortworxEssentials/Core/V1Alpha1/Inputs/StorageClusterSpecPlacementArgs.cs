// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1
{

    /// <summary>
    /// Describes placement configuration for the storage cluster pods.
    /// </summary>
    public class StorageClusterSpecPlacementArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the storage cluster pods. This is exactly the same object as Kubernetes node affinity for pods.
        /// </summary>
        [Input("nodeAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterSpecPlacementNodeAffinityArgs>? NodeAffinity { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterSpecPlacementTolerationsArgs>? _tolerations;

        /// <summary>
        /// Tolerations for all the pods deployed by the StorageCluster controller. The pod with this toleration attached will tolerate any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterSpecPlacementTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterSpecPlacementTolerationsArgs>());
            set => _tolerations = value;
        }

        public StorageClusterSpecPlacementArgs()
        {
        }
    }
}