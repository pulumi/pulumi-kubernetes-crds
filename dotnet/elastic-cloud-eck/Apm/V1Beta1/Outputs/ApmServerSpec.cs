// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1
{

    [OutputType]
    public sealed class ApmServerSpec
    {
        /// <summary>
        /// Config holds the APM Server configuration. See: https://www.elastic.co/guide/en/apm/server/current/configuring-howto-apm-server.html
        /// </summary>
        public readonly ImmutableDictionary<string, object> Config;
        /// <summary>
        /// Count of APM Server instances to deploy.
        /// </summary>
        public readonly int Count;
        /// <summary>
        /// ElasticsearchRef is a reference to the output Elasticsearch cluster running in the same Kubernetes cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1.ApmServerSpecElasticsearchRef ElasticsearchRef;
        /// <summary>
        /// HTTP holds the HTTP layer configuration for the APM Server resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1.ApmServerSpecHttp Http;
        /// <summary>
        /// Image is the APM Server Docker image to deploy.
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// KibanaRef is a reference to a Kibana instance running in the same Kubernetes cluster. It allows APM agent central configuration management in Kibana.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1.ApmServerSpecKibanaRef KibanaRef;
        /// <summary>
        /// PodTemplate provides customisation options (labels, annotations, affinity rules, resource requests, and so on) for the APM Server pods.
        /// </summary>
        public readonly ImmutableDictionary<string, object> PodTemplate;
        /// <summary>
        /// SecureSettings is a list of references to Kubernetes secrets containing sensitive configuration options for APM Server.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1.ApmServerSpecSecureSettings> SecureSettings;
        /// <summary>
        /// ServiceAccountName is used to check access from the current resource to a resource (eg. Elasticsearch) in a different namespace. Can only be used if ECK is enforcing RBAC on references.
        /// </summary>
        public readonly string ServiceAccountName;
        /// <summary>
        /// Version of the APM Server.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ApmServerSpec(
            ImmutableDictionary<string, object> config,

            int count,

            Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1.ApmServerSpecElasticsearchRef elasticsearchRef,

            Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1.ApmServerSpecHttp http,

            string image,

            Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1.ApmServerSpecKibanaRef kibanaRef,

            ImmutableDictionary<string, object> podTemplate,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apm.V1Beta1.ApmServerSpecSecureSettings> secureSettings,

            string serviceAccountName,

            string version)
        {
            Config = config;
            Count = count;
            ElasticsearchRef = elasticsearchRef;
            Http = http;
            Image = image;
            KibanaRef = kibanaRef;
            PodTemplate = podTemplate;
            SecureSettings = secureSettings;
            ServiceAccountName = serviceAccountName;
            Version = version;
        }
    }
}