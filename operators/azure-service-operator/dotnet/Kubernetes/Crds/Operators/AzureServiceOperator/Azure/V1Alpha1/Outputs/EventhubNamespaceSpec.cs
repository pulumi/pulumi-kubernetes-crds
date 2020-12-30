// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class EventhubNamespaceSpec
    {
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// EventhubNamespaceNetworkRule defines the namespace network rule
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.EventhubNamespaceSpecNetworkRule NetworkRule;
        /// <summary>
        /// EventhubNamespaceProperties defines the namespace properties
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.EventhubNamespaceSpecProperties Properties;
        public readonly string ResourceGroup;
        /// <summary>
        /// EventhubNamespaceSku defines the sku
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.EventhubNamespaceSpecSku Sku;

        [OutputConstructor]
        private EventhubNamespaceSpec(
            string location,

            Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.EventhubNamespaceSpecNetworkRule networkRule,

            Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.EventhubNamespaceSpecProperties properties,

            string resourceGroup,

            Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.EventhubNamespaceSpecSku sku)
        {
            Location = location;
            NetworkRule = networkRule;
            Properties = properties;
            ResourceGroup = resourceGroup;
            Sku = sku;
        }
    }
}
