// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Velero.V1
{

    [OutputType]
    public sealed class ScheduleSpecTemplateHooksResourcesPost
    {
        /// <summary>
        /// Exec defines an exec hook.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Velero.V1.ScheduleSpecTemplateHooksResourcesPostExec Exec;

        [OutputConstructor]
        private ScheduleSpecTemplateHooksResourcesPost(Pulumi.Kubernetes.Types.Outputs.Velero.V1.ScheduleSpecTemplateHooksResourcesPostExec exec)
        {
            Exec = exec;
        }
    }
}
