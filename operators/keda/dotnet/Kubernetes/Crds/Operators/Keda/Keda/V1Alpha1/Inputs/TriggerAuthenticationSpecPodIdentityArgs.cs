// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1
{

    /// <summary>
    /// AuthPodIdentity allows users to select the platform native identity mechanism
    /// </summary>
    public class TriggerAuthenticationSpecPodIdentityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// PodIdentityProvider contains the list of providers
        /// </summary>
        [Input("provider", required: true)]
        public Input<string> Provider { get; set; } = null!;

        public TriggerAuthenticationSpecPodIdentityArgs()
        {
        }
    }
}
