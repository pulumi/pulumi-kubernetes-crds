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
    /// Allow to put custom configuration for the agent, corresponding to the datadog-cluster.yaml config file
    /// </summary>
    public class DatadogAgentSpecClusterAgentCustomConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ConfigData corresponds to the configuration file content
        /// </summary>
        [Input("configData")]
        public Input<string>? ConfigData { get; set; }

        /// <summary>
        /// ConfigMap name of a ConfigMap used to mount the configuration file
        /// </summary>
        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecClusterAgentCustomConfigConfigMapArgs>? ConfigMap { get; set; }

        public DatadogAgentSpecClusterAgentCustomConfigArgs()
        {
        }
    }
}