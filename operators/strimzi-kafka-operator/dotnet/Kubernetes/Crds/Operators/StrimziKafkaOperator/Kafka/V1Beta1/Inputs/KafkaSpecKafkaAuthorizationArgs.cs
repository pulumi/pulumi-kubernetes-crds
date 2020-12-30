// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    /// <summary>
    /// Authorization configuration for Kafka brokers.
    /// </summary>
    public class KafkaSpecKafkaAuthorizationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines whether a Kafka client should be allowed or denied by default when the authorizer fails to query the Open Policy Agent, for example, when it is temporarily unavailable). Defaults to `false` - all actions will be denied.
        /// </summary>
        [Input("allowOnError")]
        public Input<bool>? AllowOnError { get; set; }

        /// <summary>
        /// OAuth Client ID which the Kafka client can use to authenticate against the OAuth server and use the token endpoint URI.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// Whether authorization decision should be delegated to the 'Simple' authorizer if DENIED by Keycloak Authorization Services policies. Default value is `false`.
        /// </summary>
        [Input("delegateToKafkaAcls")]
        public Input<bool>? DelegateToKafkaAcls { get; set; }

        /// <summary>
        /// Enable or disable TLS hostname verification. Default value is `false`.
        /// </summary>
        [Input("disableTlsHostnameVerification")]
        public Input<bool>? DisableTlsHostnameVerification { get; set; }

        /// <summary>
        /// The expiration of the records kept in the local cache to avoid querying the Open Policy Agent for every request. Defines how often the cached authorization decisions are reloaded from the Open Policy Agent server. In milliseconds. Defaults to `3600000`.
        /// </summary>
        [Input("expireAfterMs")]
        public Input<int>? ExpireAfterMs { get; set; }

        /// <summary>
        /// The time between two consecutive grants refresh runs in seconds. The default value is 60.
        /// </summary>
        [Input("grantsRefreshPeriodSeconds")]
        public Input<int>? GrantsRefreshPeriodSeconds { get; set; }

        /// <summary>
        /// The number of threads to use to refresh grants for active sessions. The more threads, the more parallelism, so the sooner the job completes. However, using more threads places a heavier load on the authorization server. The default value is 5.
        /// </summary>
        [Input("grantsRefreshPoolSize")]
        public Input<int>? GrantsRefreshPoolSize { get; set; }

        /// <summary>
        /// Initial capacity of the local cache used by the authorizer to avoid querying the Open Policy Agent for every request Defaults to `5000`.
        /// </summary>
        [Input("initialCacheCapacity")]
        public Input<int>? InitialCacheCapacity { get; set; }

        /// <summary>
        /// Maximum capacity of the local cache used by the authorizer to avoid querying the Open Policy Agent for every request. Defaults to `50000`.
        /// </summary>
        [Input("maximumCacheSize")]
        public Input<int>? MaximumCacheSize { get; set; }

        [Input("superUsers")]
        private InputList<string>? _superUsers;

        /// <summary>
        /// List of super users. Should contain list of user principals which should get unlimited access rights.
        /// </summary>
        public InputList<string> SuperUsers
        {
            get => _superUsers ?? (_superUsers = new InputList<string>());
            set => _superUsers = value;
        }

        [Input("tlsTrustedCertificates")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaAuthorizationTlsTrustedCertificatesArgs>? _tlsTrustedCertificates;

        /// <summary>
        /// Trusted certificates for TLS connection to the OAuth server.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaAuthorizationTlsTrustedCertificatesArgs> TlsTrustedCertificates
        {
            get => _tlsTrustedCertificates ?? (_tlsTrustedCertificates = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaAuthorizationTlsTrustedCertificatesArgs>());
            set => _tlsTrustedCertificates = value;
        }

        /// <summary>
        /// Authorization server token endpoint URI.
        /// </summary>
        [Input("tokenEndpointUri")]
        public Input<string>? TokenEndpointUri { get; set; }

        /// <summary>
        /// Authorization type. Currently, the supported types are `simple`, `keycloak`, and `opa`. `simple` authorization type uses Kafka's `kafka.security.authorizer.AclAuthorizer` class for authorization. `keycloak` authorization type uses Keycloak Authorization Services for authorization. `opa` authorization type uses Open Policy Agent based authorization.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The URL used to connect to the Open Policy Agent server. The URL has to include the policy which will be queried by the authorizer. This option is required.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public KafkaSpecKafkaAuthorizationArgs()
        {
        }
    }
}
