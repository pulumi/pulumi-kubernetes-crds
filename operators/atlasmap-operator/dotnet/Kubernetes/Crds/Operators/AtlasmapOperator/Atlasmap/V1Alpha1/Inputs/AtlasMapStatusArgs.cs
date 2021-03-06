// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Atlasmap.V1Alpha1
{

    /// <summary>
    /// AtlasMapStatus defines the observed state of AtlasMap
    /// </summary>
    public class AtlasMapStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL where AtlasMap can be accessed
        /// </summary>
        [Input("URL")]
        public Input<string>? URL { get; set; }

        /// <summary>
        /// The container image that AtlasMap is using
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// The current phase that the AtlasMap resource is in
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        public AtlasMapStatusArgs()
        {
        }
    }
}
