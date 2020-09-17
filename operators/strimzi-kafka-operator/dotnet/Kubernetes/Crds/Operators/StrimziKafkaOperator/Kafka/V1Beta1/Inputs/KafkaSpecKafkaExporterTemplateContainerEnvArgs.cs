// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    public class KafkaSpecKafkaExporterTemplateContainerEnvArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The environment variable key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The environment variable value.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public KafkaSpecKafkaExporterTemplateContainerEnvArgs()
        {
        }
    }
}