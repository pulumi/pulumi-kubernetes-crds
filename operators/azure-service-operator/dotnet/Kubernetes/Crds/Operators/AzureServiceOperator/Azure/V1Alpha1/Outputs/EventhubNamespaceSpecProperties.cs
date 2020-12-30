// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class EventhubNamespaceSpecProperties
    {
        public readonly bool IsAutoInflateEnabled;
        public readonly bool KafkaEnabled;
        public readonly int MaximumThroughputUnits;

        [OutputConstructor]
        private EventhubNamespaceSpecProperties(
            bool isAutoInflateEnabled,

            bool kafkaEnabled,

            int maximumThroughputUnits)
        {
            IsAutoInflateEnabled = isAutoInflateEnabled;
            KafkaEnabled = kafkaEnabled;
            MaximumThroughputUnits = maximumThroughputUnits;
        }
    }
}
