// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1
{

    /// <summary>
    /// BuildStatus defines the observed state of Build
    /// </summary>
    public class BuildStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The reason of the registered Build, either an error or succeed message
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// The Register status of the Build
        /// </summary>
        [Input("registered")]
        public Input<string>? Registered { get; set; }

        public BuildStatusArgs()
        {
        }
    }
}
