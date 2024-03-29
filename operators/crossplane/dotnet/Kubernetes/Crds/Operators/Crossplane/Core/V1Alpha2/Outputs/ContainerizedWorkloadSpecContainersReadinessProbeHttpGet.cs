// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2
{

    [OutputType]
    public sealed class ContainerizedWorkloadSpecContainersReadinessProbeHttpGet
    {
        /// <summary>
        /// HTTPHeaders to send with the GET request.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersReadinessProbeHttpGetHttpHeaders> HttpHeaders;
        /// <summary>
        /// Path to probe, e.g. '/healthz'.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Port to probe.
        /// </summary>
        public readonly int Port;

        [OutputConstructor]
        private ContainerizedWorkloadSpecContainersReadinessProbeHttpGet(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersReadinessProbeHttpGetHttpHeaders> httpHeaders,

            string path,

            int port)
        {
            HttpHeaders = httpHeaders;
            Path = path;
            Port = port;
        }
    }
}
