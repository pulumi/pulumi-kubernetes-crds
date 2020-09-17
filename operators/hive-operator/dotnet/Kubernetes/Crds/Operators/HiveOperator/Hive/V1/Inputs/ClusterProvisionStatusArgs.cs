// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// ClusterProvisionStatus defines the observed state of ClusterProvision.
    /// </summary>
    public class ClusterProvisionStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterProvisionStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions includes more detailed status for the cluster provision
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterProvisionStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterProvisionStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// JobRef is the reference to the job performing the provision.
        /// </summary>
        [Input("jobRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterProvisionStatusJobRefArgs>? JobRef { get; set; }

        public ClusterProvisionStatusArgs()
        {
        }
    }
}
