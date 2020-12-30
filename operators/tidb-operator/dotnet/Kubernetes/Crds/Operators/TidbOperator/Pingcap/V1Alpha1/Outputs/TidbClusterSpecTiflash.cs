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
    public sealed class TidbClusterSpecTiflash
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalContainers> AdditionalContainers;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalVolumes> AdditionalVolumes;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAffinity Affinity;
        public readonly ImmutableDictionary<string, object> Annotations;
        public readonly string BaseImage;
        public readonly object Config;
        public readonly string ConfigUpdateStrategy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashEnv> Env;
        public readonly bool HostNetwork;
        public readonly string ImagePullPolicy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashImagePullSecrets> ImagePullSecrets;
        public readonly ImmutableDictionary<string, object> Limits;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashLogTailer LogTailer;
        public readonly int MaxFailoverCount;
        public readonly ImmutableDictionary<string, object> NodeSelector;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashPodSecurityContext PodSecurityContext;
        public readonly string PriorityClassName;
        public readonly bool Privileged;
        public readonly bool RecoverFailover;
        public readonly int Replicas;
        public readonly ImmutableDictionary<string, object> Requests;
        public readonly string SchedulerName;
        public readonly string ServiceAccount;
        public readonly string StatefulSetUpdateStrategy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashStorageClaims> StorageClaims;
        public readonly int TerminationGracePeriodSeconds;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashTolerations> Tolerations;
        public readonly string Version;

        [OutputConstructor]
        private TidbClusterSpecTiflash(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalContainers> additionalContainers,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAdditionalVolumes> additionalVolumes,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashAffinity affinity,

            ImmutableDictionary<string, object> annotations,

            string baseImage,

            object config,

            string configUpdateStrategy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashEnv> env,

            bool hostNetwork,

            string imagePullPolicy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashImagePullSecrets> imagePullSecrets,

            ImmutableDictionary<string, object> limits,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashLogTailer logTailer,

            int maxFailoverCount,

            ImmutableDictionary<string, object> nodeSelector,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashPodSecurityContext podSecurityContext,

            string priorityClassName,

            bool privileged,

            bool recoverFailover,

            int replicas,

            ImmutableDictionary<string, object> requests,

            string schedulerName,

            string serviceAccount,

            string statefulSetUpdateStrategy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashStorageClaims> storageClaims,

            int terminationGracePeriodSeconds,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashTolerations> tolerations,

            string version)
        {
            AdditionalContainers = additionalContainers;
            AdditionalVolumes = additionalVolumes;
            Affinity = affinity;
            Annotations = annotations;
            BaseImage = baseImage;
            Config = config;
            ConfigUpdateStrategy = configUpdateStrategy;
            Env = env;
            HostNetwork = hostNetwork;
            ImagePullPolicy = imagePullPolicy;
            ImagePullSecrets = imagePullSecrets;
            Limits = limits;
            LogTailer = logTailer;
            MaxFailoverCount = maxFailoverCount;
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
            StorageClaims = storageClaims;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            Version = version;
        }
    }
}
