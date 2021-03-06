// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// ArgoCDSpec defines the desired state of ArgoCD
    /// </summary>
    public class ArgoCDSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ApplicationInstanceLabelKey is the key name where Argo CD injects the app name as a tracking label.
        /// </summary>
        [Input("applicationInstanceLabelKey")]
        public Input<string>? ApplicationInstanceLabelKey { get; set; }

        /// <summary>
        /// ConfigManagementPlugins is used to specify additional config management plugins.
        /// </summary>
        [Input("configManagementPlugins")]
        public Input<string>? ConfigManagementPlugins { get; set; }

        /// <summary>
        /// Controller defines the Application Controller options for ArgoCD.
        /// </summary>
        [Input("controller")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecControllerArgs>? Controller { get; set; }

        /// <summary>
        /// Dex defines the Dex server options for ArgoCD.
        /// </summary>
        [Input("dex")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecDexArgs>? Dex { get; set; }

        /// <summary>
        /// GAAnonymizeUsers toggles user IDs being hashed before sending to google analytics.
        /// </summary>
        [Input("gaAnonymizeUsers")]
        public Input<bool>? GaAnonymizeUsers { get; set; }

        /// <summary>
        /// GATrackingID is the google analytics tracking ID to use.
        /// </summary>
        [Input("gaTrackingID")]
        public Input<string>? GaTrackingID { get; set; }

        /// <summary>
        /// Grafana defines the Grafana server options for ArgoCD.
        /// </summary>
        [Input("grafana")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecGrafanaArgs>? Grafana { get; set; }

        /// <summary>
        /// HA options for High Availability support for the Redis component.
        /// </summary>
        [Input("ha")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecHaArgs>? Ha { get; set; }

        /// <summary>
        /// HelpChatText is the text for getting chat help, defaults to "Chat now!"
        /// </summary>
        [Input("helpChatText")]
        public Input<string>? HelpChatText { get; set; }

        /// <summary>
        /// HelpChatURL is the URL for getting chat help, this will typically be your Slack channel for support.
        /// </summary>
        [Input("helpChatURL")]
        public Input<string>? HelpChatURL { get; set; }

        /// <summary>
        /// Image is the ArgoCD container image for all ArgoCD components.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// Import is the import/restore options for ArgoCD.
        /// </summary>
        [Input("import")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecImportArgs>? Import { get; set; }

        /// <summary>
        /// InitialRepositories to configure Argo CD with upon creation of the cluster.
        /// </summary>
        [Input("initialRepositories")]
        public Input<string>? InitialRepositories { get; set; }

        /// <summary>
        /// InitialSSHKnownHosts defines the SSH known hosts data upon creation of the cluster for connecting Git repositories via SSH.
        /// </summary>
        [Input("initialSSHKnownHosts")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecInitialSSHKnownHostsArgs>? InitialSSHKnownHosts { get; set; }

        /// <summary>
        /// KustomizeBuildOptions is used to specify build options/parameters to use with `kustomize build`.
        /// </summary>
        [Input("kustomizeBuildOptions")]
        public Input<string>? KustomizeBuildOptions { get; set; }

        /// <summary>
        /// OIDCConfig is the OIDC configuration as an alternative to dex.
        /// </summary>
        [Input("oidcConfig")]
        public Input<string>? OidcConfig { get; set; }

        /// <summary>
        /// Prometheus defines the Prometheus server options for ArgoCD.
        /// </summary>
        [Input("prometheus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecPrometheusArgs>? Prometheus { get; set; }

        /// <summary>
        /// RBAC defines the RBAC configuration for Argo CD.
        /// </summary>
        [Input("rbac")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecRbacArgs>? Rbac { get; set; }

        /// <summary>
        /// Redis defines the Redis server options for ArgoCD.
        /// </summary>
        [Input("redis")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecRedisArgs>? Redis { get; set; }

        /// <summary>
        /// Repo defines the repo server options for Argo CD.
        /// </summary>
        [Input("repo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecRepoArgs>? Repo { get; set; }

        /// <summary>
        /// RepositoryCredentials are the Git pull credentials to configure Argo CD with upon creation of the cluster.
        /// </summary>
        [Input("repositoryCredentials")]
        public Input<string>? RepositoryCredentials { get; set; }

        /// <summary>
        /// ResourceCustomizations customizes resource behavior. Keys are in the form: group/Kind.
        /// </summary>
        [Input("resourceCustomizations")]
        public Input<string>? ResourceCustomizations { get; set; }

        /// <summary>
        /// ResourceExclusions is used to completely ignore entire classes of resource group/kinds.
        /// </summary>
        [Input("resourceExclusions")]
        public Input<string>? ResourceExclusions { get; set; }

        /// <summary>
        /// ResourceInclusions is used to only include specific group/kinds in the reconciliation process.
        /// </summary>
        [Input("resourceInclusions")]
        public Input<string>? ResourceInclusions { get; set; }

        /// <summary>
        /// Server defines the options for the ArgoCD Server component.
        /// </summary>
        [Input("server")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecServerArgs>? Server { get; set; }

        /// <summary>
        /// StatusBadgeEnabled toggles application status badge feature.
        /// </summary>
        [Input("statusBadgeEnabled")]
        public Input<bool>? StatusBadgeEnabled { get; set; }

        /// <summary>
        /// TLS defines the TLS options for ArgoCD.
        /// </summary>
        [Input("tls")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecTlsArgs>? Tls { get; set; }

        /// <summary>
        /// UsersAnonymousEnabled toggles anonymous user access. The anonymous users get default role permissions specified argocd-rbac-cm.
        /// </summary>
        [Input("usersAnonymousEnabled")]
        public Input<bool>? UsersAnonymousEnabled { get; set; }

        /// <summary>
        /// Version is the tag to use with the ArgoCD container image for all ArgoCD components.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ArgoCDSpecArgs()
        {
        }
    }
}
