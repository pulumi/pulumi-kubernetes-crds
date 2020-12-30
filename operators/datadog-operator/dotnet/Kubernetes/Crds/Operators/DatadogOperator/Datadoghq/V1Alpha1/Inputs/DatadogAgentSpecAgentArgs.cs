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
    /// The desired state of the Agent as an extended daemonset Contains the Node Agent configuration and deployment strategy
    /// </summary>
    public class DatadogAgentSpecAgentArgs : Pulumi.ResourceArgs
    {
        [Input("additionalAnnotations")]
        private InputMap<string>? _additionalAnnotations;

        /// <summary>
        /// AdditionalAnnotations provide annotations that will be added to the Agent Pods.
        /// </summary>
        public InputMap<string> AdditionalAnnotations
        {
            get => _additionalAnnotations ?? (_additionalAnnotations = new InputMap<string>());
            set => _additionalAnnotations = value;
        }

        [Input("additionalLabels")]
        private InputMap<string>? _additionalLabels;

        /// <summary>
        /// AdditionalLabels provide labels that will be added to the cluster checks runner Pods.
        /// </summary>
        public InputMap<string> AdditionalLabels
        {
            get => _additionalLabels ?? (_additionalLabels = new InputMap<string>());
            set => _additionalLabels = value;
        }

        /// <summary>
        /// Trace Agent configuration
        /// </summary>
        [Input("apm")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentApmArgs>? Apm { get; set; }

        /// <summary>
        /// Agent configuration
        /// </summary>
        [Input("config")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigArgs>? Config { get; set; }

        /// <summary>
        /// Allow to put custom configuration for the agent, corresponding to the datadog.yaml config file See https://docs.datadoghq.com/agent/guide/agent-configuration-files/?tab=agentv6 for more details.
        /// </summary>
        [Input("customConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentCustomConfigArgs>? CustomConfig { get; set; }

        /// <summary>
        /// Name of the Daemonset to create or migrate from
        /// </summary>
        [Input("daemonsetName")]
        public Input<string>? DaemonsetName { get; set; }

        /// <summary>
        /// Update strategy configuration for the DaemonSet
        /// </summary>
        [Input("deploymentStrategy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyArgs>? DeploymentStrategy { get; set; }

        /// <summary>
        /// Specifies the DNS parameters of a pod. Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.
        /// </summary>
        [Input("dnsConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDnsConfigArgs>? DnsConfig { get; set; }

        /// <summary>
        /// Set DNS policy for the pod. Defaults to "ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.
        /// </summary>
        [Input("dnsPolicy")]
        public Input<string>? DnsPolicy { get; set; }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentEnvArgs>? _env;

        /// <summary>
        /// Environment variables for all Datadog Agents Ref: https://docs.datadoghq.com/agent/docker/?tab=standard#environment-variables
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentEnvArgs>());
            set => _env = value;
        }

        /// <summary>
        /// Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.
        /// </summary>
        [Input("hostNetwork")]
        public Input<bool>? HostNetwork { get; set; }

        /// <summary>
        /// Use the host's pid namespace. Optional: Default to false.
        /// </summary>
        [Input("hostPID")]
        public Input<bool>? HostPID { get; set; }

        /// <summary>
        /// The container image of the Datadog Agent
        /// </summary>
        [Input("image", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentImageArgs> Image { get; set; } = null!;

        /// <summary>
        /// Log Agent configuration
        /// </summary>
        [Input("log")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentLogArgs>? Log { get; set; }

        /// <summary>
        /// Provide Agent Network Policy configuration
        /// </summary>
        [Input("networkPolicy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentNetworkPolicyArgs>? NetworkPolicy { get; set; }

        /// <summary>
        /// If specified, indicates the pod's priority. "system-node-critical" and "system-cluster-critical" are two special keywords which indicate the highest priorities with the former being the highest priority. Any other name must be defined by creating a PriorityClass object with that name. If not specified, the pod priority will be default or zero if there is no default.
        /// </summary>
        [Input("priorityClassName")]
        public Input<string>? PriorityClassName { get; set; }

        /// <summary>
        /// Process Agent configuration
        /// </summary>
        [Input("process")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentProcessArgs>? Process { get; set; }

        /// <summary>
        /// RBAC configuration of the Agent
        /// </summary>
        [Input("rbac")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentRbacArgs>? Rbac { get; set; }

        /// <summary>
        /// Security Agent configuration
        /// </summary>
        [Input("security")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSecurityArgs>? Security { get; set; }

        /// <summary>
        /// SystemProbe configuration
        /// </summary>
        [Input("systemProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSystemProbeArgs>? SystemProbe { get; set; }

        /// <summary>
        /// UseExtendedDaemonset use ExtendedDaemonset for Agent deployment. default value is false.
        /// </summary>
        [Input("useExtendedDaemonset")]
        public Input<bool>? UseExtendedDaemonset { get; set; }

        public DatadogAgentSpecAgentArgs()
        {
        }
    }
}
