// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprisesearch.V1Beta1
{

    [OutputType]
    public sealed class EnterpriseSearchSpec
    {
        /// <summary>
        /// Config holds the Enterprise Search configuration.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Config;
        /// <summary>
        /// ConfigRef contains a reference to an existing Kubernetes Secret holding the Enterprise Search configuration. Configuration settings are merged and have precedence over settings specified in `config`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprisesearch.V1Beta1.EnterpriseSearchSpecConfigRef ConfigRef;
        /// <summary>
        /// Count of Enterprise Search instances to deploy.
        /// </summary>
        public readonly int Count;
        /// <summary>
        /// ElasticsearchRef is a reference to the Elasticsearch cluster running in the same Kubernetes cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprisesearch.V1Beta1.EnterpriseSearchSpecElasticsearchRef ElasticsearchRef;
        /// <summary>
        /// HTTP holds the HTTP layer configuration for Enterprise Search resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprisesearch.V1Beta1.EnterpriseSearchSpecHttp Http;
        /// <summary>
        /// Image is the Enterprise Search Docker image to deploy.
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// PodTemplate provides customisation options (labels, annotations, affinity rules, resource requests, and so on) for the Enterprise Search pods.
        /// </summary>
        public readonly ImmutableDictionary<string, object> PodTemplate;
        /// <summary>
        /// ServiceAccountName is used to check access from the current resource to a resource (eg. Elasticsearch) in a different namespace. Can only be used if ECK is enforcing RBAC on references.
        /// </summary>
        public readonly string ServiceAccountName;
        /// <summary>
        /// Version of Enterprise Search.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private EnterpriseSearchSpec(
            ImmutableDictionary<string, object> config,

            Pulumi.Kubernetes.Types.Outputs.Enterprisesearch.V1Beta1.EnterpriseSearchSpecConfigRef configRef,

            int count,

            Pulumi.Kubernetes.Types.Outputs.Enterprisesearch.V1Beta1.EnterpriseSearchSpecElasticsearchRef elasticsearchRef,

            Pulumi.Kubernetes.Types.Outputs.Enterprisesearch.V1Beta1.EnterpriseSearchSpecHttp http,

            string image,

            ImmutableDictionary<string, object> podTemplate,

            string serviceAccountName,

            string version)
        {
            Config = config;
            ConfigRef = configRef;
            Count = count;
            ElasticsearchRef = elasticsearchRef;
            Http = http;
            Image = image;
            PodTemplate = podTemplate;
            ServiceAccountName = serviceAccountName;
            Version = version;
        }
    }
}
