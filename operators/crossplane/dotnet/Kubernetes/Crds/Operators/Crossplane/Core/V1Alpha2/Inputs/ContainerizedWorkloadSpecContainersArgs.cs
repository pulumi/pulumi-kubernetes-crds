// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    /// <summary>
    /// A Container represents an Open Containers Initiative (OCI) container.
    /// </summary>
    public class ContainerizedWorkloadSpecContainersArgs : Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// Arguments to be passed to the command run by this container.
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("command")]
        private InputList<string>? _command;

        /// <summary>
        /// Command to be run by this container.
        /// </summary>
        public InputList<string> Command
        {
            get => _command ?? (_command = new InputList<string>());
            set => _command = value;
        }

        [Input("config")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersConfigArgs>? _config;

        /// <summary>
        /// ConfigFiles that should be written within this container.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersConfigArgs> Config
        {
            get => _config ?? (_config = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersConfigArgs>());
            set => _config = value;
        }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersEnvArgs>? _env;

        /// <summary>
        /// Environment variables that should be set within this container.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersEnvArgs>());
            set => _env = value;
        }

        /// <summary>
        /// Image this container should run. Must be a path-like or URI-like representation of an OCI image. May be prefixed with a registry address and should be suffixed with a tag.
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        /// <summary>
        /// ImagePullSecret specifies the name of a Secret from which the credentials required to pull this container's image can be loaded.
        /// </summary>
        [Input("imagePullSecret")]
        public Input<string>? ImagePullSecret { get; set; }

        /// <summary>
        /// A LivenessProbe assesses whether this container is alive. Containers that fail liveness probes will be restarted.
        /// </summary>
        [Input("livenessProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersLivenessProbeArgs>? LivenessProbe { get; set; }

        /// <summary>
        /// Name of this container. Must be unique within its workload.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("ports")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersPortsArgs>? _ports;

        /// <summary>
        /// Ports exposed by this container.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersPortsArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersPortsArgs>());
            set => _ports = value;
        }

        /// <summary>
        /// A ReadinessProbe assesses whether this container is ready to serve requests. Containers that fail readiness probes will be withdrawn from service.
        /// </summary>
        [Input("readinessProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersReadinessProbeArgs>? ReadinessProbe { get; set; }

        /// <summary>
        /// Resources required by this container
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesArgs>? Resources { get; set; }

        public ContainerizedWorkloadSpecContainersArgs()
        {
        }
    }
}
