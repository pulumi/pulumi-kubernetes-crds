// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1
{

    /// <summary>
    /// ApmServerSpec holds the specification of an APM Server.
    /// </summary>
    public class ApmServerSpecArgs : Pulumi.ResourceArgs
    {
        [Input("config")]
        private InputMap<object>? _config;

        /// <summary>
        /// Config holds the APM Server configuration. See: https://www.elastic.co/guide/en/apm/server/current/configuring-howto-apm-server.html
        /// </summary>
        public InputMap<object> Config
        {
            get => _config ?? (_config = new InputMap<object>());
            set => _config = value;
        }

        /// <summary>
        /// Count of APM Server instances to deploy.
        /// </summary>
        [Input("count")]
        public Input<int>? Count { get; set; }

        /// <summary>
        /// ElasticsearchRef is a reference to the output Elasticsearch cluster running in the same Kubernetes cluster.
        /// </summary>
        [Input("elasticsearchRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerSpecElasticsearchRefArgs>? ElasticsearchRef { get; set; }

        /// <summary>
        /// HTTP holds the HTTP layer configuration for the APM Server resource.
        /// </summary>
        [Input("http")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerSpecHttpArgs>? Http { get; set; }

        /// <summary>
        /// Image is the APM Server Docker image to deploy.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// KibanaRef is a reference to a Kibana instance running in the same Kubernetes cluster. It allows APM agent central configuration management in Kibana.
        /// </summary>
        [Input("kibanaRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerSpecKibanaRefArgs>? KibanaRef { get; set; }

        [Input("podTemplate")]
        private InputMap<object>? _podTemplate;

        /// <summary>
        /// PodTemplate provides customisation options (labels, annotations, affinity rules, resource requests, and so on) for the APM Server pods.
        /// </summary>
        public InputMap<object> PodTemplate
        {
            get => _podTemplate ?? (_podTemplate = new InputMap<object>());
            set => _podTemplate = value;
        }

        [Input("secureSettings")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerSpecSecureSettingsArgs>? _secureSettings;

        /// <summary>
        /// SecureSettings is a list of references to Kubernetes secrets containing sensitive configuration options for APM Server.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerSpecSecureSettingsArgs> SecureSettings
        {
            get => _secureSettings ?? (_secureSettings = new InputList<Pulumi.Kubernetes.Types.Inputs.Apm.V1Alpha1.ApmServerSpecSecureSettingsArgs>());
            set => _secureSettings = value;
        }

        /// <summary>
        /// ServiceAccountName is used to check access from the current resource to a resource (eg. Elasticsearch) in a different namespace. Can only be used if ECK is enforcing RBAC on references.
        /// </summary>
        [Input("serviceAccountName")]
        public Input<string>? ServiceAccountName { get; set; }

        /// <summary>
        /// Version of the APM Server.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public ApmServerSpecArgs()
        {
        }
    }
}
