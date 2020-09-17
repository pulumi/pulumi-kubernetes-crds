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
    public sealed class SyncIdentityProviderSpecIdentityProvidersLdap
    {
        /// <summary>
        /// attributes maps LDAP attributes to identities
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdapAttributes Attributes;
        /// <summary>
        /// bindDN is an optional DN to bind with during the search phase.
        /// </summary>
        public readonly string BindDN;
        /// <summary>
        /// bindPassword is an optional reference to a secret by name containing a password to bind with during the search phase. The key "bindPassword" is used to locate the data. If specified and the secret or expected key is not found, the identity provider is not honored. The namespace for this secret is openshift-config.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdapBindPassword BindPassword;
        /// <summary>
        /// ca is an optional reference to a config map by name containing the PEM-encoded CA bundle. It is used as a trust anchor to validate the TLS certificate presented by the remote server. The key "ca.crt" is used to locate the data. If specified and the config map or expected key is not found, the identity provider is not honored. If the specified ca data is not valid, the identity provider is not honored. If empty, the default system roots are used. The namespace for this config map is openshift-config.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdapCa Ca;
        /// <summary>
        /// insecure, if true, indicates the connection should not use TLS WARNING: Should not be set to `true` with the URL scheme "ldaps://" as "ldaps://" URLs always          attempt to connect using TLS, even when `insecure` is set to `true` When `true`, "ldap://" URLS connect insecurely. When `false`, "ldap://" URLs are upgraded to a TLS connection using StartTLS as specified in https://tools.ietf.org/html/rfc2830.
        /// </summary>
        public readonly bool Insecure;
        /// <summary>
        /// url is an RFC 2255 URL which specifies the LDAP search parameters to use. The syntax of the URL is: ldap://host:port/basedn?attribute?scope?filter
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private SyncIdentityProviderSpecIdentityProvidersLdap(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdapAttributes attributes,

            string bindDN,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdapBindPassword bindPassword,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdapCa ca,

            bool insecure,

            string url)
        {
            Attributes = attributes;
            BindDN = bindDN;
            BindPassword = bindPassword;
            Ca = ca;
            Insecure = insecure;
            Url = url;
        }
    }
}
