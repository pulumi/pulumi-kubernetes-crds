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
    /// KeyVaultSpec defines the desired state of KeyVault
    /// </summary>
    public class KeyVaultSpecArgs : Pulumi.ResourceArgs
    {
        [Input("accessPolicies")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultSpecAccessPoliciesArgs>? _accessPolicies;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultSpecAccessPoliciesArgs> AccessPolicies
        {
            get => _accessPolicies ?? (_accessPolicies = new InputList<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultSpecAccessPoliciesArgs>());
            set => _accessPolicies = value;
        }

        [Input("enableSoftDelete")]
        public Input<bool>? EnableSoftDelete { get; set; }

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("networkPolicies")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultSpecNetworkPoliciesArgs>? NetworkPolicies { get; set; }

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        /// <summary>
        /// KeyVaultSku the SKU of the Key Vault
        /// </summary>
        [Input("sku")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.KeyVaultSpecSkuArgs>? Sku { get; set; }

        public KeyVaultSpecArgs()
        {
        }
    }
}
