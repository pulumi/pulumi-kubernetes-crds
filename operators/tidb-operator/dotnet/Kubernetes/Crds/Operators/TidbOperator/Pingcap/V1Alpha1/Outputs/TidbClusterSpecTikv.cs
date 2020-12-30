// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class TidbClusterSpecTikv
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAdditionalContainers> AdditionalContainers;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAdditionalVolumes> AdditionalVolumes;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAffinity Affinity;
        public readonly ImmutableDictionary<string, object> Annotations;
        public readonly string BaseImage;
        public readonly object Config;
        public readonly string ConfigUpdateStrategy;
        public readonly string DataSubDir;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvEnv> Env;
        public readonly string EvictLeaderTimeout;
        public readonly bool HostNetwork;
        public readonly string ImagePullPolicy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvImagePullSecrets> ImagePullSecrets;
        public readonly ImmutableDictionary<string, object> Limits;
        public readonly int MaxFailoverCount;
        public readonly bool MountClusterClientSecret;
        public readonly ImmutableDictionary<string, object> NodeSelector;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvPodSecurityContext PodSecurityContext;
        public readonly string PriorityClassName;
        public readonly bool Privileged;
        public readonly bool RecoverFailover;
        public readonly int Replicas;
        public readonly ImmutableDictionary<string, object> Requests;
        public readonly string SchedulerName;
        public readonly string ServiceAccount;
        public readonly string StatefulSetUpdateStrategy;
        public readonly string StorageClassName;
        public readonly ImmutableArray<object> StorageVolumes;
        public readonly int TerminationGracePeriodSeconds;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvTolerations> Tolerations;
        public readonly string Version;

        [OutputConstructor]
        private TidbClusterSpecTikv(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAdditionalContainers> additionalContainers,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAdditionalVolumes> additionalVolumes,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvAffinity affinity,

            ImmutableDictionary<string, object> annotations,

            string baseImage,

            object config,

            string configUpdateStrategy,

            string dataSubDir,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvEnv> env,

            string evictLeaderTimeout,

            bool hostNetwork,

            string imagePullPolicy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvImagePullSecrets> imagePullSecrets,

            ImmutableDictionary<string, object> limits,

            int maxFailoverCount,

            bool mountClusterClientSecret,

            ImmutableDictionary<string, object> nodeSelector,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvPodSecurityContext podSecurityContext,

            string priorityClassName,

            bool privileged,

            bool recoverFailover,

            int replicas,

            ImmutableDictionary<string, object> requests,

            string schedulerName,

            string serviceAccount,

            string statefulSetUpdateStrategy,

            string storageClassName,

            ImmutableArray<object> storageVolumes,

            int terminationGracePeriodSeconds,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvTolerations> tolerations,

            string version)
        {
            AdditionalContainers = additionalContainers;
            AdditionalVolumes = additionalVolumes;
            Affinity = affinity;
            Annotations = annotations;
            BaseImage = baseImage;
            Config = config;
            ConfigUpdateStrategy = configUpdateStrategy;
            DataSubDir = dataSubDir;
            Env = env;
            EvictLeaderTimeout = evictLeaderTimeout;
            HostNetwork = hostNetwork;
            ImagePullPolicy = imagePullPolicy;
            ImagePullSecrets = imagePullSecrets;
            Limits = limits;
            MaxFailoverCount = maxFailoverCount;
            MountClusterClientSecret = mountClusterClientSecret;
            NodeSelector = nodeSelector;
            PodSecurityContext = podSecurityContext;
            PriorityClassName = priorityClassName;
            Privileged = privileged;
            RecoverFailover = recoverFailover;
            Replicas = replicas;
            Requests = requests;
            SchedulerName = schedulerName;
            ServiceAccount = serviceAccount;
            StatefulSetUpdateStrategy = statefulSetUpdateStrategy;
            StorageClassName = storageClassName;
            StorageVolumes = storageVolumes;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            Version = version;
        }
    }
}
