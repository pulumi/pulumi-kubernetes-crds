// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    /// <summary>
    /// component resource configuration
    /// </summary>
    public class XlSpecMediation-Hpe3parResourcesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// component limits
        /// </summary>
        [Input("limits")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-Hpe3parResourcesLimitsArgs>? Limits { get; set; }

        public XlSpecMediation-Hpe3parResourcesArgs()
        {
        }
    }
}
