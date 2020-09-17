// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1
{

    /// <summary>
    /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
    /// </summary>
    public class DatadogAgentSpecClusterAgentConfigVolumesAzureFileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// the name of secret that contains Azure Storage Account Name and Key
        /// </summary>
        [Input("secretName", required: true)]
        public Input<string> SecretName { get; set; } = null!;

        /// <summary>
        /// Share Name
        /// </summary>
        [Input("shareName", required: true)]
        public Input<string> ShareName { get; set; } = null!;

        public DatadogAgentSpecClusterAgentConfigVolumesAzureFileArgs()
        {
        }
    }
}
