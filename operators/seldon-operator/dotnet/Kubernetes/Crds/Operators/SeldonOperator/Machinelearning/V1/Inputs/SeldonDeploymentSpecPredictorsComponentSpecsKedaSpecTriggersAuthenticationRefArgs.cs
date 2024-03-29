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
    /// ScaledObjectAuthRef points to the TriggerAuthentication object that is used to authenticate the scaler with the environment
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecTriggersAuthenticationRefArgs : Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public SeldonDeploymentSpecPredictorsComponentSpecsKedaSpecTriggersAuthenticationRefArgs()
        {
        }
    }
}
