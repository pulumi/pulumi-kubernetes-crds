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
    /// Configuration of target cluster.
    /// </summary>
    public class KafkaMirrorMakerSpecProducerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Flag to set the MirrorMaker to exit on a failed send. Default value is `true`.
        /// </summary>
        [Input("abortOnSendFailure")]
        public Input<bool>? AbortOnSendFailure { get; set; }

        /// <summary>
        /// Authentication configuration for connecting to the cluster.
        /// </summary>
        [Input("authentication")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaMirrorMakerSpecProducerAuthenticationArgs>? Authentication { get; set; }

        /// <summary>
        /// A list of host:port pairs for establishing the initial connection to the Kafka cluster.
        /// </summary>
        [Input("bootstrapServers", required: true)]
        public Input<string> BootstrapServers { get; set; } = null!;

        [Input("config")]
        private InputMap<object>? _config;

        /// <summary>
        /// The MirrorMaker producer config. Properties with the following prefixes cannot be set: ssl., bootstrap.servers, sasl., security., interceptor.classes (with the exception of: ssl.endpoint.identification.algorithm, ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols).
        /// </summary>
        public InputMap<object> Config
        {
            get => _config ?? (_config = new InputMap<object>());
            set => _config = value;
        }

        /// <summary>
        /// TLS configuration for connecting MirrorMaker to the cluster.
        /// </summary>
        [Input("tls")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaMirrorMakerSpecProducerTlsArgs>? Tls { get; set; }

        public KafkaMirrorMakerSpecProducerArgs()
        {
        }
    }
}