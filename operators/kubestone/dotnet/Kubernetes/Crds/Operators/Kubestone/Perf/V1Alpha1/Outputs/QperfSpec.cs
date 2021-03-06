// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class QperfSpec
    {
        /// <summary>
        /// ClientConfiguration contains the configuration of the qperf client
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.QperfSpecClientConfiguration ClientConfiguration;
        /// <summary>
        /// Image defines the qperf docker image used for the benchmark
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.QperfSpecImage Image;
        /// <summary>
        /// Options are options for the qperf binary
        /// </summary>
        public readonly string Options;
        /// <summary>
        /// ServerConfiguration contains the configuration of the qperf server
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.QperfSpecServerConfiguration ServerConfiguration;
        /// <summary>
        /// Tests are the tests that we would like to run
        /// </summary>
        public readonly ImmutableArray<string> Tests;

        [OutputConstructor]
        private QperfSpec(
            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.QperfSpecClientConfiguration clientConfiguration,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.QperfSpecImage image,

            string options,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.QperfSpecServerConfiguration serverConfiguration,

            ImmutableArray<string> tests)
        {
            ClientConfiguration = clientConfiguration;
            Image = image;
            Options = options;
            ServerConfiguration = serverConfiguration;
            Tests = tests;
        }
    }
}
