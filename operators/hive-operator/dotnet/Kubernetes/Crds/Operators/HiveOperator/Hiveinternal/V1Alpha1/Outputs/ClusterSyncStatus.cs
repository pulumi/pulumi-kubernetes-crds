// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hiveinternal.V1Alpha1
{

    [OutputType]
    public sealed class ClusterSyncStatus
    {
        /// <summary>
        /// Conditions is a list of conditions associated with syncing to the cluster.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hiveinternal.V1Alpha1.ClusterSyncStatusConditions> Conditions;
        /// <summary>
        /// FirstSuccessTime is the time we first successfully applied all (selector)syncsets to a cluster.
        /// </summary>
        public readonly string FirstSuccessTime;
        /// <summary>
        /// SelectorSyncSets is the sync status of all of the SelectorSyncSets for the cluster.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hiveinternal.V1Alpha1.ClusterSyncStatusSelectorSyncSets> SelectorSyncSets;
        /// <summary>
        /// SyncSets is the sync status of all of the SyncSets for the cluster.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hiveinternal.V1Alpha1.ClusterSyncStatusSyncSets> SyncSets;

        [OutputConstructor]
        private ClusterSyncStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hiveinternal.V1Alpha1.ClusterSyncStatusConditions> conditions,

            string firstSuccessTime,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hiveinternal.V1Alpha1.ClusterSyncStatusSelectorSyncSets> selectorSyncSets,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hiveinternal.V1Alpha1.ClusterSyncStatusSyncSets> syncSets)
        {
            Conditions = conditions;
            FirstSuccessTime = firstSuccessTime;
            SelectorSyncSets = selectorSyncSets;
            SyncSets = syncSets;
        }
    }
}
