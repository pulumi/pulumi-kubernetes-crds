// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    /// <summary>
    /// StandAloneConfig is one of the configuration modes for reverse proxy
    /// </summary>
    public class CSIPowerMaxRevProxySpecConfigStandAloneConfigArgs : Pulumi.ResourceArgs
    {
        [Input("managementServers", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServersArgs>? _managementServers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServersArgs> ManagementServers
        {
            get => _managementServers ?? (_managementServers = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServersArgs>());
            set => _managementServers = value;
        }

        [Input("storageArrays", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigStorageArraysArgs>? _storageArrays;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigStorageArraysArgs> StorageArrays
        {
            get => _storageArrays ?? (_storageArrays = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigStorageArraysArgs>());
            set => _storageArrays = value;
        }

        public CSIPowerMaxRevProxySpecConfigStandAloneConfigArgs()
        {
        }
    }
}
