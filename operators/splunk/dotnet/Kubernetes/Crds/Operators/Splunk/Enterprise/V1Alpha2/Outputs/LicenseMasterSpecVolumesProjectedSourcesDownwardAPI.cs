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
    public sealed class LicenseMasterSpecVolumesProjectedSourcesDownwardAPI
    {
        /// <summary>
        /// Items is a list of DownwardAPIVolume file
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesProjectedSourcesDownwardAPIItems> Items;

        [OutputConstructor]
        private LicenseMasterSpecVolumesProjectedSourcesDownwardAPI(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesProjectedSourcesDownwardAPIItems> items)
        {
            Items = items;
        }
    }
}
