// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class GroupSyncSpecProviders
    {
        /// <summary>
        /// Azure represents the Azure provider
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersAzure Azure;
        /// <summary>
        /// GitHub represents the GitHub provider
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGithub Github;
        /// <summary>
        /// GitLab represents the GitLab provider
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGitlab Gitlab;
        /// <summary>
        /// Keycloak represents the Keycloak provider
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersKeycloak Keycloak;
        /// <summary>
        /// Ldap represents the LDAP provider
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersLdap Ldap;
        /// <summary>
        /// Name represents the name of the provider
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GroupSyncSpecProviders(
            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersAzure azure,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGithub github,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGitlab gitlab,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersKeycloak keycloak,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersLdap ldap,

            string name)
        {
            Azure = azure;
            Github = github;
            Gitlab = gitlab;
            Keycloak = keycloak;
            Ldap = ldap;
            Name = name;
        }
    }
}
