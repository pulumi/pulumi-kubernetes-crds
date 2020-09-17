// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1
{

    [OutputType]
    public sealed class OperatorSpecCoreDeployable
    {
        public readonly ImmutableArray<string> Args;
        public readonly ImmutableArray<string> Command;
        public readonly bool Enabled;
        public readonly string Image;
        public readonly string Name;

        [OutputConstructor]
        private OperatorSpecCoreDeployable(
            ImmutableArray<string> args,

            ImmutableArray<string> command,

            bool enabled,

            string image,

            string name)
        {
            Args = args;
            Command = command;
            Enabled = enabled;
            Image = image;
            Name = name;
        }
    }
}
