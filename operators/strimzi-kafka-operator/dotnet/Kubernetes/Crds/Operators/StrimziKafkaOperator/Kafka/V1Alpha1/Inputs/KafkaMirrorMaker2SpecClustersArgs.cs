// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    public class KafkaMirrorMaker2SpecClustersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alias used to reference the Kafka cluster.
        /// </summary>
        [Input("alias", required: true)]
        public Input<string> Alias { get; set; } = null!;

        /// <summary>
        /// Authentication configuration for connecting to the cluster.
        /// </summary>
        [Input("authentication")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecClustersAuthenticationArgs>? Authentication { get; set; }

        /// <summary>
        /// A comma-separated list of `host:port` pairs for establishing the connection to the Kafka cluster.
        /// </summary>
        [Input("bootstrapServers", required: true)]
        public Input<string> BootstrapServers { get; set; } = null!;

        [Input("config")]
        private InputMap<object>? _config;

        /// <summary>
        /// The MirrorMaker 2.0 cluster config. Properties with the following prefixes cannot be set: ssl., sasl., security., listeners, plugin.path, rest., bootstrap.servers, consumer.interceptor.classes, producer.interceptor.classes (with the exception of: ssl.endpoint.identification.algorithm, ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols).
        /// </summary>
        public InputMap<object> Config
        {
            get => _config ?? (_config = new InputMap<object>());
            set => _config = value;
        }

        /// <summary>
        /// TLS configuration for connecting MirrorMaker 2.0 connectors to a cluster.
        /// </summary>
        [Input("tls")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecClustersTlsArgs>? Tls { get; set; }

        public KafkaMirrorMaker2SpecClustersArgs()
        {
        }
    }
}
