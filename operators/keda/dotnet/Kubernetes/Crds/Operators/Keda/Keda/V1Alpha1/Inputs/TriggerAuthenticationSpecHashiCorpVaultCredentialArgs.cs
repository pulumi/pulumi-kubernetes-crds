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
    /// Credential defines the Hashicorp Vault credentials depending on the authentication method
    /// </summary>
    public class TriggerAuthenticationSpecHashiCorpVaultCredentialArgs : Pulumi.ResourceArgs
    {
        [Input("serviceAccount")]
        public Input<string>? ServiceAccount { get; set; }

        [Input("token")]
        public Input<string>? Token { get; set; }

        public TriggerAuthenticationSpecHashiCorpVaultCredentialArgs()
        {
        }
    }
}