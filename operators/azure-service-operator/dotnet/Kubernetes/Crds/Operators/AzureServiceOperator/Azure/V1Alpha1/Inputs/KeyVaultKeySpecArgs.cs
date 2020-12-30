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
    /// KeyVaultKeySpec defines the desired state of KeyVaultKey
    /// </summary>
    public class KeyVaultKeySpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// JSONWebKeyCurveName enumerates the values for json web key curve name.
        /// </summary>
        [Input("curve")]
        public Input<string>? Curve { get; set; }

        [Input("keySize")]
        public Input<int>? KeySize { get; set; }

        [Input("keyVault")]
        public Input<string>? KeyVault { get; set; }

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("operations")]
        private InputList<string>? _operations;
        public InputList<string> Operations
        {
            get => _operations ?? (_operations = new InputList<string>());
            set => _operations = value;
        }

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        /// <summary>
        /// JSONWebKeyType enumerates the values for json web key type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public KeyVaultKeySpecArgs()
        {
        }
    }
}
