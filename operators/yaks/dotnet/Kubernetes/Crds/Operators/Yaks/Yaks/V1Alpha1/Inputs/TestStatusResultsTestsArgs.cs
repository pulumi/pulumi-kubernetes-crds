// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Yaks.V1Alpha1
{

    public class TestStatusResultsTestsArgs : Pulumi.ResourceArgs
    {
        [Input("classname")]
        public Input<string>? Classname { get; set; }

        [Input("errorMessage")]
        public Input<string>? ErrorMessage { get; set; }

        [Input("errorType")]
        public Input<string>? ErrorType { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public TestStatusResultsTestsArgs()
        {
        }
    }
}