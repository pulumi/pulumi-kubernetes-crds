// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1
{

    public class APISpecIntegrationMethodApicastHostedAuthenticationSettingsCredentialsArgs : Pulumi.ResourceArgs
    {
        [Input("apiKey")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.APISpecIntegrationMethodApicastHostedAuthenticationSettingsCredentialsApiKeyArgs>? ApiKey { get; set; }

        [Input("appID")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.APISpecIntegrationMethodApicastHostedAuthenticationSettingsCredentialsAppIDArgs>? AppID { get; set; }

        [Input("openIDConnector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Alpha1.APISpecIntegrationMethodApicastHostedAuthenticationSettingsCredentialsOpenIDConnectorArgs>? OpenIDConnector { get; set; }

        public APISpecIntegrationMethodApicastHostedAuthenticationSettingsCredentialsArgs()
        {
        }
    }
}
