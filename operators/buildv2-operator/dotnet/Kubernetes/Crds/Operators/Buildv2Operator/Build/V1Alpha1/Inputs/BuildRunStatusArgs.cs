// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1
{

    /// <summary>
    /// BuildRunStatus defines the observed state of BuildRun
    /// </summary>
    public class BuildRunStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// BuildSpec is the Build Spec of this BuildRun.
        /// </summary>
        [Input("buildSpec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildRunStatusBuildSpecArgs>? BuildSpec { get; set; }

        /// <summary>
        /// CompletionTime is the time the build completed.
        /// </summary>
        [Input("completionTime")]
        public Input<string>? CompletionTime { get; set; }

        /// <summary>
        /// PodName is the name of the pod responsible for executing this task's steps.
        /// </summary>
        [Input("latestTaskRunRef")]
        public Input<string>? LatestTaskRunRef { get; set; }

        /// <summary>
        /// The Succeeded reason of the TaskRun
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// StartTime is the time the build is actually started.
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        /// <summary>
        /// The Succeeded status of the TaskRun
        /// </summary>
        [Input("succeeded")]
        public Input<string>? Succeeded { get; set; }

        public BuildRunStatusArgs()
        {
        }
    }
}
