// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterClaimSpec
    {
        /// <summary>
        /// ClusterPoolName is the name of the cluster pool from which to claim a cluster.
        /// </summary>
        public readonly string ClusterPoolName;
        /// <summary>
        /// Lifetime is the maximum lifetime of the claim after it is assigned a cluster. If the claim still exists when the lifetime has elapsed, the claim will be deleted by Hive.
        /// </summary>
        public readonly string Lifetime;
        /// <summary>
        /// Namespace is the namespace containing the ClusterDeployment (name will match the namespace) of the claimed cluster. This field will be set as soon as a suitable cluster can be found, however that cluster may still be resuming and not yet ready for use. Wait for the ClusterRunning condition to be true to avoid this issue.
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Subjects hold references to which to authorize access to the claimed cluster.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterClaimSpecSubjects> Subjects;

        [OutputConstructor]
        private ClusterClaimSpec(
            string clusterPoolName,

            string lifetime,

            string @namespace,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterClaimSpecSubjects> subjects)
        {
            ClusterPoolName = clusterPoolName;
            Lifetime = lifetime;
            Namespace = @namespace;
            Subjects = subjects;
        }
    }
}
