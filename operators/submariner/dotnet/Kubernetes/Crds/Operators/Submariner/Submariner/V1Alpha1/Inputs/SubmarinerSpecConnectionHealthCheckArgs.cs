// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Submariner.V1Alpha1
{

    public class SubmarinerSpecConnectionHealthCheckArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The interval at which health check pings are sent.
        /// </summary>
        [Input("intervalSeconds")]
        public Input<int>? IntervalSeconds { get; set; }

        /// <summary>
        /// The maximum number of packets lost at which the health checker will mark the connection as down.
        /// </summary>
        [Input("maxPacketLossCount")]
        public Input<int>? MaxPacketLossCount { get; set; }

        public SubmarinerSpecConnectionHealthCheckArgs()
        {
        }
    }
}
