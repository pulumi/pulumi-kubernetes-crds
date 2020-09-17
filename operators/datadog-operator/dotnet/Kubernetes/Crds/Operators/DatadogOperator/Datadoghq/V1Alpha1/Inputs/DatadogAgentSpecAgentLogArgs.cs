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
    /// Log Agent configuration
    /// </summary>
    public class DatadogAgentSpecAgentLogArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Collect logs from files in /var/log/pods instead of using container runtime API. It's usually the most efficient way of collecting logs. ref: https://docs.datadoghq.com/agent/basic_agent_usage/kubernetes/#log-collection-setup Default: true
        /// </summary>
        [Input("containerCollectUsingFiles")]
        public Input<bool>? ContainerCollectUsingFiles { get; set; }

        /// <summary>
        /// This to allow log collection from container log path. Set to a different path if not using docker runtime. ref: https://docs.datadoghq.com/agent/kubernetes/daemonset_setup/?tab=k8sfile#create-manifest Default to `/var/lib/docker/containers`
        /// </summary>
        [Input("containerLogsPath")]
        public Input<string>? ContainerLogsPath { get; set; }

        /// <summary>
        /// Enables this to activate Datadog Agent log collection. ref: https://docs.datadoghq.com/agent/basic_agent_usage/kubernetes/#log-collection-setup
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Enable this to allow log collection for all containers. ref: https://docs.datadoghq.com/agent/basic_agent_usage/kubernetes/#log-collection-setup
        /// </summary>
        [Input("logsConfigContainerCollectAll")]
        public Input<bool>? LogsConfigContainerCollectAll { get; set; }

        /// <summary>
        /// Set the maximum number of logs files that the Datadog Agent will tail up to. Increasing this limit can increase resource consumption of the Agent. ref: https://docs.datadoghq.com/agent/basic_agent_usage/kubernetes/#log-collection-setup Default to 100
        /// </summary>
        [Input("openFilesLimit")]
        public Input<int>? OpenFilesLimit { get; set; }

        /// <summary>
        /// This to allow log collection from pod log path. Default to `/var/log/pods`
        /// </summary>
        [Input("podLogsPath")]
        public Input<string>? PodLogsPath { get; set; }

        /// <summary>
        /// This path (always mounted from the host) is used by Datadog Agent to store information about processed log files. If the Datadog Agent is restarted, it allows to start tailing the log files from the right offset Default to `/var/lib/datadog-agent/logs`
        /// </summary>
        [Input("tempStoragePath")]
        public Input<string>? TempStoragePath { get; set; }

        public DatadogAgentSpecAgentLogArgs()
        {
        }
    }
}