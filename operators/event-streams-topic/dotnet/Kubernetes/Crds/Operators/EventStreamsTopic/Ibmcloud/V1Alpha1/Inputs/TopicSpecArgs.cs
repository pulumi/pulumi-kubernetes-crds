// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    public class TopicSpecArgs : Pulumi.ResourceArgs
    {
        [Input("apiKey")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.TopicSpecApiKeyArgs>? ApiKey { get; set; }

        [Input("bindingFrom")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.TopicSpecBindingFromArgs>? BindingFrom { get; set; }

        [Input("configs")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.TopicSpecConfigsArgs>? _configs;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.TopicSpecConfigsArgs> Configs
        {
            get => _configs ?? (_configs = new InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.TopicSpecConfigsArgs>());
            set => _configs = value;
        }

        [Input("kafkaAdminUrl")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.TopicSpecKafkaAdminUrlArgs>? KafkaAdminUrl { get; set; }

        [Input("numPartitions")]
        public Input<int>? NumPartitions { get; set; }

        [Input("replicationFactor")]
        public Input<int>? ReplicationFactor { get; set; }

        [Input("topicName", required: true)]
        public Input<string> TopicName { get; set; } = null!;

        public TopicSpecArgs()
        {
        }
    }
}