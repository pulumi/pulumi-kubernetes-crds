// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class PrometheusStatus
    {
        /// <summary>
        /// Total number of available pods (ready for at least minReadySeconds) targeted by this Prometheus deployment.
        /// </summary>
        public readonly int AvailableReplicas;
        /// <summary>
        /// Represents whether any actions on the underlaying managed objects are being performed. Only delete actions will be performed.
        /// </summary>
        public readonly bool Paused;
        /// <summary>
        /// Total number of non-terminated pods targeted by this Prometheus deployment (their labels match the selector).
        /// </summary>
        public readonly int Replicas;
        /// <summary>
        /// Total number of unavailable pods targeted by this Prometheus deployment.
        /// </summary>
        public readonly int UnavailableReplicas;
        /// <summary>
        /// Total number of non-terminated pods targeted by this Prometheus deployment that have the desired version spec.
        /// </summary>
        public readonly int UpdatedReplicas;

        [OutputConstructor]
        private PrometheusStatus(
            int availableReplicas,

            bool paused,

            int replicas,

            int unavailableReplicas,

            int updatedReplicas)
        {
            AvailableReplicas = availableReplicas;
            Paused = paused;
            Replicas = replicas;
            UnavailableReplicas = unavailableReplicas;
            UpdatedReplicas = updatedReplicas;
        }
    }
}