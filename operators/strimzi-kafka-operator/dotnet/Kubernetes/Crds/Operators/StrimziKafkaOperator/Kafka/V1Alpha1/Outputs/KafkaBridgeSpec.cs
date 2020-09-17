// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaBridgeSpec
    {
        /// <summary>
        /// Authentication configuration for connecting to the cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecAuthentication Authentication;
        /// <summary>
        /// A list of host:port pairs for establishing the initial connection to the Kafka cluster.
        /// </summary>
        public readonly string BootstrapServers;
        /// <summary>
        /// Kafka consumer related configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecConsumer Consumer;
        /// <summary>
        /// Enable the metrics for the Kafka Bridge. Default is false.
        /// </summary>
        public readonly bool EnableMetrics;
        /// <summary>
        /// The HTTP related configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecHttp Http;
        /// <summary>
        /// The docker image for the pods.
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// **Currently not supported** JVM Options for pods.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecJvmOptions JvmOptions;
        /// <summary>
        /// Pod liveness checking.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecLivenessProbe LivenessProbe;
        /// <summary>
        /// Logging configuration for Kafka Bridge.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecLogging Logging;
        /// <summary>
        /// Kafka producer related configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecProducer Producer;
        /// <summary>
        /// Pod readiness checking.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecReadinessProbe ReadinessProbe;
        /// <summary>
        /// The number of pods in the `Deployment`.
        /// </summary>
        public readonly int Replicas;
        /// <summary>
        /// CPU and memory resources to reserve.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecResources Resources;
        /// <summary>
        /// Template for Kafka Bridge resources. The template allows users to specify how is the `Deployment` and `Pods` generated.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecTemplate Template;
        /// <summary>
        /// TLS configuration for connecting Kafka Bridge to the cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecTls Tls;
        /// <summary>
        /// The configuration of tracing in Kafka Bridge.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecTracing Tracing;

        [OutputConstructor]
        private KafkaBridgeSpec(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecAuthentication authentication,

            string bootstrapServers,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecConsumer consumer,

            bool enableMetrics,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecHttp http,

            string image,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecJvmOptions jvmOptions,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecLivenessProbe livenessProbe,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecLogging logging,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecProducer producer,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecReadinessProbe readinessProbe,

            int replicas,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecResources resources,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecTemplate template,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecTls tls,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecTracing tracing)
        {
            Authentication = authentication;
            BootstrapServers = bootstrapServers;
            Consumer = consumer;
            EnableMetrics = enableMetrics;
            Http = http;
            Image = image;
            JvmOptions = jvmOptions;
            LivenessProbe = livenessProbe;
            Logging = logging;
            Producer = producer;
            ReadinessProbe = readinessProbe;
            Replicas = replicas;
            Resources = resources;
            Template = template;
            Tls = tls;
            Tracing = tracing;
        }
    }
}
