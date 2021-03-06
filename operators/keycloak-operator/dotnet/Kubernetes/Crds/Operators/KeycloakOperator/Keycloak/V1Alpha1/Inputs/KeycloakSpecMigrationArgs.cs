// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1
{

    /// <summary>
    /// Specify Migration configuration
    /// </summary>
    public class KeycloakSpecMigrationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Set it to config backup policy for migration
        /// </summary>
        [Input("backups")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Keycloak.V1Alpha1.KeycloakSpecMigrationBackupsArgs>? Backups { get; set; }

        public KeycloakSpecMigrationArgs()
        {
        }
    }
}
