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
    public sealed class KafkaConnectSpecTemplateDeployment
    {
        /// <summary>
        /// Metadata applied to the resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectSpecTemplateDeploymentMetadata Metadata;

        [OutputConstructor]
        private KafkaConnectSpecTemplateDeployment(Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaConnectSpecTemplateDeploymentMetadata metadata)
        {
            Metadata = metadata;
        }
    }
}