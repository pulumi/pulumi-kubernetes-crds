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
    public sealed class StorageClusterSpecPlacementNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecPlacementNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference;
        public readonly int Weight;

        [OutputConstructor]
        private StorageClusterSpecPlacementNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution(
            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecPlacementNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference preference,

            int weight)
        {
            Preference = preference;
            Weight = weight;
        }
    }
}
