// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apm.V1
{

    /// <summary>
    /// ElasticsearchRef is a reference to the output Elasticsearch cluster running in the same Kubernetes cluster.
    /// </summary>
    public class ApmServerSpecElasticsearchRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the Kubernetes object.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Namespace of the Kubernetes object. If empty, defaults to the current namespace.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public ApmServerSpecElasticsearchRefArgs()
        {
        }
    }
}
