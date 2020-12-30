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
    /// Configuration of the node label which will be used as the client.rack consumer configuration.
    /// </summary>
    public class KafkaConnectS2ISpecRackArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A key that matches labels assigned to the Kubernetes cluster nodes. The value of the label is used to set the broker's `broker.rack` config.
        /// </summary>
        [Input("topologyKey", required: true)]
        public Input<string> TopologyKey { get; set; } = null!;

        public KafkaConnectS2ISpecRackArgs()
        {
        }
    }
}
