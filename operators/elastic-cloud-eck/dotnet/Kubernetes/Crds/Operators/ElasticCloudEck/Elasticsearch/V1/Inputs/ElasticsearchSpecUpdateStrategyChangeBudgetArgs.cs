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
    /// ChangeBudget defines the constraints to consider when applying changes to the Elasticsearch cluster.
    /// </summary>
    public class ElasticsearchSpecUpdateStrategyChangeBudgetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// MaxSurge is the maximum number of new pods that can be created exceeding the original number of pods defined in the specification. MaxSurge is only taken into consideration when scaling up. Setting a negative value will disable the restriction. Defaults to unbounded if not specified.
        /// </summary>
        [Input("maxSurge")]
        public Input<int>? MaxSurge { get; set; }

        /// <summary>
        /// MaxUnavailable is the maximum number of pods that can be unavailable (not ready) during the update due to circumstances under the control of the operator. Setting a negative value will disable this restriction. Defaults to 1 if not specified.
        /// </summary>
        [Input("maxUnavailable")]
        public Input<int>? MaxUnavailable { get; set; }

        public ElasticsearchSpecUpdateStrategyChangeBudgetArgs()
        {
        }
    }
}
