// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1
{

    [OutputType]
    public sealed class KubernetesApplicationStatus
    {
        /// <summary>
        /// A ConditionedStatus reflects the observed status of a resource. Only one condition of each type may exist.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesApplicationStatusConditionedStatus ConditionedStatus;
        /// <summary>
        /// Desired resources of this application, i.e. the number of resources that match this application's resource selector.
        /// </summary>
        public readonly int DesiredResources;
        /// <summary>
        /// State of the application.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Submitted resources of this workload, i.e. the subset of desired resources that have been successfully submitted to their scheduled Kubernetes cluster.
        /// </summary>
        public readonly int SubmittedResources;

        [OutputConstructor]
        private KubernetesApplicationStatus(
            Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesApplicationStatusConditionedStatus conditionedStatus,

            int desiredResources,

            string state,

            int submittedResources)
        {
            ConditionedStatus = conditionedStatus;
            DesiredResources = desiredResources;
            State = state;
            SubmittedResources = submittedResources;
        }
    }
}