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
    /// Operation contains requested operation parameters.
    /// </summary>
    public class ApplicationOperationArgs : Pulumi.ResourceArgs
    {
        [Input("info")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationOperationInfoArgs>? _info;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationOperationInfoArgs> Info
        {
            get => _info ?? (_info = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationOperationInfoArgs>());
            set => _info = value;
        }

        /// <summary>
        /// OperationInitiator holds information about the operation initiator
        /// </summary>
        [Input("initiatedBy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationOperationInitiatedByArgs>? InitiatedBy { get; set; }

        /// <summary>
        /// Retry controls failed sync retry behavior
        /// </summary>
        [Input("retry")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationOperationRetryArgs>? Retry { get; set; }

        /// <summary>
        /// SyncOperation contains sync operation details.
        /// </summary>
        [Input("sync")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationOperationSyncArgs>? Sync { get; set; }

        public ApplicationOperationArgs()
        {
        }
    }
}
