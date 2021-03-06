// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1
{

    [OutputType]
    public sealed class KeycloakRealmSpecRealmUsersCredentials
    {
        /// <summary>
        /// True if this credential object is temporary.
        /// </summary>
        public readonly bool Temporary;
        /// <summary>
        /// Credential Type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Credential Value.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private KeycloakRealmSpecRealmUsersCredentials(
            bool temporary,

            string type,

            string value)
        {
            Temporary = temporary;
            Type = type;
            Value = value;
        }
    }
}
