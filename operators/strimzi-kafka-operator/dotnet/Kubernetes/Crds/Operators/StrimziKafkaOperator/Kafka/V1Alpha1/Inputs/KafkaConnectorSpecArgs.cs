// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    /// <summary>
    /// The specification of the Kafka Connector.
    /// </summary>
    public class KafkaConnectorSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Class for the Kafka Connector.
        /// </summary>
        [Input("class")]
        public Input<string>? Class { get; set; }

        [Input("config")]
        private InputMap<object>? _config;

        /// <summary>
        /// The Kafka Connector configuration. The following properties cannot be set: connector.class, tasks.max.
        /// </summary>
        public InputMap<object> Config
        {
            get => _config ?? (_config = new InputMap<object>());
            set => _config = value;
        }

        /// <summary>
        /// Whether the connector should be paused. Defaults to false.
        /// </summary>
        [Input("pause")]
        public Input<bool>? Pause { get; set; }

        /// <summary>
        /// The maximum number of tasks for the Kafka Connector.
        /// </summary>
        [Input("tasksMax")]
        public Input<int>? TasksMax { get; set; }

        public KafkaConnectorSpecArgs()
        {
        }
    }
}
