// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    public class KafkaSpecEntityOperatorTemplatePodTolerationsArgs : Pulumi.ResourceArgs
    {
        [Input("effect")]
        public Input<string>? Effect { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("operator")]
        public Input<string>? Operator { get; set; }

        [Input("tolerationSeconds")]
        public Input<int>? TolerationSeconds { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public KafkaSpecEntityOperatorTemplatePodTolerationsArgs()
        {
        }
    }
}
