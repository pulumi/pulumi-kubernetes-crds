// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecTopicOperatorResources
    {
        public readonly ImmutableDictionary<string, object> Limits;
        public readonly ImmutableDictionary<string, object> Requests;

        [OutputConstructor]
        private KafkaSpecTopicOperatorResources(
            ImmutableDictionary<string, object> limits,

            ImmutableDictionary<string, object> requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
