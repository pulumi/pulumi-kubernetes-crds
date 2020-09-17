// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpec
    {
        /// <summary>
        /// The desired state of the Agent as an extended daemonset Contains the Node Agent configuration and deployment strategy
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgent Agent;
        /// <summary>
        /// The desired state of the Cluster Agent as a deployment
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterAgent ClusterAgent;
        /// <summary>
        /// The desired state of the Cluster Checks Runner as a deployment
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunner ClusterChecksRunner;
        /// <summary>
        /// Set a unique cluster name to allow scoping hosts and Cluster Checks Runner easily
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// Configure the credentials required to run Agents
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecCredentials Credentials;
        /// <summary>
        /// The site of the Datadog intake to send Agent data to. Set to 'datadoghq.eu' to send data to the EU site.
        /// </summary>
        public readonly string Site;

        [OutputConstructor]
        private DatadogAgentSpec(
            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgent agent,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterAgent clusterAgent,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunner clusterChecksRunner,

            string clusterName,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecCredentials credentials,

            string site)
        {
            Agent = agent;
            ClusterAgent = clusterAgent;
            ClusterChecksRunner = clusterChecksRunner;
            ClusterName = clusterName;
            Credentials = credentials;
            Site = site;
        }
    }
}
