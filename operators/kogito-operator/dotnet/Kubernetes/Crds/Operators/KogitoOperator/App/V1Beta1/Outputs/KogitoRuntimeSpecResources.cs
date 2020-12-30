// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Beta1
{

    [OutputType]
    public sealed class KogitoRuntimeSpecResources
    {
        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeSpecResourcesLimits> Limits;
        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeSpecResourcesRequests> Requests;

        [OutputConstructor]
        private KogitoRuntimeSpecResources(
            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeSpecResourcesLimits> limits,

            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeSpecResourcesRequests> requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
