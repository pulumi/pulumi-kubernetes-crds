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
    public sealed class SyncIdentityProviderSpecIdentityProviders
    {
        /// <summary>
        /// basicAuth contains configuration options for the BasicAuth IdP
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersBasicAuth BasicAuth;
        /// <summary>
        /// github enables user authentication using GitHub credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGithub Github;
        /// <summary>
        /// gitlab enables user authentication using GitLab credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGitlab Gitlab;
        /// <summary>
        /// google enables user authentication using Google credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGoogle Google;
        /// <summary>
        /// htpasswd enables user authentication using an HTPasswd file to validate credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersHtpasswd Htpasswd;
        /// <summary>
        /// keystone enables user authentication using keystone password credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersKeystone Keystone;
        /// <summary>
        /// ldap enables user authentication using LDAP credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdap Ldap;
        /// <summary>
        /// mappingMethod determines how identities from this provider are mapped to users Defaults to "claim"
        /// </summary>
        public readonly string MappingMethod;
        /// <summary>
        /// name is used to qualify the identities returned by this provider. - It MUST be unique and not shared by any other identity provider used - It MUST be a valid path segment: name cannot equal "." or ".." or contain "/" or "%" or ":"   Ref: https://godoc.org/github.com/openshift/origin/pkg/user/apis/user/validation#ValidateIdentityProviderName
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// openID enables user authentication using OpenID credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersOpenID OpenID;
        /// <summary>
        /// requestHeader enables user authentication using request header credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersRequestHeader RequestHeader;
        /// <summary>
        /// type identifies the identity provider type for this entry.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private SyncIdentityProviderSpecIdentityProviders(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersBasicAuth basicAuth,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGithub github,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGitlab gitlab,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGoogle google,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersHtpasswd htpasswd,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersKeystone keystone,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdap ldap,

            string mappingMethod,

            string name,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersOpenID openID,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersRequestHeader requestHeader,

            string type)
        {
            BasicAuth = basicAuth;
            Github = github;
            Gitlab = gitlab;
            Google = google;
            Htpasswd = htpasswd;
            Keystone = keystone;
            Ldap = ldap;
            MappingMethod = mappingMethod;
            Name = name;
            OpenID = openID;
            RequestHeader = requestHeader;
            Type = type;
        }
    }
}
