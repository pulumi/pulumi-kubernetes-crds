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
    /// QperfSpec defines the Qperf Benchmark Stone which consist of server deployment with service definition and client pod.
    /// </summary>
    public class QperfSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ClientConfiguration contains the configuration of the qperf client
        /// </summary>
        [Input("clientConfiguration")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.QperfSpecClientConfigurationArgs>? ClientConfiguration { get; set; }

        /// <summary>
        /// Image defines the qperf docker image used for the benchmark
        /// </summary>
        [Input("image", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.QperfSpecImageArgs> Image { get; set; } = null!;

        /// <summary>
        /// Options are options for the qperf binary
        /// </summary>
        [Input("options")]
        public Input<string>? Options { get; set; }

        /// <summary>
        /// ServerConfiguration contains the configuration of the qperf server
        /// </summary>
        [Input("serverConfiguration")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.QperfSpecServerConfigurationArgs>? ServerConfiguration { get; set; }

        [Input("tests", required: true)]
        private InputList<string>? _tests;

        /// <summary>
        /// Tests are the tests that we would like to run
        /// </summary>
        public InputList<string> Tests
        {
            get => _tests ?? (_tests = new InputList<string>());
            set => _tests = value;
        }

        public QperfSpecArgs()
        {
        }
    }
}
