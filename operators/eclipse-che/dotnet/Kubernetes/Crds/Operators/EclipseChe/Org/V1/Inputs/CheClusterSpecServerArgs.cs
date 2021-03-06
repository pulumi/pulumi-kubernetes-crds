// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Org.V1
{

    /// <summary>
    /// General configuration settings related to the Che server and the plugin and devfile registries
    /// </summary>
    public class CheClusterSpecServerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional hostname (or url) to an alternate container registry to pull images from. This value overrides the container registry hostname defined in all the default container images involved in a Che deployment. This is particularly useful to install Che in an air-gapped environment.
        /// </summary>
        [Input("airGapContainerRegistryHostname")]
        public Input<string>? AirGapContainerRegistryHostname { get; set; }

        /// <summary>
        /// Optional repository name of an alternate container registry to pull images from. This value overrides the container registry organization defined in all the default container images involved in a Che deployment. This is particularly useful to install Che in an air-gapped environment.
        /// </summary>
        [Input("airGapContainerRegistryOrganization")]
        public Input<string>? AirGapContainerRegistryOrganization { get; set; }

        /// <summary>
        /// Defines if a user is able to specify Kubernetes namespace (or OpenShift project) different from the default. It's NOT RECOMMENDED to configured true without OAuth configured. This property is also used by the OpenShift infra.
        /// </summary>
        [Input("allowUserDefinedWorkspaceNamespaces")]
        public Input<bool>? AllowUserDefinedWorkspaceNamespaces { get; set; }

        /// <summary>
        /// Comma-separated list of ClusterRoles that will be assigned to che ServiceAccount. Be aware that che-operator has to already have all permissions in these ClusterRoles to be able to grant them.
        /// </summary>
        [Input("cheClusterRoles")]
        public Input<string>? CheClusterRoles { get; set; }

        /// <summary>
        /// Enables the debug mode for Che server. Defaults to `false`.
        /// </summary>
        [Input("cheDebug")]
        public Input<string>? CheDebug { get; set; }

        /// <summary>
        /// Flavor of the installation. This is either `che` for upstream Che installations, or `codeready` for CodeReady Workspaces installation. In most cases the default value should not be overridden.
        /// </summary>
        [Input("cheFlavor")]
        public Input<string>? CheFlavor { get; set; }

        /// <summary>
        /// Public hostname of the installed Che server. If value is omitted then it will be automatically set by the operator. (see the `cheHostTLSSecret` field).
        /// </summary>
        [Input("cheHost")]
        public Input<string>? CheHost { get; set; }

        /// <summary>
        /// Name of a secret containing certificates to secure ingress/route for the custom hostname of the installed Che server. (see the `cheHost` field).
        /// </summary>
        [Input("cheHostTLSSecret")]
        public Input<string>? CheHostTLSSecret { get; set; }

        /// <summary>
        /// Overrides the container image used in Che deployment. This does NOT include the container image tag. Omit it or leave it empty to use the defaut container image provided by the operator.
        /// </summary>
        [Input("cheImage")]
        public Input<string>? CheImage { get; set; }

        /// <summary>
        /// Overrides the image pull policy used in Che deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
        /// </summary>
        [Input("cheImagePullPolicy")]
        public Input<string>? CheImagePullPolicy { get; set; }

        /// <summary>
        /// Overrides the tag of the container image used in Che deployment. Omit it or leave it empty to use the defaut image tag provided by the operator.
        /// </summary>
        [Input("cheImageTag")]
        public Input<string>? CheImageTag { get; set; }

        /// <summary>
        /// Log level for the Che server: `INFO` or `DEBUG`. Defaults to `INFO`.
        /// </summary>
        [Input("cheLogLevel")]
        public Input<string>? CheLogLevel { get; set; }

        /// <summary>
        /// Che server ingress custom settings
        /// </summary>
        [Input("cheServerIngress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Org.V1.CheClusterSpecServerCheServerIngressArgs>? CheServerIngress { get; set; }

        /// <summary>
        /// Che server route custom settings
        /// </summary>
        [Input("cheServerRoute")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Org.V1.CheClusterSpecServerCheServerRouteArgs>? CheServerRoute { get; set; }

        /// <summary>
        /// Custom cluster role bound to the user for the Che workspaces. The default roles are used if this is omitted or left blank.
        /// </summary>
        [Input("cheWorkspaceClusterRole")]
        public Input<string>? CheWorkspaceClusterRole { get; set; }

        [Input("customCheProperties")]
        private InputMap<string>? _customCheProperties;

        /// <summary>
        /// Map of additional environment variables that will be applied in the generated `che` config map to be used by the Che server, in addition to the values already generated from other fields of the `CheCluster` custom resource (CR). If `customCheProperties` contains a property that would be normally generated in `che` config map from other CR fields, then the value defined in the `customCheProperties` will be used instead.
        /// </summary>
        public InputMap<string> CustomCheProperties
        {
            get => _customCheProperties ?? (_customCheProperties = new InputMap<string>());
            set => _customCheProperties = value;
        }

        /// <summary>
        /// Overrides the container image used in the Devfile registry deployment. This includes the image tag. Omit it or leave it empty to use the defaut container image provided by the operator.
        /// </summary>
        [Input("devfileRegistryImage")]
        public Input<string>? DevfileRegistryImage { get; set; }

        /// <summary>
        /// Devfile registry ingress custom settings
        /// </summary>
        [Input("devfileRegistryIngress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Org.V1.CheClusterSpecServerDevfileRegistryIngressArgs>? DevfileRegistryIngress { get; set; }

        /// <summary>
        /// Overrides the memory limit used in the Devfile registry deployment. Defaults to 256Mi.
        /// </summary>
        [Input("devfileRegistryMemoryLimit")]
        public Input<string>? DevfileRegistryMemoryLimit { get; set; }

        /// <summary>
        /// Overrides the memory request used in the Devfile registry deployment. Defaults to 16Mi.
        /// </summary>
        [Input("devfileRegistryMemoryRequest")]
        public Input<string>? DevfileRegistryMemoryRequest { get; set; }

        /// <summary>
        /// Overrides the image pull policy used in the Devfile registry deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
        /// </summary>
        [Input("devfileRegistryPullPolicy")]
        public Input<string>? DevfileRegistryPullPolicy { get; set; }

        /// <summary>
        /// Devfile registry route custom settings
        /// </summary>
        [Input("devfileRegistryRoute")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Org.V1.CheClusterSpecServerDevfileRegistryRouteArgs>? DevfileRegistryRoute { get; set; }

        /// <summary>
        /// Public URL of the Devfile registry, that serves sample, ready-to-use devfiles. You should set it ONLY if you use an external devfile registry (see the `externalDevfileRegistry` field). By default this will be automatically calculated by the operator.
        /// </summary>
        [Input("devfileRegistryUrl")]
        public Input<string>? DevfileRegistryUrl { get; set; }

        /// <summary>
        /// Instructs the operator on whether or not to deploy a dedicated Devfile registry server. By default a dedicated devfile registry server is started. But if `externalDevfileRegistry` is `true`, then no such dedicated server will be started by the operator and you will have to manually set the `devfileRegistryUrl` field
        /// </summary>
        [Input("externalDevfileRegistry")]
        public Input<bool>? ExternalDevfileRegistry { get; set; }

        /// <summary>
        /// Instructs the operator on whether or not to deploy a dedicated Plugin registry server. By default a dedicated plugin registry server is started. But if `externalPluginRegistry` is `true`, then no such dedicated server will be started by the operator and you will have to manually set the `pluginRegistryUrl` field.
        /// </summary>
        [Input("externalPluginRegistry")]
        public Input<bool>? ExternalPluginRegistry { get; set; }

        /// <summary>
        /// If enabled, then the certificate from `che-git-self-signed-cert` config map will be propagated to the Che components and provide particular configuration for Git.
        /// </summary>
        [Input("gitSelfSignedCert")]
        public Input<bool>? GitSelfSignedCert { get; set; }

        /// <summary>
        /// List of hosts that should not use the configured proxy. So specify wild card domain use the following form `.&lt;DOMAIN&gt;` and `|` as delimiter, eg: `localhost|.my.host.com|123.42.12.32` Only use when configuring a proxy is required. Operator respects OpenShift cluster wide proxy configuration and no additional configuration is required, but defining `nonProxyHosts` in a custom resource leads to merging non proxy hosts lists from the cluster proxy configuration and ones defined in the custom resources. (see the doc https://docs.openshift.com/container-platform/4.4/networking/enable-cluster-wide-proxy.html) (see also the `proxyURL` fields).
        /// </summary>
        [Input("nonProxyHosts")]
        public Input<string>? NonProxyHosts { get; set; }

        /// <summary>
        /// Overrides the container image used in the Plugin registry deployment. This includes the image tag. Omit it or leave it empty to use the default container image provided by the operator.
        /// </summary>
        [Input("pluginRegistryImage")]
        public Input<string>? PluginRegistryImage { get; set; }

        /// <summary>
        /// Plugin registry ingress custom settings
        /// </summary>
        [Input("pluginRegistryIngress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Org.V1.CheClusterSpecServerPluginRegistryIngressArgs>? PluginRegistryIngress { get; set; }

        /// <summary>
        /// Overrides the memory limit used in the Plugin registry deployment. Defaults to 256Mi.
        /// </summary>
        [Input("pluginRegistryMemoryLimit")]
        public Input<string>? PluginRegistryMemoryLimit { get; set; }

        /// <summary>
        /// Overrides the memory request used in the Plugin registry deployment. Defaults to 16Mi.
        /// </summary>
        [Input("pluginRegistryMemoryRequest")]
        public Input<string>? PluginRegistryMemoryRequest { get; set; }

        /// <summary>
        /// Overrides the image pull policy used in the Plugin registry deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
        /// </summary>
        [Input("pluginRegistryPullPolicy")]
        public Input<string>? PluginRegistryPullPolicy { get; set; }

        /// <summary>
        /// Plugin registry route custom settings
        /// </summary>
        [Input("pluginRegistryRoute")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Org.V1.CheClusterSpecServerPluginRegistryRouteArgs>? PluginRegistryRoute { get; set; }

        /// <summary>
        /// Public URL of the Plugin registry, that serves sample ready-to-use devfiles. You should set it ONLY if you use an external devfile registry (see the `externalPluginRegistry` field). By default this will be automatically calculated by the operator.
        /// </summary>
        [Input("pluginRegistryUrl")]
        public Input<string>? PluginRegistryUrl { get; set; }

        /// <summary>
        /// Password of the proxy server Only use when proxy configuration is required (see also the `proxyURL`, `proxyUser` and `proxySecret` fields).
        /// </summary>
        [Input("proxyPassword")]
        public Input<string>? ProxyPassword { get; set; }

        /// <summary>
        /// Port of the proxy server. Only use when configuring a proxy is required. (see also the `proxyURL` and `nonProxyHosts` fields).
        /// </summary>
        [Input("proxyPort")]
        public Input<string>? ProxyPort { get; set; }

        /// <summary>
        /// The secret that contains `user` and `password` for a proxy server. If the secret is defined then `proxyUser` and `proxyPassword` are ignored
        /// </summary>
        [Input("proxySecret")]
        public Input<string>? ProxySecret { get; set; }

        /// <summary>
        /// URL (protocol+hostname) of the proxy server. This drives the appropriate changes in the `JAVA_OPTS` and `https(s)_proxy` variables in the Che server and workspaces containers. Only use when configuring a proxy is required. Operator respects OpenShift cluster wide proxy configuration and no additional configuration is required, but defining `proxyUrl` in a custom resource leads to overrides the cluster proxy configuration with fields `proxyUrl`, `proxyPort`, `proxyUser` and `proxyPassword` from the custom resource. (see the doc https://docs.openshift.com/container-platform/4.4/networking/enable-cluster-wide-proxy.html) (see also the `proxyPort` and `nonProxyHosts` fields).
        /// </summary>
        [Input("proxyURL")]
        public Input<string>? ProxyURL { get; set; }

        /// <summary>
        /// User name of the proxy server. Only use when configuring a proxy is required (see also the `proxyURL`, `proxyPassword` and `proxySecret` fields).
        /// </summary>
        [Input("proxyUser")]
        public Input<string>? ProxyUser { get; set; }

        /// <summary>
        /// Deprecated. The value of this flag is ignored. Che operator will automatically detect if router certificate is self-signed. If so it will be propagated to Che server and some other components.
        /// </summary>
        [Input("selfSignedCert")]
        public Input<bool>? SelfSignedCert { get; set; }

        /// <summary>
        /// Sets the server and workspaces exposure type. Possible values are "multi-host", "single-host", "default-host". Defaults to "multi-host" which creates a separate ingress (or route on OpenShift) for every required endpoint. "single-host" makes Che exposed on a single hostname with workspaces exposed on subpaths. Please read the docs to learn about the limitations of this approach. Also consult the `singleHostExposureType` property to further configure how the operator and Che server make that happen on Kubernetes. "default-host" exposes che server on the host of the cluster. Please read the docs to learn about the limitations of this approach.
        /// </summary>
        [Input("serverExposureStrategy")]
        public Input<string>? ServerExposureStrategy { get; set; }

        /// <summary>
        /// Overrides the memory limit used in the Che server deployment. Defaults to 1Gi.
        /// </summary>
        [Input("serverMemoryLimit")]
        public Input<string>? ServerMemoryLimit { get; set; }

        /// <summary>
        /// Overrides the memory request used in the Che server deployment. Defaults to 512Mi.
        /// </summary>
        [Input("serverMemoryRequest")]
        public Input<string>? ServerMemoryRequest { get; set; }

        /// <summary>
        /// Name of the config-map with public certificates to add to Java trust store of the Che server. This is usually required when adding the OpenShift OAuth provider which has https endpoint signed with self-signed cert. So, Che server must be aware of its CA cert to be able to request it. This is disabled by default.
        /// </summary>
        [Input("serverTrustStoreConfigMapName")]
        public Input<string>? ServerTrustStoreConfigMapName { get; set; }

        [Input("singleHostGatewayConfigMapLabels")]
        private InputMap<string>? _singleHostGatewayConfigMapLabels;

        /// <summary>
        /// The labels that need to be present (and are put) on the configmaps representing the gateway configuration.
        /// </summary>
        public InputMap<string> SingleHostGatewayConfigMapLabels
        {
            get => _singleHostGatewayConfigMapLabels ?? (_singleHostGatewayConfigMapLabels = new InputMap<string>());
            set => _singleHostGatewayConfigMapLabels = value;
        }

        /// <summary>
        /// The image used for the gateway sidecar that provides configuration to the gateway. Omit it or leave it empty to use the defaut container image provided by the operator.
        /// </summary>
        [Input("singleHostGatewayConfigSidecarImage")]
        public Input<string>? SingleHostGatewayConfigSidecarImage { get; set; }

        /// <summary>
        /// The image used for the gateway in the single host mode. Omit it or leave it empty to use the defaut container image provided by the operator.
        /// </summary>
        [Input("singleHostGatewayImage")]
        public Input<string>? SingleHostGatewayImage { get; set; }

        /// <summary>
        /// Deprecated. Instructs the operator to deploy Che in TLS mode. This is enabled by default. Disabling TLS may cause malfunction of some Che components.
        /// </summary>
        [Input("tlsSupport")]
        public Input<bool>? TlsSupport { get; set; }

        /// <summary>
        /// Use internal cluster svc names to communicate between components to speed up the traffic and avoid proxy issues. The default value is `true`.
        /// </summary>
        [Input("useInternalClusterSVCNames")]
        public Input<bool>? UseInternalClusterSVCNames { get; set; }

        /// <summary>
        /// Defines Kubernetes default namespace in which user's workspaces are created if user does not override it. It's possible to use &lt;username&gt;, &lt;userid&gt; and &lt;workspaceid&gt; placeholders (e.g.: che-workspace-&lt;username&gt;). In that case, new namespace will be created for each user (or workspace). Is used by OpenShift infra as well to specify Project
        /// </summary>
        [Input("workspaceNamespaceDefault")]
        public Input<string>? WorkspaceNamespaceDefault { get; set; }

        public CheClusterSpecServerArgs()
        {
        }
    }
}
