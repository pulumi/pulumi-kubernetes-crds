// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Org.V1
{

    [OutputType]
    public sealed class CheClusterSpecAuth
    {
        /// <summary>
        /// Instructs the operator on whether or not to deploy a dedicated Identity Provider (Keycloak or RH SSO instance). By default a dedicated Identity Provider server is deployed as part of the Che installation. But if `externalIdentityProvider` is `true`, then no dedicated identity provider will be deployed by the operator and you might need to provide details about the external identity provider you want to use. See also all the other fields starting with: `identityProvider`.
        /// </summary>
        public readonly bool ExternalIdentityProvider;
        /// <summary>
        /// Overrides the name of the Identity Provider admin user. Defaults to `admin`.
        /// </summary>
        public readonly string IdentityProviderAdminUserName;
        /// <summary>
        /// Name of a Identity provider (Keycloak / RH SSO) `client-id` that should be used for Che. This is useful to override it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). If omitted or left blank, it will be set to the value of the `flavour` field suffixed with `-public`.
        /// </summary>
        public readonly string IdentityProviderClientId;
        /// <summary>
        /// Overrides the container image used in the Identity Provider (Keycloak / RH SSO) deployment. This includes the image tag. Omit it or leave it empty to use the defaut container image provided by the operator.
        /// </summary>
        public readonly string IdentityProviderImage;
        /// <summary>
        /// Overrides the image pull policy used in the Identity Provider (Keycloak / RH SSO) deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
        /// </summary>
        public readonly string IdentityProviderImagePullPolicy;
        /// <summary>
        /// Ingress custom settings
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecAuthIdentityProviderIngress IdentityProviderIngress;
        /// <summary>
        /// Overrides the password of Keycloak admin user. This is useful to override it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). If omitted or left blank, it will be set to an auto-generated password.
        /// </summary>
        public readonly string IdentityProviderPassword;
        /// <summary>
        /// Password for The Identity Provider (Keycloak / RH SSO) to connect to the database. This is useful to override it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). If omitted or left blank, it will be set to an auto-generated password.
        /// </summary>
        public readonly string IdentityProviderPostgresPassword;
        /// <summary>
        /// The secret that contains `password` for The Identity Provider (Keycloak / RH SSO) to connect to the database. If the secret is defined then `identityProviderPostgresPassword` will be ignored. If the value is omitted or left blank then there are two scenarios: 1. `identityProviderPostgresPassword` is defined, then it will be used to connect to the database. 2. `identityProviderPostgresPassword` is not defined, then a new secret with the name `che-identity-postgres-secret` will be created with an auto-generated value for `password`.
        /// </summary>
        public readonly string IdentityProviderPostgresSecret;
        /// <summary>
        /// Name of a Identity provider (Keycloak / RH SSO) realm that should be used for Che. This is useful to override it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). If omitted or left blank, it will be set to the value of the `flavour` field.
        /// </summary>
        public readonly string IdentityProviderRealm;
        /// <summary>
        /// Route custom settings
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecAuthIdentityProviderRoute IdentityProviderRoute;
        /// <summary>
        /// The secret that contains `user` and `password` for Identity Provider. If the secret is defined then `identityProviderAdminUserName` and `identityProviderPassword` are ignored. If the value is omitted or left blank then there are two scenarios: 1. `identityProviderAdminUserName` and `identityProviderPassword` are defined, then they will be used. 2. `identityProviderAdminUserName` or `identityProviderPassword` are not defined, then a new secret with the name `che-identity-secret` will be created with default value `admin` for `user` and with an auto-generated value for `password`.
        /// </summary>
        public readonly string IdentityProviderSecret;
        /// <summary>
        /// Public URL of the Identity Provider server (Keycloak / RH SSO server). You should set it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). By default this will be automatically calculated and set by the operator.
        /// </summary>
        public readonly string IdentityProviderURL;
        /// <summary>
        /// Name of the OpenShift `OAuthClient` resource used to setup identity federation on the OpenShift side. Auto-generated if left blank. See also the `OpenShiftoAuth` field.
        /// </summary>
        public readonly string OAuthClientName;
        /// <summary>
        /// Name of the secret set in the OpenShift `OAuthClient` resource used to setup identity federation on the OpenShift side. Auto-generated if left blank. See also the `OAuthClientName` field.
        /// </summary>
        public readonly string OAuthSecret;
        /// <summary>
        /// Enables the integration of the identity provider (Keycloak / RHSSO) with OpenShift OAuth. Enabled by default on OpenShift. This will allow users to directly login with their Openshift user through the Openshift login, and have their workspaces created under personal OpenShift namespaces. WARNING: the `kubeadmin` user is NOT supported, and logging through it will NOT allow accessing the Che Dashboard.
        /// </summary>
        public readonly bool OpenShiftoAuth;
        /// <summary>
        /// Forces the default `admin` Che user to update password on first login. Defaults to `false`.
        /// </summary>
        public readonly bool UpdateAdminPassword;

        [OutputConstructor]
        private CheClusterSpecAuth(
            bool externalIdentityProvider,

            string identityProviderAdminUserName,

            string identityProviderClientId,

            string identityProviderImage,

            string identityProviderImagePullPolicy,

            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecAuthIdentityProviderIngress identityProviderIngress,

            string identityProviderPassword,

            string identityProviderPostgresPassword,

            string identityProviderPostgresSecret,

            string identityProviderRealm,

            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecAuthIdentityProviderRoute identityProviderRoute,

            string identityProviderSecret,

            string identityProviderURL,

            string oAuthClientName,

            string oAuthSecret,

            bool openShiftoAuth,

            bool updateAdminPassword)
        {
            ExternalIdentityProvider = externalIdentityProvider;
            IdentityProviderAdminUserName = identityProviderAdminUserName;
            IdentityProviderClientId = identityProviderClientId;
            IdentityProviderImage = identityProviderImage;
            IdentityProviderImagePullPolicy = identityProviderImagePullPolicy;
            IdentityProviderIngress = identityProviderIngress;
            IdentityProviderPassword = identityProviderPassword;
            IdentityProviderPostgresPassword = identityProviderPostgresPassword;
            IdentityProviderPostgresSecret = identityProviderPostgresSecret;
            IdentityProviderRealm = identityProviderRealm;
            IdentityProviderRoute = identityProviderRoute;
            IdentityProviderSecret = identityProviderSecret;
            IdentityProviderURL = identityProviderURL;
            OAuthClientName = oAuthClientName;
            OAuthSecret = oAuthSecret;
            OpenShiftoAuth = openShiftoAuth;
            UpdateAdminPassword = updateAdminPassword;
        }
    }
}
