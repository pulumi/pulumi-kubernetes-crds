// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// IdentityProvider provides identities for users authenticating using credentials
    /// </summary>
    public class SyncIdentityProviderSpecIdentityProvidersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// basicAuth contains configuration options for the BasicAuth IdP
        /// </summary>
        [Input("basicAuth")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersBasicAuthArgs>? BasicAuth { get; set; }

        /// <summary>
        /// github enables user authentication using GitHub credentials
        /// </summary>
        [Input("github")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGithubArgs>? Github { get; set; }

        /// <summary>
        /// gitlab enables user authentication using GitLab credentials
        /// </summary>
        [Input("gitlab")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGitlabArgs>? Gitlab { get; set; }

        /// <summary>
        /// google enables user authentication using Google credentials
        /// </summary>
        [Input("google")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersGoogleArgs>? Google { get; set; }

        /// <summary>
        /// htpasswd enables user authentication using an HTPasswd file to validate credentials
        /// </summary>
        [Input("htpasswd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersHtpasswdArgs>? Htpasswd { get; set; }

        /// <summary>
        /// keystone enables user authentication using keystone password credentials
        /// </summary>
        [Input("keystone")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersKeystoneArgs>? Keystone { get; set; }

        /// <summary>
        /// ldap enables user authentication using LDAP credentials
        /// </summary>
        [Input("ldap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersLdapArgs>? Ldap { get; set; }

        /// <summary>
        /// mappingMethod determines how identities from this provider are mapped to users Defaults to "claim"
        /// </summary>
        [Input("mappingMethod")]
        public Input<string>? MappingMethod { get; set; }

        /// <summary>
        /// name is used to qualify the identities returned by this provider. - It MUST be unique and not shared by any other identity provider used - It MUST be a valid path segment: name cannot equal "." or ".." or contain "/" or "%" or ":"   Ref: https://godoc.org/github.com/openshift/origin/pkg/user/apis/user/validation#ValidateIdentityProviderName
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// openID enables user authentication using OpenID credentials
        /// </summary>
        [Input("openID")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersOpenIDArgs>? OpenID { get; set; }

        /// <summary>
        /// requestHeader enables user authentication using request header credentials
        /// </summary>
        [Input("requestHeader")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncIdentityProviderSpecIdentityProvidersRequestHeaderArgs>? RequestHeader { get; set; }

        /// <summary>
        /// type identifies the identity provider type for this entry.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public SyncIdentityProviderSpecIdentityProvidersArgs()
        {
        }
    }
}
