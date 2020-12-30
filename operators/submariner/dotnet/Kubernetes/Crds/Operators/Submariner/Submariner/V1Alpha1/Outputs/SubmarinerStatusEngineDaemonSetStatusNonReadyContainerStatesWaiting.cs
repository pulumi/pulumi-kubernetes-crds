// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1
{

    [OutputType]
    public sealed class SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStatesWaiting
    {
        /// <summary>
        /// Message regarding why the container is not yet running.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// (brief) reason the container is not yet running.
        /// </summary>
        public readonly string Reason;

        [OutputConstructor]
        private SubmarinerStatusEngineDaemonSetStatusNonReadyContainerStatesWaiting(
            string message,

            string reason)
        {
            Message = message;
            Reason = reason;
        }
    }
}
