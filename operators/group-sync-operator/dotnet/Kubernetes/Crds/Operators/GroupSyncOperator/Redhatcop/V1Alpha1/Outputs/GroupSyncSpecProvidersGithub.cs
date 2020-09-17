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
    public sealed class GroupSyncSpecProvidersGithub
    {
        /// <summary>
        /// CaSecret is a reference to a secret containing a CA certificate to communicate to the GitHub server
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGithubCaSecret CaSecret;
        /// <summary>
        /// CredentialsSecret is a reference to a secret containing authentication details for the GitHub server
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGithubCredentialsSecret CredentialsSecret;
        /// <summary>
        /// Insecure specifies whether to allow for unverified certificates to be used when communicating to GitHab
        /// </summary>
        public readonly bool Insecure;
        /// <summary>
        /// Organization represents the location to source teams to synchronize
        /// </summary>
        public readonly string Organization;
        /// <summary>
        /// Teams represents a filtered list of teams to synchronize
        /// </summary>
        public readonly ImmutableArray<string> Teams;
        /// <summary>
        /// URL is the location of the GitHub server
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private GroupSyncSpecProvidersGithub(
            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGithubCaSecret caSecret,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGithubCredentialsSecret credentialsSecret,

            bool insecure,

            string organization,

            ImmutableArray<string> teams,

            string url)
        {
            CaSecret = caSecret;
            CredentialsSecret = credentialsSecret;
            Insecure = insecure;
            Organization = organization;
            Teams = teams;
            Url = url;
        }
    }
}
