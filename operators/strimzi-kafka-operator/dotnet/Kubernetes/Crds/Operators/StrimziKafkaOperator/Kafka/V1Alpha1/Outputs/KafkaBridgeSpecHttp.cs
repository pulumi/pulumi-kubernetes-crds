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
    public sealed class KafkaBridgeSpecHttp
    {
        /// <summary>
        /// CORS configuration for the HTTP Bridge.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecHttpCors Cors;
        /// <summary>
        /// The port which is the server listening on.
        /// </summary>
        public readonly int Port;

        [OutputConstructor]
        private KafkaBridgeSpecHttp(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecHttpCors cors,

            int port)
        {
            Cors = cors;
            Port = port;
        }
    }
}
