// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Yaks.V1Alpha1
{

    public class TestStatusResultsSummaryArgs : Pulumi.ResourceArgs
    {
        [Input("failed", required: true)]
        public Input<int> Failed { get; set; } = null!;

        [Input("passed", required: true)]
        public Input<int> Passed { get; set; } = null!;

        [Input("pending", required: true)]
        public Input<int> Pending { get; set; } = null!;

        [Input("skipped", required: true)]
        public Input<int> Skipped { get; set; } = null!;

        [Input("total", required: true)]
        public Input<int> Total { get; set; } = null!;

        [Input("undefined", required: true)]
        public Input<int> Undefined { get; set; } = null!;

        public TestStatusResultsSummaryArgs()
        {
        }
    }
}