// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationStatus
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusConditions> Conditions;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusHealth Health;
        /// <summary>
        /// RevisionHistories is a array of history, oldest first and newest last
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusHistory> History;
        /// <summary>
        /// ObservedAt indicates when the application state was updated without querying latest git state Deprecated: controller no longer updates ObservedAt field
        /// </summary>
        public readonly string ObservedAt;
        /// <summary>
        /// OperationState contains information about state of currently performing operation on application.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationState OperationState;
        /// <summary>
        /// ReconciledAt indicates when the application state was reconciled using the latest git version
        /// </summary>
        public readonly string ReconciledAt;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusResources> Resources;
        public readonly string SourceType;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSummary Summary;
        /// <summary>
        /// SyncStatus is a comparison result of application spec and deployed application.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSync Sync;

        [OutputConstructor]
        private ApplicationStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusConditions> conditions,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusHealth health,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusHistory> history,

            string observedAt,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationState operationState,

            string reconciledAt,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusResources> resources,

            string sourceType,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSummary summary,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSync sync)
        {
            Conditions = conditions;
            Health = health;
            History = history;
            ObservedAt = observedAt;
            OperationState = operationState;
            ReconciledAt = reconciledAt;
            Resources = resources;
            SourceType = sourceType;
            Summary = summary;
            Sync = sync;
        }
    }
}
