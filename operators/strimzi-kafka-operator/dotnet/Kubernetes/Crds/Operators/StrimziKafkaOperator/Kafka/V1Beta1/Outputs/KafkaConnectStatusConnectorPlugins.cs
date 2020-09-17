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
    public sealed class KafkaConnectStatusConnectorPlugins
    {
        /// <summary>
        /// The class of the connector plugin.
        /// </summary>
        public readonly string Class;
        /// <summary>
        /// The type of the connector plugin. The available types are `sink` and `source`.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The version of the connector plugin.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private KafkaConnectStatusConnectorPlugins(
            string @class,

            string type,

            string version)
        {
            Class = @class;
            Type = type;
            Version = version;
        }
    }
}
