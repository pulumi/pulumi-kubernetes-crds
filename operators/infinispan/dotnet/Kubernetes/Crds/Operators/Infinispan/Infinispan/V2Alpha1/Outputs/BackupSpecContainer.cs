// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1
{

    [OutputType]
    public sealed class BackupSpecContainer
    {
        public readonly string Cpu;
        public readonly string ExtraJvmOpts;
        public readonly string Memory;

        [OutputConstructor]
        private BackupSpecContainer(
            string cpu,

            string extraJvmOpts,

            string memory)
        {
            Cpu = cpu;
            ExtraJvmOpts = extraJvmOpts;
            Memory = memory;
        }
    }
}