// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Charts.V1
{

    [OutputType]
    public sealed class XlSpecPlan-OrchestratorResources
    {
        /// <summary>
        /// component limits
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecPlan-OrchestratorResourcesLimits Limits;

        [OutputConstructor]
        private XlSpecPlan-OrchestratorResources(Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecPlan-OrchestratorResourcesLimits limits)
        {
            Limits = limits;
        }
    }
}
