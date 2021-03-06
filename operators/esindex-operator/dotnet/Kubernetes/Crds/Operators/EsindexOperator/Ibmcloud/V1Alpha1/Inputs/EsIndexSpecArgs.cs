// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    public class EsIndexSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bind to an existing index if true, default value false
        /// </summary>
        [Input("bindOnly")]
        public Input<bool>? BindOnly { get; set; }

        /// <summary>
        /// Binding resource name that holds the secret for elastic search credentials
        /// </summary>
        [Input("bindingFrom")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.EsIndexSpecBindingFromArgs>? BindingFrom { get; set; }

        /// <summary>
        /// EsURIComposed is the URI of elasticesearch resource in the format https://&lt;user&gt;:&lt;passwd&gt;@hostname:port. Cannot be used if BindingFrom is not empty.
        /// </summary>
        [Input("esURIComposed")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.EsIndexSpecEsURIComposedArgs>? EsURIComposed { get; set; }

        /// <summary>
        /// Name of Index to be created on elastic search
        /// </summary>
        [Input("indexName", required: true)]
        public Input<string> IndexName { get; set; } = null!;

        /// <summary>
        /// Number of replicas, default value 1
        /// </summary>
        [Input("numberOfReplicas")]
        public Input<int>? NumberOfReplicas { get; set; }

        /// <summary>
        /// Number of shards, default value 1
        /// </summary>
        [Input("numberOfShards")]
        public Input<int>? NumberOfShards { get; set; }

        public EsIndexSpecArgs()
        {
        }
    }
}
