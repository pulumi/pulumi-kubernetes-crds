// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecIngesterVolumesDownwardAPIItemsArgs : Pulumi.ResourceArgs
    {
        [Input("fieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngesterVolumesDownwardAPIItemsFieldRefArgs>? FieldRef { get; set; }

        [Input("mode")]
        public Input<int>? Mode { get; set; }

        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("resourceFieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngesterVolumesDownwardAPIItemsResourceFieldRefArgs>? ResourceFieldRef { get; set; }

        public JaegerSpecIngesterVolumesDownwardAPIItemsArgs()
        {
        }
    }
}
