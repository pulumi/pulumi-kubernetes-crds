// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// information about the downwardAPI data to project
    /// </summary>
    public class ThanosRulerSpecVolumesProjectedSourcesDownwardAPIArgs : Pulumi.ResourceArgs
    {
        [Input("items")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItemsArgs>? _items;

        /// <summary>
        /// Items is a list of DownwardAPIVolume file
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItemsArgs> Items
        {
            get => _items ?? (_items = new InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItemsArgs>());
            set => _items = value;
        }

        public ThanosRulerSpecVolumesProjectedSourcesDownwardAPIArgs()
        {
        }
    }
}
