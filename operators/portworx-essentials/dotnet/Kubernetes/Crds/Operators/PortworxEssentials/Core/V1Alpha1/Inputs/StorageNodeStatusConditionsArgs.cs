// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1
{

    public class StorageNodeStatusConditionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Reason is the human readable message indicating details about the current state of the cluster.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// Status of the condition.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Type of the condition.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public StorageNodeStatusConditionsArgs()
        {
        }
    }
}
