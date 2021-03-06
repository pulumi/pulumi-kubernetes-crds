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
    /// AzureSQLManagedUserSpec defines the desired state of AzureSQLManagedUser
    /// </summary>
    public class AzureSQLManagedUserSpecArgs : Pulumi.ResourceArgs
    {
        [Input("dbName", required: true)]
        public Input<string> DbName { get; set; } = null!;

        [Input("keyVaultSecretPrefix")]
        public Input<string>? KeyVaultSecretPrefix { get; set; }

        [Input("keyVaultToStoreSecrets")]
        public Input<string>? KeyVaultToStoreSecrets { get; set; }

        [Input("managedIdentityClientId", required: true)]
        public Input<string> ManagedIdentityClientId { get; set; } = null!;

        [Input("managedIdentityName")]
        public Input<string>? ManagedIdentityName { get; set; }

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

        public AzureSQLManagedUserSpecArgs()
        {
        }
    }
}
