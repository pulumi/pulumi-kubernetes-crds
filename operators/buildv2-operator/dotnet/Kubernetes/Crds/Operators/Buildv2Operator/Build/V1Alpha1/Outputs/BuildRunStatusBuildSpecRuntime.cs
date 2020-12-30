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
    public sealed class BuildRunStatusBuildSpecRuntime
    {
        /// <summary>
        /// Base runtime base image.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecRuntimeBase Base;
        /// <summary>
        /// Entrypoint runtime-image entrypoint.
        /// </summary>
        public readonly ImmutableArray<string> Entrypoint;
        /// <summary>
        /// Env environment variables for runtime.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Env;
        /// <summary>
        /// Labels map of additional labels to be applied on image.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// Paths list of directories/files to be copied into runtime-image, using colon ":" to split up source and destination paths.
        /// </summary>
        public readonly ImmutableArray<string> Paths;
        /// <summary>
        /// Run arbitrary commands to run before copying data into runtime-image.
        /// </summary>
        public readonly ImmutableArray<string> Run;
        /// <summary>
        /// User definitions of user and group for runtime-image.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecRuntimeUser User;
        /// <summary>
        /// WorkDir runtime image working directory `WORKDIR`.
        /// </summary>
        public readonly string WorkDir;

        [OutputConstructor]
        private BuildRunStatusBuildSpecRuntime(
            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecRuntimeBase @base,

            ImmutableArray<string> entrypoint,

            ImmutableDictionary<string, string> env,

            ImmutableDictionary<string, string> labels,

            ImmutableArray<string> paths,

            ImmutableArray<string> run,

            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecRuntimeUser user,

            string workDir)
        {
            Base = @base;
            Entrypoint = entrypoint;
            Env = env;
            Labels = labels;
            Paths = paths;
            Run = run;
            User = user;
            WorkDir = workDir;
        }
    }
}
