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
    /// ResourceResult holds the operation result details of a specific resource
    /// </summary>
    public class ApplicationStatusOperationStateSyncResultResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("group", required: true)]
        public Input<string> Group { get; set; } = null!;

        /// <summary>
        /// the state of any operation associated with this resource OR hook note: can contain values for non-hook resources
        /// </summary>
        [Input("hookPhase")]
        public Input<string>? HookPhase { get; set; }

        /// <summary>
        /// the type of the hook, empty for non-hook resources
        /// </summary>
        [Input("hookType")]
        public Input<string>? HookType { get; set; }

        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        /// <summary>
        /// message for the last sync OR operation
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        /// <summary>
        /// the final result of the sync, this is be empty if the resources is yet to be applied/pruned and is always zero-value for hooks
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// indicates the particular phase of the sync that this is for
        /// </summary>
        [Input("syncPhase")]
        public Input<string>? SyncPhase { get; set; }

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public ApplicationStatusOperationStateSyncResultResourcesArgs()
        {
        }
    }
}