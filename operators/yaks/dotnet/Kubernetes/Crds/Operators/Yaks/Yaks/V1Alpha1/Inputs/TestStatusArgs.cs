// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Yaks.V1Alpha1
{

    /// <summary>
    /// TestStatus defines the observed state of Test
    /// </summary>
    public class TestStatusArgs : Pulumi.ResourceArgs
    {
        [Input("digest")]
        public Input<string>? Digest { get; set; }

        [Input("errors")]
        public Input<string>? Errors { get; set; }

        /// <summary>
        /// TestPhase
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        [Input("results")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Yaks.V1Alpha1.TestStatusResultsArgs>? Results { get; set; }

        [Input("testID")]
        public Input<string>? TestID { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public TestStatusArgs()
        {
        }
    }
}