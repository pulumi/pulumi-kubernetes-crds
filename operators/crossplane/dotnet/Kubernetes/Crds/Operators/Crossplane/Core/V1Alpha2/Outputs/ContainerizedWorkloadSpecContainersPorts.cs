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
    public sealed class ContainerizedWorkloadSpecContainersPorts
    {
        /// <summary>
        /// Port number. Must be unique within its container.
        /// </summary>
        public readonly int ContainerPort;
        /// <summary>
        /// Name of this port. Must be unique within its container. Must be lowercase alphabetical characters.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Protocol used by the server listening on this port.
        /// </summary>
        public readonly string Protocol;

        [OutputConstructor]
        private ContainerizedWorkloadSpecContainersPorts(
            int containerPort,

            string name,

            string protocol)
        {
            ContainerPort = containerPort;
            Name = name;
            Protocol = protocol;
        }
    }
}
