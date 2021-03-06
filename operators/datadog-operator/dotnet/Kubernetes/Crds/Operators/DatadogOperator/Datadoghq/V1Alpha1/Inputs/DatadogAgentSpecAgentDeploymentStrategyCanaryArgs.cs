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
    /// Configure the canary deployment configuration using ExtendedDaemonSet
    /// </summary>
    public class DatadogAgentSpecAgentDeploymentStrategyCanaryArgs : Pulumi.ResourceArgs
    {
        [Input("duration")]
        public Input<string>? Duration { get; set; }

        [Input("nodeAntiAffinityKeys")]
        private InputList<string>? _nodeAntiAffinityKeys;
        public InputList<string> NodeAntiAffinityKeys
        {
            get => _nodeAntiAffinityKeys ?? (_nodeAntiAffinityKeys = new InputList<string>());
            set => _nodeAntiAffinityKeys = value;
        }

        /// <summary>
        /// A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
        /// </summary>
        [Input("nodeSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyCanaryNodeSelectorArgs>? NodeSelector { get; set; }

        [Input("replicas")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentDeploymentStrategyCanaryReplicasArgs>? Replicas { get; set; }

        public DatadogAgentSpecAgentDeploymentStrategyCanaryArgs()
        {
        }
    }
}
