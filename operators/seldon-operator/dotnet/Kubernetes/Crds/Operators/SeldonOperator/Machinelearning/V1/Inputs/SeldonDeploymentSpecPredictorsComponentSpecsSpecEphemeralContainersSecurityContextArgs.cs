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
    /// SecurityContext is not allowed for ephemeral containers.
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersSecurityContextArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN
        /// </summary>
        [Input("allowPrivilegeEscalation")]
        public Input<bool>? AllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.
        /// </summary>
        [Input("capabilities")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersSecurityContextCapabilitiesArgs>? Capabilities { get; set; }

        /// <summary>
        /// Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false.
        /// </summary>
        [Input("privileged")]
        public Input<bool>? Privileged { get; set; }

        /// <summary>
        /// procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled.
        /// </summary>
        [Input("procMount")]
        public Input<string>? ProcMount { get; set; }

        /// <summary>
        /// Whether this container has a read-only root filesystem. Default is false.
        /// </summary>
        [Input("readOnlyRootFilesystem")]
        public Input<bool>? ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [Input("runAsGroup")]
        public Input<int>? RunAsGroup { get; set; }

        /// <summary>
        /// Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [Input("runAsNonRoot")]
        public Input<bool>? RunAsNonRoot { get; set; }

        /// <summary>
        /// The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [Input("runAsUser")]
        public Input<int>? RunAsUser { get; set; }

        /// <summary>
        /// The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [Input("seLinuxOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersSecurityContextSeLinuxOptionsArgs>? SeLinuxOptions { get; set; }

        /// <summary>
        /// The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [Input("windowsOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersSecurityContextWindowsOptionsArgs>? WindowsOptions { get; set; }

        public SeldonDeploymentSpecPredictorsComponentSpecsSpecEphemeralContainersSecurityContextArgs()
        {
        }
    }
}
