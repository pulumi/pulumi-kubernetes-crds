// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    [OutputType]
    public sealed class StorageClusterSpecPlacementNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
    {
        public readonly string Key;
        public readonly string Operator;
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private StorageClusterSpecPlacementNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields(
            string key,

            string @operator,

            ImmutableArray<string> values)
        {
            Key = key;
            Operator = @operator;
            Values = values;
        }
    }
}
