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
    public sealed class AzureNetworkInterfaceSpec
    {
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        public readonly string Location;
        public readonly string PublicIPAddressName;
        public readonly string ResourceGroup;
        public readonly string SubnetName;
        public readonly string VnetName;

        [OutputConstructor]
        private AzureNetworkInterfaceSpec(
            string location,

            string publicIPAddressName,

            string resourceGroup,

            string subnetName,

            string vnetName)
        {
            Location = location;
            PublicIPAddressName = publicIPAddressName;
            ResourceGroup = resourceGroup;
            SubnetName = subnetName;
            VnetName = vnetName;
        }
    }
}
