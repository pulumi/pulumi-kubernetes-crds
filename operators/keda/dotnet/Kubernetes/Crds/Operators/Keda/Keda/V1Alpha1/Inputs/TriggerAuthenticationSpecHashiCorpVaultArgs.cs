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
    /// HashiCorpVault is used to authenticate using Hashicorp Vault
    /// </summary>
    public class TriggerAuthenticationSpecHashiCorpVaultArgs : Pulumi.ResourceArgs
    {
        [Input("address", required: true)]
        public Input<string> Address { get; set; } = null!;

        /// <summary>
        /// VaultAuthentication contains the list of Hashicorp Vault authentication methods
        /// </summary>
        [Input("authentication", required: true)]
        public Input<string> Authentication { get; set; } = null!;

        /// <summary>
        /// Credential defines the Hashicorp Vault credentials depending on the authentication method
        /// </summary>
        [Input("credential")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1.TriggerAuthenticationSpecHashiCorpVaultCredentialArgs>? Credential { get; set; }

        [Input("mount")]
        public Input<string>? Mount { get; set; }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("secrets", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1.TriggerAuthenticationSpecHashiCorpVaultSecretsArgs>? _secrets;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1.TriggerAuthenticationSpecHashiCorpVaultSecretsArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1.TriggerAuthenticationSpecHashiCorpVaultSecretsArgs>());
            set => _secrets = value;
        }

        public TriggerAuthenticationSpecHashiCorpVaultArgs()
        {
        }
    }
}
