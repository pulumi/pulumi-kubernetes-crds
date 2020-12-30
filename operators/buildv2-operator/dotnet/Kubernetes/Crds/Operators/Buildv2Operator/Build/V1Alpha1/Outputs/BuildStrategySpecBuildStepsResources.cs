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
    public sealed class BuildStrategySpecBuildStepsResources
    {
        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildStrategySpecBuildStepsResourcesLimits> Limits;
        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildStrategySpecBuildStepsResourcesRequests> Requests;

        [OutputConstructor]
        private BuildStrategySpecBuildStepsResources(
            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildStrategySpecBuildStepsResourcesLimits> limits,

            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildStrategySpecBuildStepsResourcesRequests> requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
