// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Maistra.V2
{

    [OutputType]
    public sealed class ServiceMeshControlPlaneSpecRuntimeComponentsPodAffinityPodAntiAffinityPreferredDuringScheduling
    {
        public readonly string Key;
        public readonly string Operator;
        public readonly string TopologyKey;
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecRuntimeComponentsPodAffinityPodAntiAffinityPreferredDuringScheduling(
            string key,

            string @operator,

            string topologyKey,

            ImmutableArray<string> values)
        {
            Key = key;
            Operator = @operator;
            TopologyKey = topologyKey;
            Values = values;
        }
    }
}
