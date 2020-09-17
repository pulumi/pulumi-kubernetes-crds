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
    public sealed class TidbMonitorSpec
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainers> AdditionalContainers;
        public readonly string AlertManagerRulesVersion;
        public readonly string AlertmanagerURL;
        public readonly ImmutableDictionary<string, object> Annotations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecClusters> Clusters;
        public readonly object Grafana;
        public readonly string ImagePullPolicy;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecImagePullSecrets> ImagePullSecrets;
        public readonly object Initializer;
        public readonly string KubePrometheusURL;
        public readonly ImmutableDictionary<string, object> NodeSelector;
        public readonly bool Persistent;
        public readonly object Prometheus;
        public readonly string PvReclaimPolicy;
        public readonly object Reloader;
        public readonly string Storage;
        public readonly string StorageClassName;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecTolerations> Tolerations;

        [OutputConstructor]
        private TidbMonitorSpec(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainers> additionalContainers,

            string alertManagerRulesVersion,

            string alertmanagerURL,

            ImmutableDictionary<string, object> annotations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecClusters> clusters,

            object grafana,

            string imagePullPolicy,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecImagePullSecrets> imagePullSecrets,

            object initializer,

            string kubePrometheusURL,

            ImmutableDictionary<string, object> nodeSelector,

            bool persistent,

            object prometheus,

            string pvReclaimPolicy,

            object reloader,

            string storage,

            string storageClassName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbMonitorSpecTolerations> tolerations)
        {
            AdditionalContainers = additionalContainers;
            AlertManagerRulesVersion = alertManagerRulesVersion;
            AlertmanagerURL = alertmanagerURL;
            Annotations = annotations;
            Clusters = clusters;
            Grafana = grafana;
            ImagePullPolicy = imagePullPolicy;
            ImagePullSecrets = imagePullSecrets;
            Initializer = initializer;
            KubePrometheusURL = kubePrometheusURL;
            NodeSelector = nodeSelector;
            Persistent = persistent;
            Prometheus = prometheus;
            PvReclaimPolicy = pvReclaimPolicy;
            Reloader = reloader;
            Storage = storage;
            StorageClassName = storageClassName;
            Tolerations = tolerations;
        }
    }
}
