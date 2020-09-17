// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbMonitorSpecArgs : Pulumi.ResourceArgs
    {
        [Input("additionalContainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersArgs>? _additionalContainers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersArgs> AdditionalContainers
        {
            get => _additionalContainers ?? (_additionalContainers = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecAdditionalContainersArgs>());
            set => _additionalContainers = value;
        }

        [Input("alertManagerRulesVersion")]
        public Input<string>? AlertManagerRulesVersion { get; set; }

        [Input("alertmanagerURL")]
        public Input<string>? AlertmanagerURL { get; set; }

        [Input("annotations")]
        private InputMap<object>? _annotations;
        public InputMap<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<object>());
            set => _annotations = value;
        }

        [Input("clusters", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecClustersArgs>? _clusters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecClustersArgs> Clusters
        {
            get => _clusters ?? (_clusters = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecClustersArgs>());
            set => _clusters = value;
        }

        [Input("grafana")]
        public Input<object>? Grafana { get; set; }

        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        [Input("imagePullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecImagePullSecretsArgs>? _imagePullSecrets;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecImagePullSecretsArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecImagePullSecretsArgs>());
            set => _imagePullSecrets = value;
        }

        [Input("initializer", required: true)]
        public Input<object> Initializer { get; set; } = null!;

        [Input("kubePrometheusURL")]
        public Input<string>? KubePrometheusURL { get; set; }

        [Input("nodeSelector")]
        private InputMap<object>? _nodeSelector;
        public InputMap<object> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<object>());
            set => _nodeSelector = value;
        }

        [Input("persistent")]
        public Input<bool>? Persistent { get; set; }

        [Input("prometheus", required: true)]
        public Input<object> Prometheus { get; set; } = null!;

        [Input("pvReclaimPolicy")]
        public Input<string>? PvReclaimPolicy { get; set; }

        [Input("reloader", required: true)]
        public Input<object> Reloader { get; set; } = null!;

        [Input("storage")]
        public Input<string>? Storage { get; set; }

        [Input("storageClassName")]
        public Input<string>? StorageClassName { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbMonitorSpecTolerationsArgs>());
            set => _tolerations = value;
        }

        public TidbMonitorSpecArgs()
        {
        }
    }
}