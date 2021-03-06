// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1
{

    /// <summary>
    /// BuildRunSpec defines the desired state of BuildRun
    /// </summary>
    public class BuildRunSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// BuildRef refers to the Build
        /// </summary>
        [Input("buildRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildRunSpecBuildRefArgs> BuildRef { get; set; } = null!;

        /// <summary>
        /// Output refers to the location where the generated image would be pushed to. It will overwrite the output image in build spec
        /// </summary>
        [Input("output")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildRunSpecOutputArgs>? Output { get; set; }

        /// <summary>
        /// ServiceAccount refers to the kubernetes serviceaccount which is used for resource control. Default serviceaccount will be set if it is empty
        /// </summary>
        [Input("serviceAccount")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildRunSpecServiceAccountArgs>? ServiceAccount { get; set; }

        /// <summary>
        /// Timeout defines the maximum run time of this build run.
        /// </summary>
        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        public BuildRunSpecArgs()
        {
        }
    }
}
