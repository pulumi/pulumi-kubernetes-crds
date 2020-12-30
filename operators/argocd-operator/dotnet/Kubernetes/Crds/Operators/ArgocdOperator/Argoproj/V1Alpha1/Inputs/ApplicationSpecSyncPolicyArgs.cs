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
    /// SyncPolicy controls when a sync will be performed
    /// </summary>
    public class ApplicationSpecSyncPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Automated will keep an application synced to the target revision
        /// </summary>
        [Input("automated")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSpecSyncPolicyAutomatedArgs>? Automated { get; set; }

        /// <summary>
        /// Retry controls failed sync retry behavior
        /// </summary>
        [Input("retry")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSpecSyncPolicyRetryArgs>? Retry { get; set; }

        [Input("syncOptions")]
        private InputList<string>? _syncOptions;

        /// <summary>
        /// Options allow you to specify whole app sync-options
        /// </summary>
        public InputList<string> SyncOptions
        {
            get => _syncOptions ?? (_syncOptions = new InputList<string>());
            set => _syncOptions = value;
        }

        public ApplicationSpecSyncPolicyArgs()
        {
        }
    }
}
