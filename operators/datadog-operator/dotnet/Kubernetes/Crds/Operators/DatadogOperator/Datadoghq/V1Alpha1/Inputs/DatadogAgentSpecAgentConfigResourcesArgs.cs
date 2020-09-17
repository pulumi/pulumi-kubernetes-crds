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
    /// Datadog Agent resource requests and limits Make sure to keep requests and limits equal to keep the pods in the Guaranteed QoS class Ref: http://kubernetes.io/docs/user-guide/compute-resources/
    /// </summary>
    public class DatadogAgentSpecAgentConfigResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigResourcesLimitsArgs>? _limits;

        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigResourcesLimitsArgs> Limits
        {
            get => _limits ?? (_limits = new InputMap<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigResourcesLimitsArgs>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigResourcesRequestsArgs>? _requests;

        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigResourcesRequestsArgs> Requests
        {
            get => _requests ?? (_requests = new InputMap<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigResourcesRequestsArgs>());
            set => _requests = value;
        }

        public DatadogAgentSpecAgentConfigResourcesArgs()
        {
        }
    }
}
