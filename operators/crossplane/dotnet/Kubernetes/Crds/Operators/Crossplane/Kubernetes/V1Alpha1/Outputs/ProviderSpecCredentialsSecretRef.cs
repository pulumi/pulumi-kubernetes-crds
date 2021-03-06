// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kubernetes.V1Alpha1
{

    [OutputType]
    public sealed class ProviderSpecCredentialsSecretRef
    {
        /// <summary>
        /// Name of the secret.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Namespace of the secret.
        /// </summary>
        public readonly string Namespace;

        [OutputConstructor]
        private ProviderSpecCredentialsSecretRef(
            string name,

            string @namespace)
        {
            Name = name;
            Namespace = @namespace;
        }
    }
}
