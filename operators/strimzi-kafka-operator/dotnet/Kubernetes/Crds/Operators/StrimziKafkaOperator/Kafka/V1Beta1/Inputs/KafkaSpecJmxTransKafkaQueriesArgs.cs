// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    public class KafkaSpecJmxTransKafkaQueriesArgs : Pulumi.ResourceArgs
    {
        [Input("attributes", required: true)]
        private InputList<string>? _attributes;

        /// <summary>
        /// Determine which attributes of the targeted MBean should be included.
        /// </summary>
        public InputList<string> Attributes
        {
            get => _attributes ?? (_attributes = new InputList<string>());
            set => _attributes = value;
        }

        [Input("outputs", required: true)]
        private InputList<string>? _outputs;

        /// <summary>
        /// List of the names of output definitions specified in the spec.kafka.jmxTrans.outputDefinitions that have defined where JMX metrics are pushed to, and in which data format.
        /// </summary>
        public InputList<string> Outputs
        {
            get => _outputs ?? (_outputs = new InputList<string>());
            set => _outputs = value;
        }

        /// <summary>
        /// If using wildcards instead of a specific MBean then the data is gathered from multiple MBeans. Otherwise if specifying an MBean then data is gathered from that specified MBean.
        /// </summary>
        [Input("targetMBean", required: true)]
        public Input<string> TargetMBean { get; set; } = null!;

        public KafkaSpecJmxTransKafkaQueriesArgs()
        {
        }
    }
}
