// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class SyncIdentityProviderSpecIdentityProvidersOpenIDCa
    {
        /// <summary>
        /// name is the metadata.name of the referenced config map
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private SyncIdentityProviderSpecIdentityProvidersOpenIDCa(string name)
        {
            Name = name;
        }
    }
}
