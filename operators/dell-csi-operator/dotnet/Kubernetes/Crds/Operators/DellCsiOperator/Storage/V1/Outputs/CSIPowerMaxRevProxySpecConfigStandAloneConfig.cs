// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIPowerMaxRevProxySpecConfigStandAloneConfig
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServers> ManagementServers;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigStorageArrays> StorageArrays;

        [OutputConstructor]
        private CSIPowerMaxRevProxySpecConfigStandAloneConfig(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServers> managementServers,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigStorageArrays> storageArrays)
        {
            ManagementServers = managementServers;
            StorageArrays = storageArrays;
        }
    }
}
