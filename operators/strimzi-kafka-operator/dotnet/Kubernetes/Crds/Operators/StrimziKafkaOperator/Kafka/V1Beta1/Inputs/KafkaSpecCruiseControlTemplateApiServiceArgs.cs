// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    /// <summary>
    /// Template for Cruise Control API `Service`.
    /// </summary>
    public class KafkaSpecCruiseControlTemplateApiServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Metadata applied to the resource.
        /// </summary>
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplateApiServiceMetadataArgs>? Metadata { get; set; }

        public KafkaSpecCruiseControlTemplateApiServiceArgs()
        {
        }
    }
}
