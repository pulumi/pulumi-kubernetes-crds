// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecAgentConfigDogstatsd
    {
        /// <summary>
        /// Enable origin detection for container tagging https://docs.datadoghq.com/developers/dogstatsd/unix_socket/#using-origin-detection-for-container-tagging
        /// </summary>
        public readonly bool DogstatsdOriginDetection;
        /// <summary>
        /// Enable dogstatsd over Unix Domain Socket ref: https://docs.datadoghq.com/developers/dogstatsd/unix_socket/
        /// </summary>
        public readonly bool UseDogStatsDSocketVolume;

        [OutputConstructor]
        private DatadogAgentSpecAgentConfigDogstatsd(
            bool dogstatsdOriginDetection,

            bool useDogStatsDSocketVolume)
        {
            DogstatsdOriginDetection = dogstatsdOriginDetection;
            UseDogStatsDSocketVolume = useDogStatsDSocketVolume;
        }
    }
}