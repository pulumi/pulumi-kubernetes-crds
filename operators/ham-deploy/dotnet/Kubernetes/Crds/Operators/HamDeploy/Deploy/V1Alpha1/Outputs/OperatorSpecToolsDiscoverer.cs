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
    public sealed class OperatorSpecToolsDiscoverer
    {
        public readonly ImmutableArray<string> Args;
        public readonly string Clustername;
        public readonly string Clusternamespace;
        public readonly ImmutableArray<string> Command;
        public readonly bool Enabled;
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpecToolsDiscovererHubconfig Hubconfig;
        public readonly string Image;
        public readonly string Name;

        [OutputConstructor]
        private OperatorSpecToolsDiscoverer(
            ImmutableArray<string> args,

            string clustername,

            string clusternamespace,

            ImmutableArray<string> command,

            bool enabled,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpecToolsDiscovererHubconfig hubconfig,

            string image,

            string name)
        {
            Args = args;
            Clustername = clustername;
            Clusternamespace = clusternamespace;
            Command = command;
            Enabled = enabled;
            Hubconfig = hubconfig;
            Image = image;
            Name = name;
        }
    }
}
