// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ArgoCDSpec
    {
        /// <summary>
        /// ApplicationInstanceLabelKey is the key name where Argo CD injects the app name as a tracking label.
        /// </summary>
        public readonly string ApplicationInstanceLabelKey;
        /// <summary>
        /// ConfigManagementPlugins is used to specify additional config management plugins.
        /// </summary>
        public readonly string ConfigManagementPlugins;
        /// <summary>
        /// Controller defines the Application Controller options for ArgoCD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecController Controller;
        /// <summary>
        /// Dex defines the Dex server options for ArgoCD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecDex Dex;
        /// <summary>
        /// GAAnonymizeUsers toggles user IDs being hashed before sending to google analytics.
        /// </summary>
        public readonly bool GaAnonymizeUsers;
        /// <summary>
        /// GATrackingID is the google analytics tracking ID to use.
        /// </summary>
        public readonly string GaTrackingID;
        /// <summary>
        /// Grafana defines the Grafana server options for ArgoCD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecGrafana Grafana;
        /// <summary>
        /// HA options for High Availability support for the Redis component.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecHa Ha;
        /// <summary>
        /// HelpChatText is the text for getting chat help, defaults to "Chat now!"
        /// </summary>
        public readonly string HelpChatText;
        /// <summary>
        /// HelpChatURL is the URL for getting chat help, this will typically be your Slack channel for support.
        /// </summary>
        public readonly string HelpChatURL;
        /// <summary>
        /// Image is the ArgoCD container image for all ArgoCD components.
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// Import is the import/restore options for ArgoCD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecImport Import;
        /// <summary>
        /// InitialRepositories to configure Argo CD with upon creation of the cluster.
        /// </summary>
        public readonly string InitialRepositories;
        /// <summary>
        /// InitialSSHKnownHosts defines the SSH known hosts data upon creation of the cluster for connecting Git repositories via SSH.
        /// </summary>
        public readonly string InitialSSHKnownHosts;
        /// <summary>
        /// KustomizeBuildOptions is used to specify build options/parameters to use with `kustomize build`.
        /// </summary>
        public readonly string KustomizeBuildOptions;
        /// <summary>
        /// OIDCConfig is the OIDC configuration as an alternative to dex.
        /// </summary>
        public readonly string OidcConfig;
        /// <summary>
        /// Prometheus defines the Prometheus server options for ArgoCD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecPrometheus Prometheus;
        /// <summary>
        /// RBAC defines the RBAC configuration for Argo CD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecRbac Rbac;
        /// <summary>
        /// Redis defines the Redis server options for ArgoCD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecRedis Redis;
        /// <summary>
        /// Repo defines the repo server options for Argo CD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecRepo Repo;
        /// <summary>
        /// RepositoryCredentials are the Git pull credentials to configure Argo CD with upon creation of the cluster.
        /// </summary>
        public readonly string RepositoryCredentials;
        /// <summary>
        /// ResourceCustomizations customizes resource behavior. Keys are in the form: group/Kind.
        /// </summary>
        public readonly string ResourceCustomizations;
        /// <summary>
        /// ResourceExclusions is used to completely ignore entire classes of resource group/kinds.
        /// </summary>
        public readonly string ResourceExclusions;
        /// <summary>
        /// Server defines the options for the ArgoCD Server component.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecServer Server;
        /// <summary>
        /// StatusBadgeEnabled toggles application status badge feature.
        /// </summary>
        public readonly bool StatusBadgeEnabled;
        /// <summary>
        /// TLS defines the TLS options for ArgoCD.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecTls Tls;
        /// <summary>
        /// UsersAnonymousEnabled toggles anonymous user access. The anonymous users get default role permissions specified argocd-rbac-cm.
        /// </summary>
        public readonly bool UsersAnonymousEnabled;
        /// <summary>
        /// Version is the tag to use with the ArgoCD container image for all ArgoCD components.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ArgoCDSpec(
            string applicationInstanceLabelKey,

            string configManagementPlugins,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecController controller,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecDex dex,

            bool gaAnonymizeUsers,

            string gaTrackingID,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecGrafana grafana,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecHa ha,

            string helpChatText,

            string helpChatURL,

            string image,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecImport import,

            string initialRepositories,

            string initialSSHKnownHosts,

            string kustomizeBuildOptions,

            string oidcConfig,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecPrometheus prometheus,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecRbac rbac,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecRedis redis,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecRepo repo,

            string repositoryCredentials,

            string resourceCustomizations,

            string resourceExclusions,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecServer server,

            bool statusBadgeEnabled,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecTls tls,

            bool usersAnonymousEnabled,

            string version)
        {
            ApplicationInstanceLabelKey = applicationInstanceLabelKey;
            ConfigManagementPlugins = configManagementPlugins;
            Controller = controller;
            Dex = dex;
            GaAnonymizeUsers = gaAnonymizeUsers;
            GaTrackingID = gaTrackingID;
            Grafana = grafana;
            Ha = ha;
            HelpChatText = helpChatText;
            HelpChatURL = helpChatURL;
            Image = image;
            Import = import;
            InitialRepositories = initialRepositories;
            InitialSSHKnownHosts = initialSSHKnownHosts;
            KustomizeBuildOptions = kustomizeBuildOptions;
            OidcConfig = oidcConfig;
            Prometheus = prometheus;
            Rbac = rbac;
            Redis = redis;
            Repo = repo;
            RepositoryCredentials = repositoryCredentials;
            ResourceCustomizations = resourceCustomizations;
            ResourceExclusions = resourceExclusions;
            Server = server;
            StatusBadgeEnabled = statusBadgeEnabled;
            Tls = tls;
            UsersAnonymousEnabled = usersAnonymousEnabled;
            Version = version;
        }
    }
}