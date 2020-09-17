// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2
{

    /// <summary>
    /// Items for all in one resources secrets, configmaps, and downward API
    /// </summary>
    public class SearchHeadClusterSpecVolumesProjectedArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Mode bits to use on created files by default. Must be a value between 0 and 0777. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Input("defaultMode")]
        public Input<int>? DefaultMode { get; set; }

        [Input("sources", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SearchHeadClusterSpecVolumesProjectedSourcesArgs>? _sources;

        /// <summary>
        /// list of volume projections
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SearchHeadClusterSpecVolumesProjectedSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SearchHeadClusterSpecVolumesProjectedSourcesArgs>());
            set => _sources = value;
        }

        public SearchHeadClusterSpecVolumesProjectedArgs()
        {
        }
    }
}
