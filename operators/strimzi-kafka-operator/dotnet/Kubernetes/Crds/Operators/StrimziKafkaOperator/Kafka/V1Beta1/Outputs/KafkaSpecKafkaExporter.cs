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
    public sealed class KafkaSpecKafkaExporter
    {
        /// <summary>
        /// Enable Sarama logging, a Go client library used by the Kafka Exporter.
        /// </summary>
        public readonly bool EnableSaramaLogging;
        /// <summary>
        /// Regular expression to specify which consumer groups to collect. Default value is `.*`.
        /// </summary>
        public readonly string GroupRegex;
        /// <summary>
        /// The docker image for the pods.
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// Pod liveness check.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterLivenessProbe LivenessProbe;
        /// <summary>
        /// Only log messages with the given severity or above. Valid levels: [`debug`, `info`, `warn`, `error`, `fatal`]. Default log level is `info`.
        /// </summary>
        public readonly string Logging;
        /// <summary>
        /// Pod readiness check.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterReadinessProbe ReadinessProbe;
        /// <summary>
        /// CPU and memory resources to reserve.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterResources Resources;
        /// <summary>
        /// Customization of deployment templates and pods.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterTemplate Template;
        /// <summary>
        /// Regular expression to specify which topics to collect. Default value is `.*`.
        /// </summary>
        public readonly string TopicRegex;

        [OutputConstructor]
        private KafkaSpecKafkaExporter(
            bool enableSaramaLogging,

            string groupRegex,

            string image,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterLivenessProbe livenessProbe,

            string logging,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterReadinessProbe readinessProbe,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterResources resources,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaExporterTemplate template,

            string topicRegex)
        {
            EnableSaramaLogging = enableSaramaLogging;
            GroupRegex = groupRegex;
            Image = image;
            LivenessProbe = livenessProbe;
            Logging = logging;
            ReadinessProbe = readinessProbe;
            Resources = resources;
            Template = template;
            TopicRegex = topicRegex;
        }
    }
}