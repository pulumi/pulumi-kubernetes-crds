// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1
{

    public class APISpecIntegrationMethodApicastOnPremAuthenticationSettingsErrorsArgs : Pulumi.ResourceArgs
    {
        [Input("authenticationFailed", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.APISpecIntegrationMethodApicastOnPremAuthenticationSettingsErrorsAuthenticationFailedArgs> AuthenticationFailed { get; set; } = null!;

        [Input("authenticationMissing", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.APISpecIntegrationMethodApicastOnPremAuthenticationSettingsErrorsAuthenticationMissingArgs> AuthenticationMissing { get; set; } = null!;

        public APISpecIntegrationMethodApicastOnPremAuthenticationSettingsErrorsArgs()
        {
        }
    }
}
