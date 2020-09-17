// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// UpdateHistory is a single attempted update to the cluster.
    /// </summary>
    public class ClusterDeploymentStatusClusterVersionStatusHistoryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// completionTime, if set, is when the update was fully applied. The update that is currently being applied will have a null completion time. Completion time will always be set for entries that are not the current update (usually to the started time of the next update).
        /// </summary>
        [Input("completionTime", required: true)]
        public Input<string> CompletionTime { get; set; } = null!;

        /// <summary>
        /// image is a container image location that contains the update. This value is always populated.
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        /// <summary>
        /// startedTime is the time at which the update was started.
        /// </summary>
        [Input("startedTime", required: true)]
        public Input<string> StartedTime { get; set; } = null!;

        /// <summary>
        /// state reflects whether the update was fully applied. The Partial state indicates the update is not fully applied, while the Completed state indicates the update was successfully rolled out at least once (all parts of the update successfully applied).
        /// </summary>
        [Input("state", required: true)]
        public Input<string> State { get; set; } = null!;

        /// <summary>
        /// verified indicates whether the provided update was properly verified before it was installed. If this is false the cluster may not be trusted.
        /// </summary>
        [Input("verified", required: true)]
        public Input<bool> Verified { get; set; } = null!;

        /// <summary>
        /// version is a semantic versioning identifying the update version. If the requested image does not define a version, or if a failure occurs retrieving the image, this value may be empty.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ClusterDeploymentStatusClusterVersionStatusHistoryArgs()
        {
        }
    }
}