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
    public sealed class SyncIdentityProviderSpecIdentityProvidersRequestHeader
    {
        /// <summary>
        /// ca is a required reference to a config map by name containing the PEM-encoded CA bundle. It is used as a trust anchor to validate the TLS certificate presented by the remote server. Specifically, it allows verification of incoming requests to prevent header spoofing. The key "ca.crt" is used to locate the data. If the config map or expected key is not found, the identity provider is not honored. If the specified ca data is not valid, the identity provider is not honored. The namespace for this config map is openshift-config.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersRequestHeaderCa Ca;
        /// <summary>
        /// challengeURL is a URL to redirect unauthenticated /authorize requests to Unauthenticated requests from OAuth clients which expect WWW-Authenticate challenges will be redirected here. ${url} is replaced with the current URL, escaped to be safe in a query parameter   https://www.example.com/sso-login?then=${url} ${query} is replaced with the current query string   https://www.example.com/auth-proxy/oauth/authorize?${query} Required when challenge is set to true.
        /// </summary>
        public readonly string ChallengeURL;
        /// <summary>
        /// clientCommonNames is an optional list of common names to require a match from. If empty, any client certificate validated against the clientCA bundle is considered authoritative.
        /// </summary>
        public readonly ImmutableArray<string> ClientCommonNames;
        /// <summary>
        /// emailHeaders is the set of headers to check for the email address
        /// </summary>
        public readonly ImmutableArray<string> EmailHeaders;
        /// <summary>
        /// headers is the set of headers to check for identity information
        /// </summary>
        public readonly ImmutableArray<string> Headers;
        /// <summary>
        /// loginURL is a URL to redirect unauthenticated /authorize requests to Unauthenticated requests from OAuth clients which expect interactive logins will be redirected here ${url} is replaced with the current URL, escaped to be safe in a query parameter   https://www.example.com/sso-login?then=${url} ${query} is replaced with the current query string   https://www.example.com/auth-proxy/oauth/authorize?${query} Required when login is set to true.
        /// </summary>
        public readonly string LoginURL;
        /// <summary>
        /// nameHeaders is the set of headers to check for the display name
        /// </summary>
        public readonly ImmutableArray<string> NameHeaders;
        /// <summary>
        /// preferredUsernameHeaders is the set of headers to check for the preferred username
        /// </summary>
        public readonly ImmutableArray<string> PreferredUsernameHeaders;

        [OutputConstructor]
        private SyncIdentityProviderSpecIdentityProvidersRequestHeader(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersRequestHeaderCa ca,

            string challengeURL,

            ImmutableArray<string> clientCommonNames,

            ImmutableArray<string> emailHeaders,

            ImmutableArray<string> headers,

            string loginURL,

            ImmutableArray<string> nameHeaders,

            ImmutableArray<string> preferredUsernameHeaders)
        {
            Ca = ca;
            ChallengeURL = challengeURL;
            ClientCommonNames = clientCommonNames;
            EmailHeaders = emailHeaders;
            Headers = headers;
            LoginURL = loginURL;
            NameHeaders = nameHeaders;
            PreferredUsernameHeaders = preferredUsernameHeaders;
        }
    }
}
