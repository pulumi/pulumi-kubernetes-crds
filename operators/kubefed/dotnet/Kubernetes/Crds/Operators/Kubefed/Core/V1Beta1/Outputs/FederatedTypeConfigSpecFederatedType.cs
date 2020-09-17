// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1
{

    [OutputType]
    public sealed class FederatedTypeConfigSpecFederatedType
    {
        /// <summary>
        /// Group of the resource.
        /// </summary>
        public readonly string Group;
        /// <summary>
        /// Camel-cased singular name of the resource (e.g. ConfigMap)
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Lower-cased plural name of the resource (e.g. configmaps).  If not provided, it will be computed by lower-casing the kind and suffixing an 's'.
        /// </summary>
        public readonly string PluralName;
        /// <summary>
        /// Scope of the resource.
        /// </summary>
        public readonly string Scope;
        /// <summary>
        /// Version of the resource.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private FederatedTypeConfigSpecFederatedType(
            string group,

            string kind,

            string pluralName,

            string scope,

            string version)
        {
            Group = group;
            Kind = kind;
            PluralName = pluralName;
            Scope = scope;
            Version = version;
        }
    }
}
