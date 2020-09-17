// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// GitHub represents the GitHub provider
    /// </summary>
    public class GroupSyncSpecProvidersGithubArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CaSecret is a reference to a secret containing a CA certificate to communicate to the GitHub server
        /// </summary>
        [Input("caSecret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGithubCaSecretArgs>? CaSecret { get; set; }

        /// <summary>
        /// CredentialsSecret is a reference to a secret containing authentication details for the GitHub server
        /// </summary>
        [Input("credentialsSecret", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersGithubCredentialsSecretArgs> CredentialsSecret { get; set; } = null!;

        /// <summary>
        /// Insecure specifies whether to allow for unverified certificates to be used when communicating to GitHab
        /// </summary>
        [Input("insecure")]
        public Input<bool>? Insecure { get; set; }

        /// <summary>
        /// Organization represents the location to source teams to synchronize
        /// </summary>
        [Input("organization")]
        public Input<string>? Organization { get; set; }

        [Input("teams")]
        private InputList<string>? _teams;

        /// <summary>
        /// Teams represents a filtered list of teams to synchronize
        /// </summary>
        public InputList<string> Teams
        {
            get => _teams ?? (_teams = new InputList<string>());
            set => _teams = value;
        }

        /// <summary>
        /// URL is the location of the GitHub server
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public GroupSyncSpecProvidersGithubArgs()
        {
        }
    }
}
