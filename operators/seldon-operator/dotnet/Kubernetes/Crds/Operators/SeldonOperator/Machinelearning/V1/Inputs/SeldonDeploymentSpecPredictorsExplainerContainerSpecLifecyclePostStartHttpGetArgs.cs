// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// HTTPGet specifies the http request to perform.
    /// </summary>
    public class SeldonDeploymentSpecPredictorsExplainerContainerSpecLifecyclePostStartHttpGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("httpHeaders")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsExplainerContainerSpecLifecyclePostStartHttpGetHttpHeadersArgs>? _httpHeaders;

        /// <summary>
        /// Custom headers to set in the request. HTTP allows repeated headers.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsExplainerContainerSpecLifecyclePostStartHttpGetHttpHeadersArgs> HttpHeaders
        {
            get => _httpHeaders ?? (_httpHeaders = new InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsExplainerContainerSpecLifecyclePostStartHttpGetHttpHeadersArgs>());
            set => _httpHeaders = value;
        }

        /// <summary>
        /// Path to access on the HTTP server.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        /// </summary>
        [Input("port", required: true)]
        public InputUnion<int, string> Port { get; set; } = null!;

        /// <summary>
        /// Scheme to use for connecting to the host. Defaults to HTTP.
        /// </summary>
        [Input("scheme")]
        public Input<string>? Scheme { get; set; }

        public SeldonDeploymentSpecPredictorsExplainerContainerSpecLifecyclePostStartHttpGetArgs()
        {
        }
    }
}
