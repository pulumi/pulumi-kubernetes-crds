// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    /// <summary>
    /// HTTPGet probes a container's health by sending an HTTP GET request.
    /// </summary>
    public class ContainerizedWorkloadSpecContainersReadinessProbeHttpGetArgs : Pulumi.ResourceArgs
    {
        [Input("httpHeaders")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersReadinessProbeHttpGetHttpHeadersArgs>? _httpHeaders;

        /// <summary>
        /// HTTPHeaders to send with the GET request.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersReadinessProbeHttpGetHttpHeadersArgs> HttpHeaders
        {
            get => _httpHeaders ?? (_httpHeaders = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersReadinessProbeHttpGetHttpHeadersArgs>());
            set => _httpHeaders = value;
        }

        /// <summary>
        /// Path to probe, e.g. '/healthz'.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// Port to probe.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        public ContainerizedWorkloadSpecContainersReadinessProbeHttpGetArgs()
        {
        }
    }
}
