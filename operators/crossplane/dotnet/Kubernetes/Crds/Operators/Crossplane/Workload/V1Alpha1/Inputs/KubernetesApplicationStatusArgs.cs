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
    /// KubernetesApplicationStatus represents the observed state of a KubernetesApplication.
    /// </summary>
    public class KubernetesApplicationStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A ConditionedStatus reflects the observed status of a resource. Only one condition of each type may exist.
        /// </summary>
        [Input("conditionedStatus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesApplicationStatusConditionedStatusArgs>? ConditionedStatus { get; set; }

        /// <summary>
        /// Desired resources of this application, i.e. the number of resources that match this application's resource selector.
        /// </summary>
        [Input("desiredResources")]
        public Input<int>? DesiredResources { get; set; }

        /// <summary>
        /// State of the application.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Submitted resources of this workload, i.e. the subset of desired resources that have been successfully submitted to their scheduled Kubernetes cluster.
        /// </summary>
        [Input("submittedResources")]
        public Input<int>? SubmittedResources { get; set; }

        public KubernetesApplicationStatusArgs()
        {
        }
    }
}
