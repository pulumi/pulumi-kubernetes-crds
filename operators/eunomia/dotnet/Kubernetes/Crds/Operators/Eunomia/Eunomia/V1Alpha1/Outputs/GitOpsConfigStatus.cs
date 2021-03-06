// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Eunomia.V1Alpha1
{

    [OutputType]
    public sealed class GitOpsConfigStatus
    {
        public readonly string CompletionTime;
        public readonly string LastScheduleTime;
        public readonly string Message;
        public readonly string StartTime;
        public readonly string State;

        [OutputConstructor]
        private GitOpsConfigStatus(
            string completionTime,

            string lastScheduleTime,

            string message,

            string startTime,

            string state)
        {
            CompletionTime = completionTime;
            LastScheduleTime = lastScheduleTime;
            Message = message;
            StartTime = startTime;
            State = state;
        }
    }
}
