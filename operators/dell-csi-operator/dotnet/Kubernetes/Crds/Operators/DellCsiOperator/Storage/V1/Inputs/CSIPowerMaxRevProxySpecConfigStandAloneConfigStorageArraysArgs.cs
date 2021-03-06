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
    /// StorageArrayConfig represents a storage array managed by reverse proxy
    /// </summary>
    public class CSIPowerMaxRevProxySpecConfigStandAloneConfigStorageArraysArgs : Pulumi.ResourceArgs
    {
        [Input("backupURL")]
        public Input<string>? BackupURL { get; set; }

        [Input("primaryURL", required: true)]
        public Input<string> PrimaryURL { get; set; } = null!;

        [Input("proxyCredentialSecrets", required: true)]
        private InputList<string>? _proxyCredentialSecrets;
        public InputList<string> ProxyCredentialSecrets
        {
            get => _proxyCredentialSecrets ?? (_proxyCredentialSecrets = new InputList<string>());
            set => _proxyCredentialSecrets = value;
        }

        [Input("storageArrayId", required: true)]
        public Input<string> StorageArrayId { get; set; } = null!;

        public CSIPowerMaxRevProxySpecConfigStandAloneConfigStorageArraysArgs()
        {
        }
    }
}
