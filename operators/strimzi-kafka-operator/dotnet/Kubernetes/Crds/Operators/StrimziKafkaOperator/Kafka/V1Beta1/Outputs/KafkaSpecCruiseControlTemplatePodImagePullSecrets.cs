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
    public sealed class KafkaSpecCruiseControlTemplatePodImagePullSecrets
    {
        public readonly string Name;

        [OutputConstructor]
        private KafkaSpecCruiseControlTemplatePodImagePullSecrets(string name)
        {
            Name = name;
        }
    }
}