// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1
{

    public class APISpecIntegrationMethodApicastOnPremAuthenticationSettingsCredentialsOpenIDConnectorArgs : Pulumi.ResourceArgs
    {
        [Input("credentialsLocation", required: true)]
        public Input<string> CredentialsLocation { get; set; } = null!;

        [Input("issuer", required: true)]
        public Input<string> Issuer { get; set; } = null!;

        public APISpecIntegrationMethodApicastOnPremAuthenticationSettingsCredentialsOpenIDConnectorArgs()
        {
        }
    }
}
