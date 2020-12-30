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
    /// SystemProbe configuration
    /// </summary>
    public class DatadogAgentSpecAgentSystemProbeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AppArmorProfileName specify a apparmor profile
        /// </summary>
        [Input("appArmorProfileName")]
        public Input<string>? AppArmorProfileName { get; set; }

        /// <summary>
        /// BPFDebugEnabled logging for kernel debug
        /// </summary>
        [Input("bpfDebugEnabled")]
        public Input<bool>? BpfDebugEnabled { get; set; }

        /// <summary>
        /// CollectDNSStats enables DNS stat collection
        /// </summary>
        [Input("collectDNSStats")]
        public Input<bool>? CollectDNSStats { get; set; }

        /// <summary>
        /// ConntrackEnabled enable the system-probe agent to connect to the netlink/conntrack subsystem to add NAT information to connection data Ref: http://conntrack-tools.netfilter.org/
        /// </summary>
        [Input("conntrackEnabled")]
        public Input<bool>? ConntrackEnabled { get; set; }

        /// <summary>
        /// DebugPort Specify the port to expose pprof and expvar for system-probe agent
        /// </summary>
        [Input("debugPort")]
        public Input<int>? DebugPort { get; set; }

        /// <summary>
        /// EnableOOMKill enables the OOM kill eBPF-based check
        /// </summary>
        [Input("enableOOMKill")]
        public Input<bool>? EnableOOMKill { get; set; }

        /// <summary>
        /// EnableTCPQueueLength enables the TCP queue length eBPF-based check
        /// </summary>
        [Input("enableTCPQueueLength")]
        public Input<bool>? EnableTCPQueueLength { get; set; }

        /// <summary>
        /// Enable this to activate live process monitoring. Note: /etc/passwd is automatically mounted to allow username resolution. ref: https://docs.datadoghq.com/graphing/infrastructure/process/#kubernetes-daemonset
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSystemProbeEnvArgs>? _env;

        /// <summary>
        /// The Datadog SystemProbe supports many environment variables Ref: https://docs.datadoghq.com/agent/docker/?tab=standard#environment-variables
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSystemProbeEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSystemProbeEnvArgs>());
            set => _env = value;
        }

        /// <summary>
        /// Datadog SystemProbe resource requests and limits Make sure to keep requests and limits equal to keep the pods in the Guaranteed QoS class Ref: http://kubernetes.io/docs/user-guide/compute-resources/
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSystemProbeResourcesArgs>? Resources { get; set; }

        /// <summary>
        /// SecCompCustomProfileConfigMap specify a pre-existing ConfigMap containing a custom SecComp profile
        /// </summary>
        [Input("secCompCustomProfileConfigMap")]
        public Input<string>? SecCompCustomProfileConfigMap { get; set; }

        /// <summary>
        /// SecCompProfileName specify a seccomp profile
        /// </summary>
        [Input("secCompProfileName")]
        public Input<string>? SecCompProfileName { get; set; }

        /// <summary>
        /// SecCompRootPath specify the seccomp profile root directory
        /// </summary>
        [Input("secCompRootPath")]
        public Input<string>? SecCompRootPath { get; set; }

        /// <summary>
        /// You can modify the security context used to run the containers by modifying the label type
        /// </summary>
        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSystemProbeSecurityContextArgs>? SecurityContext { get; set; }

        public DatadogAgentSpecAgentSystemProbeArgs()
        {
        }
    }
}
