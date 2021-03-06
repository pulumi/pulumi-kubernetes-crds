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
    /// Configure Dogstatsd
    /// </summary>
    public class DatadogAgentSpecAgentConfigDogstatsdArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable origin detection for container tagging https://docs.datadoghq.com/developers/dogstatsd/unix_socket/#using-origin-detection-for-container-tagging
        /// </summary>
        [Input("dogstatsdOriginDetection")]
        public Input<bool>? DogstatsdOriginDetection { get; set; }

        /// <summary>
        /// Enable dogstatsd over Unix Domain Socket ref: https://docs.datadoghq.com/developers/dogstatsd/unix_socket/
        /// </summary>
        [Input("useDogStatsDSocketVolume")]
        public Input<bool>? UseDogStatsDSocketVolume { get; set; }

        public DatadogAgentSpecAgentConfigDogstatsdArgs()
        {
        }
    }
}
