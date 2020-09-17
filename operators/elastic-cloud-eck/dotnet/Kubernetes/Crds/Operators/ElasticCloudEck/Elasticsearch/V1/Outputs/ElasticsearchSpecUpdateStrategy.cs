// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1
{

    [OutputType]
    public sealed class ElasticsearchSpecUpdateStrategy
    {
        /// <summary>
        /// ChangeBudget defines the constraints to consider when applying changes to the Elasticsearch cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecUpdateStrategyChangeBudget ChangeBudget;

        [OutputConstructor]
        private ElasticsearchSpecUpdateStrategy(Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecUpdateStrategyChangeBudget changeBudget)
        {
            ChangeBudget = changeBudget;
        }
    }
}
