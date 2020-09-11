// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    /// <summary>
    /// ResourceSpec --
    /// </summary>
    public class BuildSpecTasksBuilderResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("compression")]
        public Input<bool>? Compression { get; set; }

        [Input("content")]
        public Input<string>? Content { get; set; }

        [Input("contentKey")]
        public Input<string>? ContentKey { get; set; }

        [Input("contentRef")]
        public Input<string>? ContentRef { get; set; }

        [Input("mountPath")]
        public Input<string>? MountPath { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ResourceType --
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public BuildSpecTasksBuilderResourcesArgs()
        {
        }
    }
}
