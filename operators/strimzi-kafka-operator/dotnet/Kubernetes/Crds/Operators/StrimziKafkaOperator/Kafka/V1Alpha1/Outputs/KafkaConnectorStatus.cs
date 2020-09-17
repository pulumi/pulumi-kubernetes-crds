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
    public sealed class KafkaConnectorStatus
    {
        /// <summary>
        /// List of status conditions.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaConnectorStatusConditions> Conditions;
        /// <summary>
        /// The connector status, as reported by the Kafka Connect REST API.
        /// </summary>
        public readonly ImmutableDictionary<string, object> ConnectorStatus;
        /// <summary>
        /// The generation of the CRD that was last reconciled by the operator.
        /// </summary>
        public readonly int ObservedGeneration;
        /// <summary>
        /// The maximum number of tasks for the Kafka Connector.
        /// </summary>
        public readonly int TasksMax;

        [OutputConstructor]
        private KafkaConnectorStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaConnectorStatusConditions> conditions,

            ImmutableDictionary<string, object> connectorStatus,

            int observedGeneration,

            int tasksMax)
        {
            Conditions = conditions;
            ConnectorStatus = connectorStatus;
            ObservedGeneration = observedGeneration;
            TasksMax = tasksMax;
        }
    }
}
