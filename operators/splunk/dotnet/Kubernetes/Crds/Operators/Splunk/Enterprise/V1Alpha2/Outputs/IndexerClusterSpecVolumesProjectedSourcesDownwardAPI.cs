// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class IndexerClusterSpecVolumesProjectedSourcesDownwardAPI
    {
        /// <summary>
        /// Items is a list of DownwardAPIVolume file
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.IndexerClusterSpecVolumesProjectedSourcesDownwardAPIItems> Items;

        [OutputConstructor]
        private IndexerClusterSpecVolumesProjectedSourcesDownwardAPI(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.IndexerClusterSpecVolumesProjectedSourcesDownwardAPIItems> items)
        {
            Items = items;
        }
    }
}
