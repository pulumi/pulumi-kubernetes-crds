// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    /// <summary>
    /// AzureSQLUserSpec defines the desired state of SqlUser
    /// </summary>
    public class AzureSQLUserSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// optional
        /// </summary>
        [Input("adminSecret")]
        public Input<string>? AdminSecret { get; set; }

        [Input("adminSecretKeyVault")]
        public Input<string>? AdminSecretKeyVault { get; set; }

        [Input("dbName", required: true)]
        public Input<string> DbName { get; set; } = null!;

        [Input("keyVaultSecretFormats")]
        private InputList<string>? _keyVaultSecretFormats;
        public InputList<string> KeyVaultSecretFormats
        {
            get => _keyVaultSecretFormats ?? (_keyVaultSecretFormats = new InputList<string>());
            set => _keyVaultSecretFormats = value;
        }

        [Input("keyVaultSecretPrefix")]
        public Input<string>? KeyVaultSecretPrefix { get; set; }

        [Input("keyVaultToStoreSecrets")]
        public Input<string>? KeyVaultToStoreSecrets { get; set; }

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        [Input("roles", required: true)]
        private InputList<string>? _roles;
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("server", required: true)]
        public Input<string> Server { get; set; } = null!;

        [Input("username")]
        public Input<string>? Username { get; set; }

        public AzureSQLUserSpecArgs()
        {
        }
    }
}
