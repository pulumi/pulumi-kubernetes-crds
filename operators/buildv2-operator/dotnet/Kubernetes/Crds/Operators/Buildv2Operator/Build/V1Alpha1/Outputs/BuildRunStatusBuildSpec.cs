// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1
{

    [OutputType]
    public sealed class BuildRunStatusBuildSpec
    {
        /// <summary>
        /// BuilderImage refers to the image containing the build tools inside which the source code would be built.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecBuilder Builder;
        /// <summary>
        /// Dockerfile is the path to the Dockerfile to be used for build strategies which bank on the Dockerfile for building an image.
        /// </summary>
        public readonly string Dockerfile;
        /// <summary>
        /// Output refers to the location where the generated image would be pushed to.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecOutput Output;
        /// <summary>
        /// Parameters contains name-value that could be used to loosely type parameters in the BuildStrategy.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecParameters> Parameters;
        /// <summary>
        /// Runtime represents the runtime-image
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecRuntime Runtime;
        /// <summary>
        /// Source refers to the Git repository containing the source code to be built.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecSource Source;
        /// <summary>
        /// StrategyRef refers to the BuildStrategy to be used to build the container image. There are namespaced scope and cluster scope BuildStrategy
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecStrategy Strategy;
        /// <summary>
        /// Timeout defines the maximum run time of a build run.
        /// </summary>
        public readonly string Timeout;

        [OutputConstructor]
        private BuildRunStatusBuildSpec(
            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecBuilder builder,

            string dockerfile,

            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecOutput output,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecParameters> parameters,

            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecRuntime runtime,

            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecSource source,

            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecStrategy strategy,

            string timeout)
        {
            Builder = builder;
            Dockerfile = dockerfile;
            Output = output;
            Parameters = parameters;
            Runtime = runtime;
            Source = source;
            Strategy = strategy;
            Timeout = timeout;
        }
    }
}