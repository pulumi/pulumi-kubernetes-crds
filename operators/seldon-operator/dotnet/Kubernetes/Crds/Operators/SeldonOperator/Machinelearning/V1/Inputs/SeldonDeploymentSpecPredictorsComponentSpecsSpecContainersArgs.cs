// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// A single application container that you want to run within a pod.
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersArgs : Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("command")]
        private InputList<string>? _command;

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        public InputList<string> Command
        {
            get => _command ?? (_command = new InputList<string>());
            set => _command = value;
        }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersEnvArgs>? _env;

        /// <summary>
        /// List of environment variables to set in the container. Cannot be updated.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersEnvArgs>());
            set => _env = value;
        }

        [Input("envFrom")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersEnvFromArgs>? _envFrom;

        /// <summary>
        /// List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersEnvFromArgs> EnvFrom
        {
            get => _envFrom ?? (_envFrom = new InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersEnvFromArgs>());
            set => _envFrom = value;
        }

        /// <summary>
        /// Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        /// </summary>
        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        /// <summary>
        /// Actions that the management system should take in response to container lifecycle events. Cannot be updated.
        /// </summary>
        [Input("lifecycle")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecycleArgs>? Lifecycle { get; set; }

        /// <summary>
        /// Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Input("livenessProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLivenessProbeArgs>? LivenessProbe { get; set; }

        /// <summary>
        /// Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("ports")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersPortsArgs>? _ports;

        /// <summary>
        /// List of ports to expose from the container. Exposing a port here gives the system additional information about the network connections a container uses, but is primarily informational. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default "0.0.0.0" address inside a container will be accessible from the network. Cannot be updated.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersPortsArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersPortsArgs>());
            set => _ports = value;
        }

        /// <summary>
        /// Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Input("readinessProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersReadinessProbeArgs>? ReadinessProbe { get; set; }

        /// <summary>
        /// Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersResourcesArgs>? Resources { get; set; }

        /// <summary>
        /// Security options the pod should run with. More info: https://kubernetes.io/docs/concepts/policy/security-context/ More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/
        /// </summary>
        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersSecurityContextArgs>? SecurityContext { get; set; }

        /// <summary>
        /// Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.
        /// </summary>
        [Input("stdin")]
        public Input<bool>? Stdin { get; set; }

        /// <summary>
        /// Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
        /// </summary>
        [Input("stdinOnce")]
        public Input<bool>? StdinOnce { get; set; }

        /// <summary>
        /// Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
        /// </summary>
        [Input("terminationMessagePath")]
        public Input<string>? TerminationMessagePath { get; set; }

        /// <summary>
        /// Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.
        /// </summary>
        [Input("terminationMessagePolicy")]
        public Input<string>? TerminationMessagePolicy { get; set; }

        /// <summary>
        /// Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.
        /// </summary>
        [Input("tty")]
        public Input<bool>? Tty { get; set; }

        [Input("volumeDevices")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersVolumeDevicesArgs>? _volumeDevices;

        /// <summary>
        /// volumeDevices is the list of block devices to be used by the container. This is a beta feature.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersVolumeDevicesArgs> VolumeDevices
        {
            get => _volumeDevices ?? (_volumeDevices = new InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersVolumeDevicesArgs>());
            set => _volumeDevices = value;
        }

        [Input("volumeMounts")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersVolumeMountsArgs>? _volumeMounts;

        /// <summary>
        /// Pod volumes to mount into the container's filesystem. Cannot be updated.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersVolumeMountsArgs> VolumeMounts
        {
            get => _volumeMounts ?? (_volumeMounts = new InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersVolumeMountsArgs>());
            set => _volumeMounts = value;
        }

        /// <summary>
        /// Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.
        /// </summary>
        [Input("workingDir")]
        public Input<string>? WorkingDir { get; set; }

        public SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersArgs()
        {
        }
    }
}
