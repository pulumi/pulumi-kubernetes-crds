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
    /// The status of the Kafka Bridge.
    /// </summary>
    public class KafkaBridgeStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaBridgeStatusConditionsArgs>? _conditions;

        /// <summary>
        /// List of status conditions.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaBridgeStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaBridgeStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// The generation of the CRD that was last reconciled by the operator.
        /// </summary>
        [Input("observedGeneration")]
        public Input<int>? ObservedGeneration { get; set; }

        /// <summary>
        /// Label selector for pods providing this resource.
        /// </summary>
        [Input("podSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaBridgeStatusPodSelectorArgs>? PodSelector { get; set; }

        /// <summary>
        /// The current number of pods being used to provide this resource.
        /// </summary>
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        /// <summary>
        /// The URL at which external client applications can access the Kafka Bridge.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public KafkaBridgeStatusArgs()
        {
        }
    }
}