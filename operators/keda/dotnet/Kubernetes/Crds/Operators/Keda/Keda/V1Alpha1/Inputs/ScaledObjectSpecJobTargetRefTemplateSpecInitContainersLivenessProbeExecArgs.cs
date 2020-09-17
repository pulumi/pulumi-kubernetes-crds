// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1
{

    /// <summary>
    /// One and only one of the following should be specified. Exec specifies the action to take.
    /// </summary>
    public class ScaledObjectSpecJobTargetRefTemplateSpecInitContainersLivenessProbeExecArgs : Pulumi.ResourceArgs
    {
        [Input("command")]
        private InputList<string>? _command;

        /// <summary>
        /// Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.
        /// </summary>
        public InputList<string> Command
        {
            get => _command ?? (_command = new InputList<string>());
            set => _command = value;
        }

        public ScaledObjectSpecJobTargetRefTemplateSpecInitContainersLivenessProbeExecArgs()
        {
        }
    }
}
