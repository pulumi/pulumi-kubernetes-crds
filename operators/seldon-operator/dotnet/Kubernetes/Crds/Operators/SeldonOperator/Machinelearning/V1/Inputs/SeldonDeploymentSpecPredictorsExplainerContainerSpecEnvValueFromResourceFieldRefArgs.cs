// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
    /// </summary>
    public class SeldonDeploymentSpecPredictorsExplainerContainerSpecEnvValueFromResourceFieldRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Container name: required for volumes, optional for env vars
        /// </summary>
        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        /// <summary>
        /// Specifies the output format of the exposed resources, defaults to "1"
        /// </summary>
        [Input("divisor")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsExplainerContainerSpecEnvValueFromResourceFieldRefDivisorArgs>? Divisor { get; set; }

        /// <summary>
        /// Required: resource to select
        /// </summary>
        [Input("resource", required: true)]
        public Input<string> Resource { get; set; } = null!;

        public SeldonDeploymentSpecPredictorsExplainerContainerSpecEnvValueFromResourceFieldRefArgs()
        {
        }
    }
}
