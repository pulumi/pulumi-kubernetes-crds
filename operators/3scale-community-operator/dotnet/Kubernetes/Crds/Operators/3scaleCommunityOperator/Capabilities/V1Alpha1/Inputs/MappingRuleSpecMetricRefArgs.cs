// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1
{

    public class MappingRuleSpecMetricRefArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("fieldPath")]
        public Input<string>? FieldPath { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("resourceVersion")]
        public Input<string>? ResourceVersion { get; set; }

        [Input("uid")]
        public Input<string>? Uid { get; set; }

        public MappingRuleSpecMetricRefArgs()
        {
        }
    }
}
