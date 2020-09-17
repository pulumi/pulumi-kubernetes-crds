// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2
{

    [OutputType]
    public sealed class ContainerizedWorkloadSpecContainers
    {
        /// <summary>
        /// Arguments to be passed to the command run by this container.
        /// </summary>
        public readonly ImmutableArray<string> Args;
        /// <summary>
        /// Command to be run by this container.
        /// </summary>
        public readonly ImmutableArray<string> Command;
        /// <summary>
        /// ConfigFiles that should be written within this container.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersConfig> Config;
        /// <summary>
        /// Environment variables that should be set within this container.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersEnv> Env;
        /// <summary>
        /// Image this container should run. Must be a path-like or URI-like representation of an OCI image. May be prefixed with a registry address and should be suffixed with a tag.
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// ImagePullSecret specifies the name of a Secret from which the credentials required to pull this container's image can be loaded.
        /// </summary>
        public readonly string ImagePullSecret;
        /// <summary>
        /// A LivenessProbe assesses whether this container is alive. Containers that fail liveness probes will be restarted.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbe LivenessProbe;
        /// <summary>
        /// Name of this container. Must be unique within its workload.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Ports exposed by this container.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersPorts> Ports;
        /// <summary>
        /// A ReadinessProbe assesses whether this container is ready to serve requests. Containers that fail readiness probes will be withdrawn from service.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersReadinessProbe ReadinessProbe;
        /// <summary>
        /// Resources required by this container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResources Resources;

        [OutputConstructor]
        private ContainerizedWorkloadSpecContainers(
            ImmutableArray<string> args,

            ImmutableArray<string> command,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersConfig> config,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersEnv> env,

            string image,

            string imagePullSecret,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbe livenessProbe,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersPorts> ports,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersReadinessProbe readinessProbe,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResources resources)
        {
            Args = args;
            Command = command;
            Config = config;
            Env = env;
            Image = image;
            ImagePullSecret = imagePullSecret;
            LivenessProbe = livenessProbe;
            Name = name;
            Ports = ports;
            ReadinessProbe = readinessProbe;
            Resources = resources;
        }
    }
}