// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1
{

    [OutputType]
    public sealed class KubeFedConfigSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecClusterHealthCheck ClusterHealthCheck;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecControllerDuration ControllerDuration;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecFeatureGates> FeatureGates;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecLeaderElect LeaderElect;
        /// <summary>
        /// The scope of the KubeFed control plane should be either `Namespaced` or `Cluster`. `Namespaced` indicates that the KubeFed namespace will be the only target of the control plane.
        /// </summary>
        public readonly string Scope;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecSyncController SyncController;

        [OutputConstructor]
        private KubeFedConfigSpec(
            Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecClusterHealthCheck clusterHealthCheck,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecControllerDuration controllerDuration,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecFeatureGates> featureGates,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecLeaderElect leaderElect,

            string scope,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1.KubeFedConfigSpecSyncController syncController)
        {
            ClusterHealthCheck = clusterHealthCheck;
            ControllerDuration = controllerDuration;
            FeatureGates = featureGates;
            LeaderElect = leaderElect;
            Scope = scope;
            SyncController = syncController;
        }
    }
}
