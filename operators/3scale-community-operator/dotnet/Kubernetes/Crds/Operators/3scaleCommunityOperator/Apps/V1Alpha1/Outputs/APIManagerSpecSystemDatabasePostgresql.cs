// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class APIManagerSpecSystemDatabasePostgresql
    {
        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlAffinity Affinity;
        public readonly string Image;
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlPersistentVolumeClaim PersistentVolumeClaim;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlTolerations> Tolerations;

        [OutputConstructor]
        private APIManagerSpecSystemDatabasePostgresql(
            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlAffinity affinity,

            string image,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlPersistentVolumeClaim persistentVolumeClaim,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlTolerations> tolerations)
        {
            Affinity = affinity;
            Image = image;
            PersistentVolumeClaim = persistentVolumeClaim;
            Tolerations = tolerations;
        }
    }
}
