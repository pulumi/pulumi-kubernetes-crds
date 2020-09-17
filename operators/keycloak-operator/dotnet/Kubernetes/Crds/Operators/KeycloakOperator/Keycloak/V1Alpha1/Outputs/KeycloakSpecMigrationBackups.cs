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
    public sealed class KeycloakSpecMigrationBackups
    {
        /// <summary>
        /// If set to true, the operator will do database backup before doing migration
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private KeycloakSpecMigrationBackups(bool enabled)
        {
            Enabled = enabled;
        }
    }
}