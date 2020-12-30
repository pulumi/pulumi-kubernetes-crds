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
    /// EventhubNamespaceSpec defines the desired state of EventhubNamespace
    /// </summary>
    public class EventhubNamespaceSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// EventhubNamespaceNetworkRule defines the namespace network rule
        /// </summary>
        [Input("networkRule")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.EventhubNamespaceSpecNetworkRuleArgs>? NetworkRule { get; set; }

        /// <summary>
        /// EventhubNamespaceProperties defines the namespace properties
        /// </summary>
        [Input("properties")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.EventhubNamespaceSpecPropertiesArgs>? Properties { get; set; }

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        /// <summary>
        /// EventhubNamespaceSku defines the sku
        /// </summary>
        [Input("sku")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.EventhubNamespaceSpecSkuArgs>? Sku { get; set; }

        public EventhubNamespaceSpecArgs()
        {
        }
    }
}