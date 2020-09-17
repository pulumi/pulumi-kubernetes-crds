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
    public sealed class SyncIdentityProviderSpec
    {
        /// <summary>
        /// ClusterDeploymentRefs is the list of LocalObjectReference indicating which clusters the SyncSet applies to in the SyncSet's namespace.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecClusterDeploymentRefs> ClusterDeploymentRefs;
        /// <summary>
        /// IdentityProviders is an ordered list of ways for a user to identify themselves
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProviders> IdentityProviders;

        [OutputConstructor]
        private SyncIdentityProviderSpec(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecClusterDeploymentRefs> clusterDeploymentRefs,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProviders> identityProviders)
        {
            ClusterDeploymentRefs = clusterDeploymentRefs;
            IdentityProviders = identityProviders;
        }
    }
}