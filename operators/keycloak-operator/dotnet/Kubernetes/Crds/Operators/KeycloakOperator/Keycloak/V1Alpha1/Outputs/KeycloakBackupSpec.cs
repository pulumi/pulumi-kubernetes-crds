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
    public sealed class KeycloakBackupSpec
    {
        /// <summary>
        /// If provided, an automatic database backup will be created on AWS S3 instead of a local Persistent Volume. If this property is not provided - a local Persistent Volume backup will be chosen.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1.KeycloakBackupSpecAws Aws;
        /// <summary>
        /// Selector for looking up Keycloak Custom Resources.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1.KeycloakBackupSpecInstanceSelector InstanceSelector;
        /// <summary>
        /// Controls automatic restore behavior. Currently not implemented. 
        ///  In the future this will be used to trigger automatic restore for a given KeycloakBackup. Each backup will correspond to a single snapshot of the database (stored either in a Persistent Volume or AWS). If a user wants to restore it, all he/she needs to do is to change this flag to true. Potentially, it will be possible to restore a single backup multiple times.
        /// </summary>
        public readonly bool Restore;
        /// <summary>
        /// Name of the StorageClass for Postgresql Backup Persistent Volume Claim
        /// </summary>
        public readonly string StorageClassName;

        [OutputConstructor]
        private KeycloakBackupSpec(
            Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1.KeycloakBackupSpecAws aws,

            Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1.KeycloakBackupSpecInstanceSelector instanceSelector,

            bool restore,

            string storageClassName)
        {
            Aws = aws;
            InstanceSelector = instanceSelector;
            Restore = restore;
            StorageClassName = storageClassName;
        }
    }
}
