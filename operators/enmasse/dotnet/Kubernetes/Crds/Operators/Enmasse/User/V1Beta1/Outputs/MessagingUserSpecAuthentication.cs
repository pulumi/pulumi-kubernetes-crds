// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.User.V1Beta1
{

    [OutputType]
    public sealed class MessagingUserSpecAuthentication
    {
        /// <summary>
        /// Federated user id for the 'federated' authentication type.
        /// </summary>
        public readonly string FederatedUserid;
        /// <summary>
        /// Federated user name for the 'federated' authentication type.
        /// </summary>
        public readonly string FederatedUsername;
        /// <summary>
        /// Base64-encoded password for the 'password' authentication type.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// Federated identity provider for the 'federated' authentication type.
        /// </summary>
        public readonly string Provider;
        /// <summary>
        /// The type of authentication.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private MessagingUserSpecAuthentication(
            string federatedUserid,

            string federatedUsername,

            string password,

            string provider,

            string type)
        {
            FederatedUserid = federatedUserid;
            FederatedUsername = federatedUsername;
            Password = password;
            Provider = provider;
            Type = type;
        }
    }
}
