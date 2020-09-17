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
    /// Operation is the original requested operation
    /// </summary>
    public class ApplicationStatusOperationStateOperationArgs : Pulumi.ResourceArgs
    {
        [Input("info")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationInfoArgs>? _info;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationInfoArgs> Info
        {
            get => _info ?? (_info = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationInfoArgs>());
            set => _info = value;
        }

        /// <summary>
        /// OperationInitiator holds information about the operation initiator
        /// </summary>
        [Input("initiatedBy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationInitiatedByArgs>? InitiatedBy { get; set; }

        /// <summary>
        /// SyncOperation contains sync operation details.
        /// </summary>
        [Input("sync")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncArgs>? Sync { get; set; }

        public ApplicationStatusOperationStateOperationArgs()
        {
        }
    }
}
