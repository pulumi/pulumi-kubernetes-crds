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
    public sealed class ScopeDefinitionSpecDefinitionRef
    {
        /// <summary>
        /// Name of the referenced CustomResourceDefinition.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ScopeDefinitionSpecDefinitionRef(string name)
        {
            Name = name;
        }
    }
}
