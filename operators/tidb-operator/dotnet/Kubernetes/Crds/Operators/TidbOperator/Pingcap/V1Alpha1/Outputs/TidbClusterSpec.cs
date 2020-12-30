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
    public sealed class TidbClusterSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecAffinity Affinity;
        public readonly ImmutableDictionary<string, object> Annotations;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecCluster Cluster;
        public readonly string ConfigUpdateStrategy;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecDiscovery Discovery;
        public readonly bool EnableDynamicConfiguration;
        public readonly bool EnablePVReclaim;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecHelper Helper;
        public readonly bool HostNetwork;
        public readonly string ImagePullPolicy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecImagePullSecrets> ImagePullSecrets;
        public readonly ImmutableDictionary<string, object> NodeSelector;
        public readonly bool Paused;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecPd Pd;
        public readonly ImmutableArray<string> PdAddresses;
        public readonly string PriorityClassName;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecPump Pump;
        public readonly string PvReclaimPolicy;
        public readonly string SchedulerName;
        public readonly string ServiceAccount;
        public readonly string StatefulSetUpdateStrategy;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTicdc Ticdc;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidb Tidb;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflash Tiflash;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikv Tikv;
        public readonly string Timezone;
        public readonly object TlsCluster;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTolerations> Tolerations;
        public readonly string Version;

        [OutputConstructor]
        private TidbClusterSpec(
            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecAffinity affinity,

            ImmutableDictionary<string, object> annotations,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecCluster cluster,

            string configUpdateStrategy,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecDiscovery discovery,

            bool enableDynamicConfiguration,

            bool enablePVReclaim,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecHelper helper,

            bool hostNetwork,

            string imagePullPolicy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecImagePullSecrets> imagePullSecrets,

            ImmutableDictionary<string, object> nodeSelector,

            bool paused,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecPd pd,

            ImmutableArray<string> pdAddresses,

            string priorityClassName,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecPump pump,

            string pvReclaimPolicy,

            string schedulerName,

            string serviceAccount,

            string statefulSetUpdateStrategy,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTicdc ticdc,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTidb tidb,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflash tiflash,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTikv tikv,

            string timezone,

            object tlsCluster,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTolerations> tolerations,

            string version)
        {
            Affinity = affinity;
            Annotations = annotations;
            Cluster = cluster;
            ConfigUpdateStrategy = configUpdateStrategy;
            Discovery = discovery;
            EnableDynamicConfiguration = enableDynamicConfiguration;
            EnablePVReclaim = enablePVReclaim;
            Helper = helper;
            HostNetwork = hostNetwork;
            ImagePullPolicy = imagePullPolicy;
            ImagePullSecrets = imagePullSecrets;
            NodeSelector = nodeSelector;
            Paused = paused;
            Pd = pd;
            PdAddresses = pdAddresses;
            PriorityClassName = priorityClassName;
            Pump = pump;
            PvReclaimPolicy = pvReclaimPolicy;
            SchedulerName = schedulerName;
            ServiceAccount = serviceAccount;
            StatefulSetUpdateStrategy = statefulSetUpdateStrategy;
            Ticdc = ticdc;
            Tidb = tidb;
            Tiflash = tiflash;
            Tikv = tikv;
            Timezone = timezone;
            TlsCluster = tlsCluster;
            Tolerations = tolerations;
            Version = version;
        }
    }
}
