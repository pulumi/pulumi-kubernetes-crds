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
    public sealed class WorkloadDefinitionSpec
    {
        /// <summary>
        /// Reference to the CustomResourceDefinition that defines this workload kind.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.WorkloadDefinitionSpecDefinitionRef DefinitionRef;

        [OutputConstructor]
        private WorkloadDefinitionSpec(Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.WorkloadDefinitionSpecDefinitionRef definitionRef)
        {
            DefinitionRef = definitionRef;
        }
    }
}
