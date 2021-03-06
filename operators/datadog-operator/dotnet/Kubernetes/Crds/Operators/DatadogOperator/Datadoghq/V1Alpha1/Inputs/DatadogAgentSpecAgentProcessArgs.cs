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
    /// Process Agent configuration
    /// </summary>
    public class DatadogAgentSpecAgentProcessArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable this to activate live process monitoring. Note: /etc/passwd is automatically mounted to allow username resolution. ref: https://docs.datadoghq.com/graphing/infrastructure/process/#kubernetes-daemonset
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentProcessEnvArgs>? _env;

        /// <summary>
        /// The Datadog Agent supports many environment variables Ref: https://docs.datadoghq.com/agent/docker/?tab=standard#environment-variables
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentProcessEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentProcessEnvArgs>());
            set => _env = value;
        }

        /// <summary>
        /// Datadog Process Agent resource requests and limits Make sure to keep requests and limits equal to keep the pods in the Guaranteed QoS class Ref: http://kubernetes.io/docs/user-guide/compute-resources/
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentProcessResourcesArgs>? Resources { get; set; }

        public DatadogAgentSpecAgentProcessArgs()
        {
        }
    }
}
