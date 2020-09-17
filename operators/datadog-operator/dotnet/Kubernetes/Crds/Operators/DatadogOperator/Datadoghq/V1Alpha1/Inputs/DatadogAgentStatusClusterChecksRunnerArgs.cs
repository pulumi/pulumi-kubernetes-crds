// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1
{

    /// <summary>
    /// The actual state of the Cluster Checks Runner as a deployment
    /// </summary>
    public class DatadogAgentStatusClusterChecksRunnerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.
        /// </summary>
        [Input("availableReplicas")]
        public Input<int>? AvailableReplicas { get; set; }

        [Input("currentHash")]
        public Input<string>? CurrentHash { get; set; }

        /// <summary>
        /// DeploymentName corresponds to the name of the Cluster Agent Deployment
        /// </summary>
        [Input("deploymentName")]
        public Input<string>? DeploymentName { get; set; }

        /// <summary>
        /// GeneratedToken corresponds to the generated token if any token was provided in the Credential configuration when ClusterAgent is enabled
        /// </summary>
        [Input("generatedToken")]
        public Input<string>? GeneratedToken { get; set; }

        [Input("lastUpdate")]
        public Input<string>? LastUpdate { get; set; }

        /// <summary>
        /// Total number of ready pods targeted by this deployment.
        /// </summary>
        [Input("readyReplicas")]
        public Input<int>? ReadyReplicas { get; set; }

        /// <summary>
        /// Total number of non-terminated pods targeted by this deployment (their labels match the selector).
        /// </summary>
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        /// <summary>
        /// State corresponds to the ClusterAgent deployment state
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Status corresponds to the ClusterAgent deployment computed status
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.
        /// </summary>
        [Input("unavailableReplicas")]
        public Input<int>? UnavailableReplicas { get; set; }

        /// <summary>
        /// Total number of non-terminated pods targeted by this deployment that have the desired template spec.
        /// </summary>
        [Input("updatedReplicas")]
        public Input<int>? UpdatedReplicas { get; set; }

        public DatadogAgentStatusClusterChecksRunnerArgs()
        {
        }
    }
}
