// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Beta1
{

    /// <summary>
    /// Link contains information about an URL to surface documentation, dashboards, etc.
    /// </summary>
    public class ApplicationSpecDescriptorLinksArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description is human readable content explaining the purpose of the link.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Url typically points at a website address.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public ApplicationSpecDescriptorLinksArgs()
        {
        }
    }
}
