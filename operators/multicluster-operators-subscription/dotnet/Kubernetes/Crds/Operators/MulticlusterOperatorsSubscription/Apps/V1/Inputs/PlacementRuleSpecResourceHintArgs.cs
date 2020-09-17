// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1
{

    /// <summary>
    /// Select Resource
    /// </summary>
    public class PlacementRuleSpecResourceHintArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SelectionOrder is the type for Nodes
        /// </summary>
        [Input("order")]
        public Input<string>? Order { get; set; }

        /// <summary>
        /// ResourceType defines types can be sorted
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public PlacementRuleSpecResourceHintArgs()
        {
        }
    }
}