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
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvConfig Config;
        public readonly string ConfigUpdateStrategy;
        public readonly string DataSubDir;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvEnv> Env;
        public readonly bool HostNetwork;
        public readonly string ImagePullPolicy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvImagePullSecrets> ImagePullSecrets;
        public readonly ImmutableDictionary<string, object> Limits;
        public readonly int MaxFailoverCount;
        public readonly ImmutableDictionary<string, object> NodeSelector;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvPodSecurityContext PodSecurityContext;
        public readonly string PriorityClassName;
        public readonly bool Privileged;
        public readonly int Replicas;
        public readonly ImmutableDictionary<string, object> Requests;
        public readonly string SchedulerName;
        public readonly string ServiceAccount;
        public readonly string StorageClassName;
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

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvConfig config,

            string configUpdateStrategy,

            string dataSubDir,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvEnv> env,

            bool hostNetwork,

            string imagePullPolicy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvImagePullSecrets> imagePullSecrets,

            ImmutableDictionary<string, object> limits,

            int maxFailoverCount,

            ImmutableDictionary<string, object> nodeSelector,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikvPodSecurityContext podSecurityContext,

            string priorityClassName,

            bool privileged,

            int replicas,

            ImmutableDictionary<string, object> requests,

            string schedulerName,

            string serviceAccount,

            string storageClassName,

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
            HostNetwork = hostNetwork;
            ImagePullPolicy = imagePullPolicy;
            ImagePullSecrets = imagePullSecrets;
            Limits = limits;
            MaxFailoverCount = maxFailoverCount;
            NodeSelector = nodeSelector;
            PodSecurityContext = podSecurityContext;
            PriorityClassName = priorityClassName;
            Privileged = privileged;
            Replicas = replicas;
            Requests = requests;
            SchedulerName = schedulerName;
            ServiceAccount = serviceAccount;
            StorageClassName = storageClassName;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            Version = version;
        }
    }
}
