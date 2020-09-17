// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1
{

    /// <summary>
    /// The actual state of the Agent as an extended daemonset
    /// </summary>
    public class DatadogAgentStatusAgentArgs : Pulumi.ResourceArgs
    {
        [Input("available", required: true)]
        public Input<int> Available { get; set; } = null!;

        [Input("current", required: true)]
        public Input<int> Current { get; set; } = null!;

        [Input("currentHash")]
        public Input<string>? CurrentHash { get; set; }

        /// <summary>
        /// DaemonsetName corresponds to the name of the created DaemonSet
        /// </summary>
        [Input("daemonsetName")]
        public Input<string>? DaemonsetName { get; set; }

        [Input("desired", required: true)]
        public Input<int> Desired { get; set; } = null!;

        [Input("lastUpdate")]
        public Input<string>? LastUpdate { get; set; }

        [Input("ready", required: true)]
        public Input<int> Ready { get; set; } = null!;

        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("upToDate", required: true)]
        public Input<int> UpToDate { get; set; } = null!;

        public DatadogAgentStatusAgentArgs()
        {
        }
    }
}