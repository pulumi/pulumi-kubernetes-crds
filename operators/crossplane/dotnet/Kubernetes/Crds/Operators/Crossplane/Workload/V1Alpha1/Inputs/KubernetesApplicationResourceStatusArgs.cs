// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1
{

    /// <summary>
    /// KubernetesApplicationResourceStatus represents the observed state of a KubernetesApplicationResource.
    /// </summary>
    public class KubernetesApplicationResourceStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A ConditionedStatus reflects the observed status of a resource. Only one condition of each type may exist.
        /// </summary>
        [Input("conditionedStatus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationResourceStatusConditionedStatusArgs>? ConditionedStatus { get; set; }

        /// <summary>
        /// Remote status of the resource templated by this application resource.
        /// </summary>
        [Input("remote")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationResourceStatusRemoteArgs>? Remote { get; set; }

        /// <summary>
        /// State of the application.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public KubernetesApplicationResourceStatusArgs()
        {
        }
    }
}
