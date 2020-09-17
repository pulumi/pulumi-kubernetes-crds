// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Velero.V1
{

    [OutputType]
    public sealed class ServerStatusRequestStatus
    {
        /// <summary>
        /// Phase is the current lifecycle phase of the ServerStatusRequest.
        /// </summary>
        public readonly string Phase;
        /// <summary>
        /// Plugins list information about the plugins running on the Velero server
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Velero.V1.ServerStatusRequestStatusPlugins> Plugins;
        /// <summary>
        /// ProcessedTimestamp is when the ServerStatusRequest was processed by the ServerStatusRequestController.
        /// </summary>
        public readonly string ProcessedTimestamp;
        /// <summary>
        /// ServerVersion is the Velero server version.
        /// </summary>
        public readonly string ServerVersion;

        [OutputConstructor]
        private ServerStatusRequestStatus(
            string phase,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Velero.V1.ServerStatusRequestStatusPlugins> plugins,

            string processedTimestamp,

            string serverVersion)
        {
            Phase = phase;
            Plugins = plugins;
            ProcessedTimestamp = processedTimestamp;
            ServerVersion = serverVersion;
        }
    }
}