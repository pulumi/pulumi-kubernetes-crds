// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1
{

    [OutputType]
    public sealed class ConsoleServiceSpecConsoleServerResourcesLimits
    {
        public readonly string Cpu;
        public readonly string Memory;

        [OutputConstructor]
        private ConsoleServiceSpecConsoleServerResourcesLimits(
            string cpu,

            string memory)
        {
            Cpu = cpu;
            Memory = memory;
        }
    }
}
