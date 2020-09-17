// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Velero.V1
{

    /// <summary>
    /// Exec defines an exec hook.
    /// </summary>
    public class ScheduleSpecTemplateHooksResourcesPreExecArgs : Pulumi.ResourceArgs
    {
        [Input("command", required: true)]
        private InputList<string>? _command;

        /// <summary>
        /// Command is the command and arguments to execute.
        /// </summary>
        public InputList<string> Command
        {
            get => _command ?? (_command = new InputList<string>());
            set => _command = value;
        }

        /// <summary>
        /// Container is the container in the pod where the command should be executed. If not specified, the pod's first container is used.
        /// </summary>
        [Input("container")]
        public Input<string>? Container { get; set; }

        /// <summary>
        /// OnError specifies how Velero should behave if it encounters an error executing this hook.
        /// </summary>
        [Input("onError")]
        public Input<string>? OnError { get; set; }

        /// <summary>
        /// Timeout defines the maximum amount of time Velero should wait for the hook to complete before considering the execution a failure.
        /// </summary>
        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        public ScheduleSpecTemplateHooksResourcesPreExecArgs()
        {
        }
    }
}
