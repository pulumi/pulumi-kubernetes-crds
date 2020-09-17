// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIUnitySpecDriverController
    {
        /// <summary>
        /// Args is the set of arguments for the container
        /// </summary>
        public readonly ImmutableArray<string> Args;
        /// <summary>
        /// Envs is the set of environment variables for the container
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIUnitySpecDriverControllerEnvs> Envs;
        /// <summary>
        /// Image is the image tag for the Container
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// ImagePullPolicy is the image pull policy for the image
        /// </summary>
        public readonly string ImagePullPolicy;
        /// <summary>
        /// Name is the name of Container
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private CSIUnitySpecDriverController(
            ImmutableArray<string> args,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIUnitySpecDriverControllerEnvs> envs,

            string image,

            string imagePullPolicy,

            string name)
        {
            Args = args;
            Envs = envs;
            Image = image;
            ImagePullPolicy = imagePullPolicy;
            Name = name;
        }
    }
}
