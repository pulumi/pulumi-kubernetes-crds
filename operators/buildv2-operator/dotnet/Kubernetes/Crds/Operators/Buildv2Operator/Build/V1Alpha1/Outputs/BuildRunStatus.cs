// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1
{

    [OutputType]
    public sealed class BuildRunStatus
    {
        /// <summary>
        /// BuildSpec is the Build Spec of this BuildRun.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpec BuildSpec;
        /// <summary>
        /// CompletionTime is the time the build completed.
        /// </summary>
        public readonly string CompletionTime;
        /// <summary>
        /// PodName is the name of the pod responsible for executing this task's steps.
        /// </summary>
        public readonly string LatestTaskRunRef;
        /// <summary>
        /// The Succeeded reason of the TaskRun
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// StartTime is the time the build is actually started.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// The Succeeded status of the TaskRun
        /// </summary>
        public readonly string Succeeded;

        [OutputConstructor]
        private BuildRunStatus(
            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpec buildSpec,

            string completionTime,

            string latestTaskRunRef,

            string reason,

            string startTime,

            string succeeded)
        {
            BuildSpec = buildSpec;
            CompletionTime = completionTime;
            LatestTaskRunRef = latestTaskRunRef;
            Reason = reason;
            StartTime = startTime;
            Succeeded = succeeded;
        }
    }
}
