// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    public class XlSpecAppinsightsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable Azure App Insights mediation
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public XlSpecAppinsightsArgs()
        {
        }
    }
}
