// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// Automatic updates configuration
    /// </summary>
    public class NexusSpecAutomaticUpdateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether or not the Operator should perform automatic updates. Defaults to `false` (auto updates are enabled). Is set to `false` if `spec.image` is not empty and is different from the default community image.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// The Nexus image minor version the deployment should stay in. If left blank and automatic updates are enabled the latest minor is set.
        /// </summary>
        [Input("minorVersion")]
        public Input<int>? MinorVersion { get; set; }

        public NexusSpecAutomaticUpdateArgs()
        {
        }
    }
}
