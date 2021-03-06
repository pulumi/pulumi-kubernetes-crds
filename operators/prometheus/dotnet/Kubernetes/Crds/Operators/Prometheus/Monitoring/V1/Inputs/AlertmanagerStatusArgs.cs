// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Most recent observed status of the Alertmanager cluster. Read-only. Not included when requesting from the apiserver, only from the Prometheus Operator API itself. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    public class AlertmanagerStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Total number of available pods (ready for at least minReadySeconds) targeted by this Alertmanager cluster.
        /// </summary>
        [Input("availableReplicas", required: true)]
        public Input<int> AvailableReplicas { get; set; } = null!;

        /// <summary>
        /// Represents whether any actions on the underlaying managed objects are being performed. Only delete actions will be performed.
        /// </summary>
        [Input("paused", required: true)]
        public Input<bool> Paused { get; set; } = null!;

        /// <summary>
        /// Total number of non-terminated pods targeted by this Alertmanager cluster (their labels match the selector).
        /// </summary>
        [Input("replicas", required: true)]
        public Input<int> Replicas { get; set; } = null!;

        /// <summary>
        /// Total number of unavailable pods targeted by this Alertmanager cluster.
        /// </summary>
        [Input("unavailableReplicas", required: true)]
        public Input<int> UnavailableReplicas { get; set; } = null!;

        /// <summary>
        /// Total number of non-terminated pods targeted by this Alertmanager cluster that have the desired version spec.
        /// </summary>
        [Input("updatedReplicas", required: true)]
        public Input<int> UpdatedReplicas { get; set; } = null!;

        public AlertmanagerStatusArgs()
        {
        }
    }
}
