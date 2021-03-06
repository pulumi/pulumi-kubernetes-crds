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
    public sealed class EventhubSpecPropertiesCaptureDescriptionDestinationStorageAccount
    {
        /// <summary>
        /// AccountName - Name of the storage account
        /// </summary>
        public readonly string AccountName;
        /// <summary>
        /// ResourceGroup - Name of the storage account resource group
        /// </summary>
        public readonly string ResourceGroup;

        [OutputConstructor]
        private EventhubSpecPropertiesCaptureDescriptionDestinationStorageAccount(
            string accountName,

            string resourceGroup)
        {
            AccountName = accountName;
            ResourceGroup = resourceGroup;
        }
    }
}
