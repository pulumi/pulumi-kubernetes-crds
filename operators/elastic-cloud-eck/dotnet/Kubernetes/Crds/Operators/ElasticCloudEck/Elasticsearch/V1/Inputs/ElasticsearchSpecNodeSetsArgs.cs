// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1
{

    /// <summary>
    /// NodeSet is the specification for a group of Elasticsearch nodes sharing the same configuration and a Pod template.
    /// </summary>
    public class ElasticsearchSpecNodeSetsArgs : Pulumi.ResourceArgs
    {
        [Input("config")]
        private InputMap<object>? _config;

        /// <summary>
        /// Config holds the Elasticsearch configuration.
        /// </summary>
        public InputMap<object> Config
        {
            get => _config ?? (_config = new InputMap<object>());
            set => _config = value;
        }

        /// <summary>
        /// Count of Elasticsearch nodes to deploy.
        /// </summary>
        [Input("count", required: true)]
        public Input<int> Count { get; set; } = null!;

        /// <summary>
        /// Name of this set of nodes. Becomes a part of the Elasticsearch node.name setting.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("podTemplate")]
        private InputMap<object>? _podTemplate;

        /// <summary>
        /// PodTemplate provides customisation options (labels, annotations, affinity rules, resource requests, and so on) for the Pods belonging to this NodeSet.
        /// </summary>
        public InputMap<object> PodTemplate
        {
            get => _podTemplate ?? (_podTemplate = new InputMap<object>());
            set => _podTemplate = value;
        }

        [Input("volumeClaimTemplates")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecNodeSetsVolumeClaimTemplatesArgs>? _volumeClaimTemplates;

        /// <summary>
        /// VolumeClaimTemplates is a list of persistent volume claims to be used by each Pod in this NodeSet. Every claim in this list must have a matching volumeMount in one of the containers defined in the PodTemplate. Items defined here take precedence over any default claims added by the operator with the same name.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecNodeSetsVolumeClaimTemplatesArgs> VolumeClaimTemplates
        {
            get => _volumeClaimTemplates ?? (_volumeClaimTemplates = new InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecNodeSetsVolumeClaimTemplatesArgs>());
            set => _volumeClaimTemplates = value;
        }

        public ElasticsearchSpecNodeSetsArgs()
        {
        }
    }
}
