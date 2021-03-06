// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1
{

    /// <summary>
    /// IopingSpec defines the ioping benchmark run
    /// </summary>
    public class IopingSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Args are appended to the predefined ioping parameters
        /// </summary>
        [Input("args")]
        public Input<string>? Args { get; set; }

        /// <summary>
        /// Image defines the ioping docker image used for the benchmark
        /// </summary>
        [Input("image", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.IopingSpecImageArgs> Image { get; set; } = null!;

        /// <summary>
        /// PodConfig contains the configuration for the benchmark pod, including pod labels and scheduling policies (affinity, toleration, node selector...)
        /// </summary>
        [Input("podConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.IopingSpecPodConfigArgs>? PodConfig { get; set; }

        /// <summary>
        /// Volume contains the configuration for the volume that the ioping job should run on.
        /// </summary>
        [Input("volume", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.IopingSpecVolumeArgs> Volume { get; set; } = null!;

        public IopingSpecArgs()
        {
        }
    }
}
