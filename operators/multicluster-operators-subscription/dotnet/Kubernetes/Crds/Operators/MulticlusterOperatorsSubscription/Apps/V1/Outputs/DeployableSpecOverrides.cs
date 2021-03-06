// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1
{

    [OutputType]
    public sealed class DeployableSpecOverrides
    {
        public readonly string ClusterName;
        public readonly ImmutableArray<ImmutableDictionary<string, object>> ClusterOverrides;

        [OutputConstructor]
        private DeployableSpecOverrides(
            string clusterName,

            ImmutableArray<ImmutableDictionary<string, object>> clusterOverrides)
        {
            ClusterName = clusterName;
            ClusterOverrides = clusterOverrides;
        }
    }
}
