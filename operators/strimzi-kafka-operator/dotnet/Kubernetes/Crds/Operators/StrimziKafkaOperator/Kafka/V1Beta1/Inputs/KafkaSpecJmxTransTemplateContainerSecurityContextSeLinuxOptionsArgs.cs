// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    public class KafkaSpecJmxTransTemplateContainerSecurityContextSeLinuxOptionsArgs : Pulumi.ResourceArgs
    {
        [Input("level")]
        public Input<string>? Level { get; set; }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("user")]
        public Input<string>? User { get; set; }

        public KafkaSpecJmxTransTemplateContainerSecurityContextSeLinuxOptionsArgs()
        {
        }
    }
}
