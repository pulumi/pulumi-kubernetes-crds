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
    public sealed class StorageClusterSpecNodesSelectorLabelSelector
    {
        /// <summary>
        /// It is a list of label selector requirements. The requirements are ANDed.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.StorageClusterSpecNodesSelectorLabelSelectorMatchExpressions> MatchExpressions;
        /// <summary>
        /// It is a map of key-value pairs. A single key-value in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        /// </summary>
        public readonly ImmutableDictionary<string, object> MatchLabels;

        [OutputConstructor]
        private StorageClusterSpecNodesSelectorLabelSelector(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.StorageClusterSpecNodesSelectorLabelSelectorMatchExpressions> matchExpressions,

            ImmutableDictionary<string, object> matchLabels)
        {
            MatchExpressions = matchExpressions;
            MatchLabels = matchLabels;
        }
    }
}
