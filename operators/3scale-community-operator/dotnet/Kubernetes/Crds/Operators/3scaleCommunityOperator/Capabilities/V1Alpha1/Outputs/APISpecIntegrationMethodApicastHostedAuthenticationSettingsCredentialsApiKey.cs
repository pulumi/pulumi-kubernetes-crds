// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Alpha1
{

    [OutputType]
    public sealed class APISpecIntegrationMethodApicastHostedAuthenticationSettingsCredentialsApiKey
    {
        public readonly string AuthParameterName;
        public readonly string CredentialsLocation;

        [OutputConstructor]
        private APISpecIntegrationMethodApicastHostedAuthenticationSettingsCredentialsApiKey(
            string authParameterName,

            string credentialsLocation)
        {
            AuthParameterName = authParameterName;
            CredentialsLocation = credentialsLocation;
        }
    }
}