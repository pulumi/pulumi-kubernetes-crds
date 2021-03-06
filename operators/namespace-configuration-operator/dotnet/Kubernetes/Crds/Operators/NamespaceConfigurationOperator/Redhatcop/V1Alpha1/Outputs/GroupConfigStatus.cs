// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class GroupConfigStatus
    {
        /// <summary>
        /// ReconcileStatus this is the general status of the main reconciler
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupConfigStatusConditions> Conditions;
        /// <summary>
        /// LockedResourceStatuses contains the reconcile status for each of the managed resources
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupConfigStatusLockedResourceStatuses>> LockedResourceStatuses;

        [OutputConstructor]
        private GroupConfigStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupConfigStatusConditions> conditions,

            ImmutableDictionary<string, ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupConfigStatusLockedResourceStatuses>> lockedResourceStatuses)
        {
            Conditions = conditions;
            LockedResourceStatuses = lockedResourceStatuses;
        }
    }
}
