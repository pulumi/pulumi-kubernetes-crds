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
    public sealed class ContainerizedWorkloadSpecContainersLivenessProbeExec
    {
        /// <summary>
        /// Command to be run by this probe.
        /// </summary>
        public readonly ImmutableArray<string> Command;

        [OutputConstructor]
        private ContainerizedWorkloadSpecContainersLivenessProbeExec(ImmutableArray<string> command)
        {
            Command = command;
        }
    }
}
