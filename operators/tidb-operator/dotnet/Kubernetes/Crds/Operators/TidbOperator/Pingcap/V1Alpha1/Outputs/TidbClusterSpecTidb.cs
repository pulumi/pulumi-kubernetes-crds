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
    public sealed class TidbClusterSpecTidb
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbAdditionalContainers> AdditionalContainers;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbAdditionalVolumes> AdditionalVolumes;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbAffinity Affinity;
        public readonly ImmutableDictionary<string, object> Annotations;
        public readonly string BaseImage;
        public readonly bool BinlogEnabled;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfig Config;
        public readonly string ConfigUpdateStrategy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbEnv> Env;
        public readonly bool HostNetwork;
        public readonly string ImagePullPolicy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbImagePullSecrets> ImagePullSecrets;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbLifecycle Lifecycle;
        public readonly ImmutableDictionary<string, object> Limits;
        public readonly int MaxFailoverCount;
        public readonly ImmutableDictionary<string, object> NodeSelector;
        public readonly ImmutableArray<string> Plugins;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbPodSecurityContext PodSecurityContext;
        public readonly string PriorityClassName;
        public readonly int Replicas;
        public readonly ImmutableDictionary<string, object> Requests;
        public readonly string SchedulerName;
        public readonly bool SeparateSlowLog;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbService Service;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbSlowLogTailer SlowLogTailer;
        public readonly int TerminationGracePeriodSeconds;
        public readonly object TlsClient;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbTolerations> Tolerations;
        public readonly string Version;

        [OutputConstructor]
        private TidbClusterSpecTidb(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbAdditionalContainers> additionalContainers,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbAdditionalVolumes> additionalVolumes,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbAffinity affinity,

            ImmutableDictionary<string, object> annotations,

            string baseImage,

            bool binlogEnabled,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbConfig config,

            string configUpdateStrategy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbEnv> env,

            bool hostNetwork,

            string imagePullPolicy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbImagePullSecrets> imagePullSecrets,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbLifecycle lifecycle,

            ImmutableDictionary<string, object> limits,

            int maxFailoverCount,

            ImmutableDictionary<string, object> nodeSelector,

            ImmutableArray<string> plugins,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbPodSecurityContext podSecurityContext,

            string priorityClassName,

            int replicas,

            ImmutableDictionary<string, object> requests,

            string schedulerName,

            bool separateSlowLog,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbService service,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbSlowLogTailer slowLogTailer,

            int terminationGracePeriodSeconds,

            object tlsClient,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidbTolerations> tolerations,

            string version)
        {
            AdditionalContainers = additionalContainers;
            AdditionalVolumes = additionalVolumes;
            Affinity = affinity;
            Annotations = annotations;
            BaseImage = baseImage;
            BinlogEnabled = binlogEnabled;
            Config = config;
            ConfigUpdateStrategy = configUpdateStrategy;
            Env = env;
            HostNetwork = hostNetwork;
            ImagePullPolicy = imagePullPolicy;
            ImagePullSecrets = imagePullSecrets;
            Lifecycle = lifecycle;
            Limits = limits;
            MaxFailoverCount = maxFailoverCount;
            NodeSelector = nodeSelector;
            Plugins = plugins;
            PodSecurityContext = podSecurityContext;
            PriorityClassName = priorityClassName;
            Replicas = replicas;
            Requests = requests;
            SchedulerName = schedulerName;
            SeparateSlowLog = separateSlowLog;
            Service = service;
            SlowLogTailer = slowLogTailer;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            TlsClient = tlsClient;
            Tolerations = tolerations;
            Version = version;
        }
    }
}
