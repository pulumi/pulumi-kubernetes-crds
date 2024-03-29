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
    /// DownwardAPIVolumeFile represents information to create the file containing the pod field
    /// </summary>
    public class AlertmanagerSpecVolumesProjectedSourcesDownwardAPIItemsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.
        /// </summary>
        [Input("fieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.AlertmanagerSpecVolumesProjectedSourcesDownwardAPIItemsFieldRefArgs>? FieldRef { get; set; }

        /// <summary>
        /// Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Input("mode")]
        public Input<int>? Mode { get; set; }

        /// <summary>
        /// Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.
        /// </summary>
        [Input("resourceFieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.AlertmanagerSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRefArgs>? ResourceFieldRef { get; set; }

        public AlertmanagerSpecVolumesProjectedSourcesDownwardAPIItemsArgs()
        {
        }
    }
}
