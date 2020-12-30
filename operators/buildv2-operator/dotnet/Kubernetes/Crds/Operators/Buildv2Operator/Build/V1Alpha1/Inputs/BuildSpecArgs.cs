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
    /// BuildSpec defines the desired state of Build
    /// </summary>
    public class BuildSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// BuilderImage refers to the image containing the build tools inside which the source code would be built.
        /// </summary>
        [Input("builder")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecBuilderArgs>? Builder { get; set; }

        /// <summary>
        /// Dockerfile is the path to the Dockerfile to be used for build strategies which bank on the Dockerfile for building an image.
        /// </summary>
        [Input("dockerfile")]
        public Input<string>? Dockerfile { get; set; }

        /// <summary>
        /// Output refers to the location where the generated image would be pushed to.
        /// </summary>
        [Input("output", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecOutputArgs> Output { get; set; } = null!;

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecParametersArgs>? _parameters;

        /// <summary>
        /// Parameters contains name-value that could be used to loosely type parameters in the BuildStrategy.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecParametersArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// Runtime represents the runtime-image
        /// </summary>
        [Input("runtime")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecRuntimeArgs>? Runtime { get; set; }

        /// <summary>
        /// Source refers to the Git repository containing the source code to be built.
        /// </summary>
        [Input("source", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecSourceArgs> Source { get; set; } = null!;

        /// <summary>
        /// StrategyRef refers to the BuildStrategy to be used to build the container image. There are namespaced scope and cluster scope BuildStrategy
        /// </summary>
        [Input("strategy", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecStrategyArgs> Strategy { get; set; } = null!;

        /// <summary>
        /// Timeout defines the maximum run time of a build run.
        /// </summary>
        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        public BuildSpecArgs()
        {
        }
    }
}
