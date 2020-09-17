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
    /// A TargetStatus defines the observed status a target.
    /// </summary>
    public class KubernetesTargetStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesTargetStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions of the resource.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesTargetStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1.KubernetesTargetStatusConditionsArgs>());
            set => _conditions = value;
        }

        public KubernetesTargetStatusArgs()
        {
        }
    }
}