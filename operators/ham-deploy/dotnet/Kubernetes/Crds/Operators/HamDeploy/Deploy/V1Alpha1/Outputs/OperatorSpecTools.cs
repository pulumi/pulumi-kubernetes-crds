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
    public sealed class OperatorSpecTools
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpecToolsAssembler Assembler;
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpecToolsDiscoverer Discoverer;

        [OutputConstructor]
        private OperatorSpecTools(
            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpecToolsAssembler assembler,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpecToolsDiscoverer discoverer)
        {
            Assembler = assembler;
            Discoverer = discoverer;
        }
    }
}