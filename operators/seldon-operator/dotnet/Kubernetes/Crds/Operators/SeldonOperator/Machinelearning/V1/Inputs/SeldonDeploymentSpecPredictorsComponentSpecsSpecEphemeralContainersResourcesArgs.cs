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
    /// Resources are not allowed for ephemeral containers. Ephemeral containers use spare resources already allocated to the pod.
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersResourcesLimitsArgs>? _limits;

        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersResourcesLimitsArgs> Limits
        {
            get => _limits ?? (_limits = new InputMap<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersResourcesLimitsArgs>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersResourcesRequestsArgs>? _requests;

        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersResourcesRequestsArgs> Requests
        {
            get => _requests ?? (_requests = new InputMap<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersResourcesRequestsArgs>());
            set => _requests = value;
        }

        public SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersResourcesArgs()
        {
        }
    }
}