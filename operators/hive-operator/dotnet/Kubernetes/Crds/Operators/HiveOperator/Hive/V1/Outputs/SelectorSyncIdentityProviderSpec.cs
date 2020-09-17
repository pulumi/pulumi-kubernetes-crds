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
    public sealed class SelectorSyncIdentityProviderSpec
    {
        /// <summary>
        /// ClusterDeploymentSelector is a LabelSelector indicating which clusters the SelectorIdentityProvider applies to in any namespace.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SelectorSyncIdentityProviderSpecClusterDeploymentSelector ClusterDeploymentSelector;
        /// <summary>
        /// IdentityProviders is an ordered list of ways for a user to identify themselves
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SelectorSyncIdentityProviderSpecIdentityProviders> IdentityProviders;

        [OutputConstructor]
        private SelectorSyncIdentityProviderSpec(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SelectorSyncIdentityProviderSpecClusterDeploymentSelector clusterDeploymentSelector,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SelectorSyncIdentityProviderSpecIdentityProviders> identityProviders)
        {
            ClusterDeploymentSelector = clusterDeploymentSelector;
            IdentityProviders = identityProviders;
        }
    }
}
