// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Resources defines the Compute Resources required by the container for Dex.
    /// </summary>
    public class ArgoCDSpecDexResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecDexResourcesLimitsArgs>? _limits;

        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecDexResourcesLimitsArgs> Limits
        {
            get => _limits ?? (_limits = new InputMap<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecDexResourcesLimitsArgs>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecDexResourcesRequestsArgs>? _requests;

        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecDexResourcesRequestsArgs> Requests
        {
            get => _requests ?? (_requests = new InputMap<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ArgoCDSpecDexResourcesRequestsArgs>());
            set => _requests = value;
        }

        public ArgoCDSpecDexResourcesArgs()
        {
        }
    }
}
