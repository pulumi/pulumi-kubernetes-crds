// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kibana.V1
{

    /// <summary>
    /// KibanaSpec holds the specification of a Kibana instance.
    /// </summary>
    public class KibanaSpecArgs : Pulumi.ResourceArgs
    {
        [Input("config")]
        private InputMap<object>? _config;

        /// <summary>
        /// Config holds the Kibana configuration. See: https://www.elastic.co/guide/en/kibana/current/settings.html
        /// </summary>
        public InputMap<object> Config
        {
            get => _config ?? (_config = new InputMap<object>());
            set => _config = value;
        }

        /// <summary>
        /// Count of Kibana instances to deploy.
        /// </summary>
        [Input("count")]
        public Input<int>? Count { get; set; }

        /// <summary>
        /// ElasticsearchRef is a reference to an Elasticsearch cluster running in the same Kubernetes cluster.
        /// </summary>
        [Input("elasticsearchRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kibana.V1.KibanaSpecElasticsearchRefArgs>? ElasticsearchRef { get; set; }

        /// <summary>
        /// HTTP holds the HTTP layer configuration for Kibana.
        /// </summary>
        [Input("http")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kibana.V1.KibanaSpecHttpArgs>? Http { get; set; }

        /// <summary>
        /// Image is the Kibana Docker image to deploy.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("podTemplate")]
        private InputMap<object>? _podTemplate;

        /// <summary>
        /// PodTemplate provides customisation options (labels, annotations, affinity rules, resource requests, and so on) for the Kibana pods
        /// </summary>
        public InputMap<object> PodTemplate
        {
            get => _podTemplate ?? (_podTemplate = new InputMap<object>());
            set => _podTemplate = value;
        }

        [Input("secureSettings")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kibana.V1.KibanaSpecSecureSettingsArgs>? _secureSettings;

        /// <summary>
        /// SecureSettings is a list of references to Kubernetes secrets containing sensitive configuration options for Kibana.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kibana.V1.KibanaSpecSecureSettingsArgs> SecureSettings
        {
            get => _secureSettings ?? (_secureSettings = new InputList<Pulumi.Kubernetes.Types.Inputs.Kibana.V1.KibanaSpecSecureSettingsArgs>());
            set => _secureSettings = value;
        }

        /// <summary>
        /// ServiceAccountName is used to check access from the current resource to a resource (eg. Elasticsearch) in a different namespace. Can only be used if ECK is enforcing RBAC on references.
        /// </summary>
        [Input("serviceAccountName")]
        public Input<string>? ServiceAccountName { get; set; }

        /// <summary>
        /// Version of Kibana.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public KibanaSpecArgs()
        {
        }
    }
}
