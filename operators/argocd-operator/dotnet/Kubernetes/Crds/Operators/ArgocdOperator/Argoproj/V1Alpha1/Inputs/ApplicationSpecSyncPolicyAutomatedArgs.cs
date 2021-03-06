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
    /// Automated will keep an application synced to the target revision
    /// </summary>
    public class ApplicationSpecSyncPolicyAutomatedArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Prune will prune resources automatically as part of automated sync (default: false)
        /// </summary>
        [Input("prune")]
        public Input<bool>? Prune { get; set; }

        /// <summary>
        /// SelfHeal enables auto-syncing if  (default: false)
        /// </summary>
        [Input("selfHeal")]
        public Input<bool>? SelfHeal { get; set; }

        public ApplicationSpecSyncPolicyAutomatedArgs()
        {
        }
    }
}
