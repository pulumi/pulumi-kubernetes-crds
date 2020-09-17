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
    public sealed class SyncSetInstanceStatus
    {
        /// <summary>
        /// Applied will be true if all resources, patches, or secrets have successfully been applied on last attempt.
        /// </summary>
        public readonly bool Applied;
        /// <summary>
        /// Conditions is the list of SyncConditions used to indicate UnknownObject when a resource type cannot be determined from a SyncSet resource.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetInstanceStatusConditions> Conditions;
        /// <summary>
        /// FirstSuccessTimestamp is the time the syncset was successfully applied for the first time.
        /// </summary>
        public readonly string FirstSuccessTimestamp;
        /// <summary>
        /// Patches is the list of SyncStatus for patches that have been applied.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetInstanceStatusPatches> Patches;
        /// <summary>
        /// Resources is the list of SyncStatus for objects that have been synced.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetInstanceStatusResources> Resources;
        /// <summary>
        /// Secrets is the list of SyncStatus for secrets that have been synced.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetInstanceStatusSecretReferences> SecretReferences;

        [OutputConstructor]
        private SyncSetInstanceStatus(
            bool applied,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetInstanceStatusConditions> conditions,

            string firstSuccessTimestamp,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetInstanceStatusPatches> patches,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetInstanceStatusResources> resources,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.SyncSetInstanceStatusSecretReferences> secretReferences)
        {
            Applied = applied;
            Conditions = conditions;
            FirstSuccessTimestamp = firstSuccessTimestamp;
            Patches = patches;
            Resources = resources;
            SecretReferences = secretReferences;
        }
    }
}