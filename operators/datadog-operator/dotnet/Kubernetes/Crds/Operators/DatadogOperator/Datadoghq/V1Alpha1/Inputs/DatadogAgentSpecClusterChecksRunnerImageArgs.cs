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
    /// The container image of the Datadog Cluster Checks Runner
    /// </summary>
    public class DatadogAgentSpecClusterChecksRunnerImageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Define the image to use Use "datadog/agent:latest" for Datadog Agent 6 Use "datadog/dogstatsd:latest" for Standalone Datadog Agent DogStatsD6 Use "datadog/cluster-agent:latest" for Datadog Cluster Agent
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Kubernetes pull policy Use Always, Never or IfNotPresent
        /// </summary>
        [Input("pullPolicy")]
        public Input<string>? PullPolicy { get; set; }

        [Input("pullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerImagePullSecretsArgs>? _pullSecrets;

        /// <summary>
        /// It is possible to specify docker registry credentials See https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerImagePullSecretsArgs> PullSecrets
        {
            get => _pullSecrets ?? (_pullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterChecksRunnerImagePullSecretsArgs>());
            set => _pullSecrets = value;
        }

        public DatadogAgentSpecClusterChecksRunnerImageArgs()
        {
        }
    }
}
