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
    public sealed class KafkaSpecCruiseControlTemplateDeployment
    {
        /// <summary>
        /// Metadata applied to the resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateDeploymentMetadata Metadata;

        [OutputConstructor]
        private KafkaSpecCruiseControlTemplateDeployment(Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateDeploymentMetadata metadata)
        {
            Metadata = metadata;
        }
    }
}
