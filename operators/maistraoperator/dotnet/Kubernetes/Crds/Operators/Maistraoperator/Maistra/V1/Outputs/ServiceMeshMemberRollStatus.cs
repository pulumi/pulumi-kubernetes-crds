// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Maistra.V1
{

    [OutputType]
    public sealed class ServiceMeshMemberRollStatus
    {
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V1.ServiceMeshMemberRollStatusConditions> Conditions;
        public readonly ImmutableArray<string> ConfiguredMembers;
        public readonly int MeshGeneration;
        public readonly string MeshReconciledVersion;
        public readonly int ObservedGeneration;
        public readonly ImmutableArray<string> PendingMembers;

        [OutputConstructor]
        private ServiceMeshMemberRollStatus(
            ImmutableDictionary<string, string> annotations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V1.ServiceMeshMemberRollStatusConditions> conditions,

            ImmutableArray<string> configuredMembers,

            int meshGeneration,

            string meshReconciledVersion,

            int observedGeneration,

            ImmutableArray<string> pendingMembers)
        {
            Annotations = annotations;
            Conditions = conditions;
            ConfiguredMembers = configuredMembers;
            MeshGeneration = meshGeneration;
            MeshReconciledVersion = meshReconciledVersion;
            ObservedGeneration = observedGeneration;
            PendingMembers = pendingMembers;
        }
    }
}
