// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// ApplicationStatus contains information about application sync, health status
    /// </summary>
    public class ApplicationStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusConditionsArgs>? _conditions;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusConditionsArgs>());
            set => _conditions = value;
        }

        [Input("health")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHealthArgs>? Health { get; set; }

        [Input("history")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistoryArgs>? _history;

        /// <summary>
        /// RevisionHistories is a array of history, oldest first and newest last
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistoryArgs> History
        {
            get => _history ?? (_history = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistoryArgs>());
            set => _history = value;
        }

        /// <summary>
        /// ObservedAt indicates when the application state was updated without querying latest git state Deprecated: controller no longer updates ObservedAt field
        /// </summary>
        [Input("observedAt")]
        public Input<string>? ObservedAt { get; set; }

        /// <summary>
        /// OperationState contains information about state of currently performing operation on application.
        /// </summary>
        [Input("operationState")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateArgs>? OperationState { get; set; }

        /// <summary>
        /// ReconciledAt indicates when the application state was reconciled using the latest git version
        /// </summary>
        [Input("reconciledAt")]
        public Input<string>? ReconciledAt { get; set; }

        [Input("resources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusResourcesArgs>? _resources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusResourcesArgs> Resources
        {
            get => _resources ?? (_resources = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusResourcesArgs>());
            set => _resources = value;
        }

        [Input("sourceType")]
        public Input<string>? SourceType { get; set; }

        [Input("summary")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSummaryArgs>? Summary { get; set; }

        /// <summary>
        /// SyncStatus is a comparison result of application spec and deployed application.
        /// </summary>
        [Input("sync")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncArgs>? Sync { get; set; }

        public ApplicationStatusArgs()
        {
        }
    }
}
