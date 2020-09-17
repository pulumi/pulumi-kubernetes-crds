// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// UserConfigStatus defines the observed state of UserConfig
    /// </summary>
    public class UserConfigStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.UserConfigStatusConditionsArgs>? _conditions;

        /// <summary>
        /// ReconcileStatus this is the general status of the main reconciler
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.UserConfigStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.UserConfigStatusConditionsArgs>());
            set => _conditions = value;
        }

        [Input("lockedResourceStatuses")]
        private InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.UserConfigStatusLockedResourceStatusesArgs>>? _lockedResourceStatuses;

        /// <summary>
        /// LockedResourceStatuses contains the reconcile status for each of the managed resources
        /// </summary>
        public InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.UserConfigStatusLockedResourceStatusesArgs>> LockedResourceStatuses
        {
            get => _lockedResourceStatuses ?? (_lockedResourceStatuses = new InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.UserConfigStatusLockedResourceStatusesArgs>>());
            set => _lockedResourceStatuses = value;
        }

        public UserConfigStatusArgs()
        {
        }
    }
}