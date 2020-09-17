// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1
{

    /// <summary>
    /// BenchmarkStatus describes the current state of the benchmark
    /// </summary>
    public class SysbenchStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Completed shows the state of completion
        /// </summary>
        [Input("completed", required: true)]
        public Input<bool> Completed { get; set; } = null!;

        /// <summary>
        /// Running shows the state of execution
        /// </summary>
        [Input("running", required: true)]
        public Input<bool> Running { get; set; } = null!;

        public SysbenchStatusArgs()
        {
        }
    }
}
