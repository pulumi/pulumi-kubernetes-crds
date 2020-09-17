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
    public sealed class KafkaMirrorMaker2SpecClusters
    {
        /// <summary>
        /// Alias used to reference the Kafka cluster.
        /// </summary>
        public readonly string Alias;
        /// <summary>
        /// Authentication configuration for connecting to the cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecClustersAuthentication Authentication;
        /// <summary>
        /// A comma-separated list of `host:port` pairs for establishing the connection to the Kafka cluster.
        /// </summary>
        public readonly string BootstrapServers;
        /// <summary>
        /// The MirrorMaker 2.0 cluster config. Properties with the following prefixes cannot be set: ssl., sasl., security., listeners, plugin.path, rest., bootstrap.servers, consumer.interceptor.classes, producer.interceptor.classes (with the exception of: ssl.endpoint.identification.algorithm, ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols).
        /// </summary>
        public readonly ImmutableDictionary<string, object> Config;
        /// <summary>
        /// TLS configuration for connecting MirrorMaker 2.0 connectors to a cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecClustersTls Tls;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecClusters(
            string alias,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecClustersAuthentication authentication,

            string bootstrapServers,

            ImmutableDictionary<string, object> config,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecClustersTls tls)
        {
            Alias = alias;
            Authentication = authentication;
            BootstrapServers = bootstrapServers;
            Config = config;
            Tls = tls;
        }
    }
}
