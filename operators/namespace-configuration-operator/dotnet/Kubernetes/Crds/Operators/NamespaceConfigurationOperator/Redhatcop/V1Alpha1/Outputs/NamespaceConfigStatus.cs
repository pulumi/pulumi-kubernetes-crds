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
    public sealed class NamespaceConfigStatus
    {
        /// <summary>
        /// ReconcileStatus this is the general status of the main reconciler
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.NamespaceConfigStatusConditions> Conditions;
        /// <summary>
        /// LockedResourceStatuses contains the reconcile status for each of the managed resources
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.NamespaceConfigStatusLockedResourceStatuses>> LockedResourceStatuses;

        [OutputConstructor]
        private NamespaceConfigStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.NamespaceConfigStatusConditions> conditions,

            ImmutableDictionary<string, ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.NamespaceConfigStatusLockedResourceStatuses>> lockedResourceStatuses)
        {
            Conditions = conditions;
            LockedResourceStatuses = lockedResourceStatuses;
        }
    }
}
