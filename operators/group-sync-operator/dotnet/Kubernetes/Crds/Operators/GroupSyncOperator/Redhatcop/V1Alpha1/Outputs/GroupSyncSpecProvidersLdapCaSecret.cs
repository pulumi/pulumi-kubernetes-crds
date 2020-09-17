// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class GroupSyncSpecProvidersLdapCaSecret
    {
        /// <summary>
        /// Key represents the specific key to reference from the secret
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Name represents the name of the secret
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Namespace represents the namespace containing the secret
        /// </summary>
        public readonly string Namespace;

        [OutputConstructor]
        private GroupSyncSpecProvidersLdapCaSecret(
            string key,

            string name,

            string @namespace)
        {
            Key = key;
            Name = name;
            Namespace = @namespace;
        }
    }
}
