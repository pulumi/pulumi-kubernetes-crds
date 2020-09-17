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
    /// CredentialsSecret is a reference to a secret containing authentication details for the GitLab server
    /// </summary>
    public class GroupSyncSpecProvidersGitlabCredentialsSecretArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key represents the specific key to reference from the secret
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Name represents the name of the secret
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Namespace represents the namespace containing the secret
        /// </summary>
        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        public GroupSyncSpecProvidersGitlabCredentialsSecretArgs()
        {
        }
    }
}
