// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class ThanosRulerSpecVolumesProjectedSourcesDownwardAPI
    {
        /// <summary>
        /// Items is a list of DownwardAPIVolume file
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItems> Items;

        [OutputConstructor]
        private ThanosRulerSpecVolumesProjectedSourcesDownwardAPI(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItems> items)
        {
            Items = items;
        }
    }
}