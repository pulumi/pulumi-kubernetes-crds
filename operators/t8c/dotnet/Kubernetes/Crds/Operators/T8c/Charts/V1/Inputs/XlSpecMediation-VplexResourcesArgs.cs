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
    public class XlSpecMediation-VplexResourcesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// component limits
        /// </summary>
        [Input("limits")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-VplexResourcesLimitsArgs>? Limits { get; set; }

        public XlSpecMediation-VplexResourcesArgs()
        {
        }
    }
}
