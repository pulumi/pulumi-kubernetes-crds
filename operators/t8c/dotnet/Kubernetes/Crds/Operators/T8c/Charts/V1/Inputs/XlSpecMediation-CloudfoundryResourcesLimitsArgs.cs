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
    /// component limits
    /// </summary>
    public class XlSpecMediation-CloudfoundryResourcesLimitsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// component memory limits
        /// </summary>
        [Input("memory")]
        public Input<string>? Memory { get; set; }

        public XlSpecMediation-CloudfoundryResourcesLimitsArgs()
        {
        }
    }
}
