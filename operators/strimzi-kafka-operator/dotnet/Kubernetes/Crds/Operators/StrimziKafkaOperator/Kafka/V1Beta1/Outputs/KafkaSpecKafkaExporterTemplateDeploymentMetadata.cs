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
    public sealed class KafkaSpecKafkaExporterTemplateDeploymentMetadata
    {
        /// <summary>
        /// Annotations added to the resource template. Can be applied to different resources such as `StatefulSets`, `Deployments`, `Pods`, and `Services`.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Annotations;
        /// <summary>
        /// Labels added to the resource template. Can be applied to different resources such as `StatefulSets`, `Deployments`, `Pods`, and `Services`.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Labels;

        [OutputConstructor]
        private KafkaSpecKafkaExporterTemplateDeploymentMetadata(
            ImmutableDictionary<string, object> annotations,

            ImmutableDictionary<string, object> labels)
        {
            Annotations = annotations;
            Labels = labels;
        }
    }
}
