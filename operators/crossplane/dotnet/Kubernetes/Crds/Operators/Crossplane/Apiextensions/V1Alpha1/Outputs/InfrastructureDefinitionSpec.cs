// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apiextensions.V1Alpha1
{

    [OutputType]
    public sealed class InfrastructureDefinitionSpec
    {
        /// <summary>
        /// ConnectionSecretKeys is the list of keys that will be exposed to the end user of the defined kind.
        /// </summary>
        public readonly ImmutableArray<string> ConnectionSecretKeys;
        /// <summary>
        /// CRDSpecTemplate is the base CRD template. The final CRD will have additional fields to the base template to accommodate Crossplane machinery.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apiextensions.V1Alpha1.InfrastructureDefinitionSpecCrdSpecTemplate CrdSpecTemplate;

        [OutputConstructor]
        private InfrastructureDefinitionSpec(
            ImmutableArray<string> connectionSecretKeys,

            Pulumi.Kubernetes.Types.Outputs.Apiextensions.V1Alpha1.InfrastructureDefinitionSpecCrdSpecTemplate crdSpecTemplate)
        {
            ConnectionSecretKeys = connectionSecretKeys;
            CrdSpecTemplate = crdSpecTemplate;
        }
    }
}