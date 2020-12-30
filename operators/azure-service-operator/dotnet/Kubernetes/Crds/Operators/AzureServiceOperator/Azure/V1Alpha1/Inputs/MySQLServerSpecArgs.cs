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
    /// MySQLServerSpec defines the desired state of MySQLServer
    /// </summary>
    public class MySQLServerSpecArgs : Pulumi.ResourceArgs
    {
        [Input("createMode")]
        public Input<string>? CreateMode { get; set; }

        [Input("keyVaultToStoreSecrets")]
        public Input<string>? KeyVaultToStoreSecrets { get; set; }

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("replicaProperties")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.MySQLServerSpecReplicaPropertiesArgs>? ReplicaProperties { get; set; }

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        /// <summary>
        /// ServerVersion enumerates the values for server version.
        /// </summary>
        [Input("serverVersion")]
        public Input<string>? ServerVersion { get; set; }

        [Input("sku")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1.MySQLServerSpecSkuArgs>? Sku { get; set; }

        [Input("sslEnforcement")]
        public Input<string>? SslEnforcement { get; set; }

        public MySQLServerSpecArgs()
        {
        }
    }
}
