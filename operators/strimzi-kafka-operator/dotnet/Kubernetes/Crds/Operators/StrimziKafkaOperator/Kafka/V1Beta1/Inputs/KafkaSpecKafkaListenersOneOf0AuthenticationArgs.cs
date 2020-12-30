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
    /// Authentication configuration for this listener.
    /// </summary>
    public class KafkaSpecKafkaListenersOneOf0AuthenticationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configure whether the access token is treated as JWT. This must be set to `false` if the authorization server returns opaque tokens. Defaults to `true`.
        /// </summary>
        [Input("accessTokenIsJwt")]
        public Input<bool>? AccessTokenIsJwt { get; set; }

        /// <summary>
        /// Configure whether the access token type check is performed or not. This should be set to `false` if the authorization server does not include 'typ' claim in JWT token. Defaults to `true`.
        /// </summary>
        [Input("checkAccessTokenType")]
        public Input<bool>? CheckAccessTokenType { get; set; }

        /// <summary>
        /// Enable or disable issuer checking. By default issuer is checked using the value configured by `validIssuerUri`. Default value is `true`.
        /// </summary>
        [Input("checkIssuer")]
        public Input<bool>? CheckIssuer { get; set; }

        /// <summary>
        /// OAuth Client ID which the Kafka broker can use to authenticate against the authorization server and use the introspect endpoint URI.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// Link to Kubernetes Secret containing the OAuth client secret which the Kafka broker can use to authenticate against the authorization server and use the introspect endpoint URI.
        /// </summary>
        [Input("clientSecret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0AuthenticationClientSecretArgs>? ClientSecret { get; set; }

        /// <summary>
        /// Enable or disable TLS hostname verification. Default value is `false`.
        /// </summary>
        [Input("disableTlsHostnameVerification")]
        public Input<bool>? DisableTlsHostnameVerification { get; set; }

        /// <summary>
        /// Enable or disable ECDSA support by installing BouncyCastle crypto provider. Default value is `false`.
        /// </summary>
        [Input("enableECDSA")]
        public Input<bool>? EnableECDSA { get; set; }

        /// <summary>
        /// The fallback username claim to be used for the user id if the claim specified by `userNameClaim` is not present. This is useful when `client_credentials` authentication only results in the client id being provided in another claim. It only takes effect if `userNameClaim` is set.
        /// </summary>
        [Input("fallbackUserNameClaim")]
        public Input<string>? FallbackUserNameClaim { get; set; }

        /// <summary>
        /// The prefix to use with the value of `fallbackUserNameClaim` to construct the user id. This only takes effect if `fallbackUserNameClaim` is true, and the value is present for the claim. Mapping usernames and client ids into the same user id space is useful in preventing name collisions.
        /// </summary>
        [Input("fallbackUserNamePrefix")]
        public Input<string>? FallbackUserNamePrefix { get; set; }

        /// <summary>
        /// URI of the token introspection endpoint which can be used to validate opaque non-JWT tokens.
        /// </summary>
        [Input("introspectionEndpointUri")]
        public Input<string>? IntrospectionEndpointUri { get; set; }

        /// <summary>
        /// URI of the JWKS certificate endpoint, which can be used for local JWT validation.
        /// </summary>
        [Input("jwksEndpointUri")]
        public Input<string>? JwksEndpointUri { get; set; }

        /// <summary>
        /// Configures how often are the JWKS certificates considered valid. The expiry interval has to be at least 60 seconds longer then the refresh interval specified in `jwksRefreshSeconds`. Defaults to 360 seconds.
        /// </summary>
        [Input("jwksExpirySeconds")]
        public Input<int>? JwksExpirySeconds { get; set; }

        /// <summary>
        /// The minimum pause between two consecutive refreshes. When an unknown signing key is encountered the refresh is scheduled immediately, but will always wait for this minimum pause. Defaults to 1 second.
        /// </summary>
        [Input("jwksMinRefreshPauseSeconds")]
        public Input<int>? JwksMinRefreshPauseSeconds { get; set; }

        /// <summary>
        /// Configures how often are the JWKS certificates refreshed. The refresh interval has to be at least 60 seconds shorter then the expiry interval specified in `jwksExpirySeconds`. Defaults to 300 seconds.
        /// </summary>
        [Input("jwksRefreshSeconds")]
        public Input<int>? JwksRefreshSeconds { get; set; }

        /// <summary>
        /// Maximum number of seconds the authenticated session remains valid without re-authentication. This enables Apache Kafka re-authentication feature, and causes sessions to expire when the access token expires. If the access token expires before max time or if max time is reached, the client has to re-authenticate, otherwise the server will drop the connection. Not set by default - the authenticated session does not expire when the access token expires.
        /// </summary>
        [Input("maxSecondsWithoutReauthentication")]
        public Input<int>? MaxSecondsWithoutReauthentication { get; set; }

        [Input("tlsTrustedCertificates")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0AuthenticationTlsTrustedCertificatesArgs>? _tlsTrustedCertificates;

        /// <summary>
        /// Trusted certificates for TLS connection to the OAuth server.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0AuthenticationTlsTrustedCertificatesArgs> TlsTrustedCertificates
        {
            get => _tlsTrustedCertificates ?? (_tlsTrustedCertificates = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0AuthenticationTlsTrustedCertificatesArgs>());
            set => _tlsTrustedCertificates = value;
        }

        /// <summary>
        /// Authentication type. `oauth` type uses SASL OAUTHBEARER Authentication. `scram-sha-512` type uses SASL SCRAM-SHA-512 Authentication. `tls` type uses TLS Client Authentication. `tls` type is supported only on TLS listeners.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// URI of the User Info Endpoint to use as a fallback to obtaining the user id when the Introspection Endpoint does not return information that can be used for the user id. 
        /// </summary>
        [Input("userInfoEndpointUri")]
        public Input<string>? UserInfoEndpointUri { get; set; }

        /// <summary>
        /// Name of the claim from the JWT authentication token, Introspection Endpoint response or User Info Endpoint response which will be used to extract the user id. Defaults to `sub`.
        /// </summary>
        [Input("userNameClaim")]
        public Input<string>? UserNameClaim { get; set; }

        /// <summary>
        /// URI of the token issuer used for authentication.
        /// </summary>
        [Input("validIssuerUri")]
        public Input<string>? ValidIssuerUri { get; set; }

        /// <summary>
        /// Valid value for the `token_type` attribute returned by the Introspection Endpoint. No default value, and not checked by default.
        /// </summary>
        [Input("validTokenType")]
        public Input<string>? ValidTokenType { get; set; }

        public KafkaSpecKafkaListenersOneOf0AuthenticationArgs()
        {
        }
    }
}
